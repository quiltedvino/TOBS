using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using RedditSharp.Things;
using RedditSharp;
using System.Net;
using System.ComponentModel;
using System.Threading;

namespace OleSwitcheroo
{
    public partial class frmMain : Form
    {
        TimeSpan timeElapsed;
        TimeSpan timeRemaining;
        string download;
        string title;
        List<string> subs;
        string workingSub;
        bool firstTime;

        public frmMain()
        {
            InitializeComponent();
            ResetTimer();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateConsole("Exiting application...");
            Application.Exit();
        }


        public void UpdateConsole(string message)
        {
            txtConsole.BeginInvoke(
                new Action(() =>
                {
                    txtConsole.Text += DateTime.Now.ToString() + " - " + message + Environment.NewLine;
                    txtConsole.ScrollToCaret();
                }
                ));

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                btnGo.PerformClick();
            }
            Form settings = new frmSettings(this);
            settings.ShowDialog();
        }


        private void ImportStatusForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ntfTrayIcon.Visible = true;
                ntfTrayIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }


        private void ntfTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            ntfTrayIcon.Visible = false;

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ntfTrayIcon.Visible = true;
                ntfTrayIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SaveDirectory == "none")
            {
                UpdateConsole("You need to select a default image save directory. Go to File...Settings to do this.");
            }
            else if (Properties.Settings.Default.Subreddits == "")
            {
                UpdateConsole("You need to select some subreddits to check. Go to File...Settings to do this. Don't worry, suggestions are provided!");
            }
            else
            {
                if (timer1.Enabled)
                {
                    UpdateConsole("Paused countdown until next background.");
                    btnGo.Text = "Resume";
                    tslRunning.Text = "Paused...";
                    timer1.Stop();
                }
                else
                {
                    UpdateConsole("Started countdown until next background.");
                    btnGo.Text = "Pause";
                    tslRunning.Text = "Running...";
                    timer1.Start();
                }
            }
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.DeselectAll();
        }

        private void RunReddit()
        {
            try
            {

                //List of subs to try pulling images from
                subs = new List<string>();
                foreach (string sub in Properties.Settings.Default.Subreddits.Split(','))
                {
                    subs.Add(sub);
                }
                RecursiveReddit();
                firstTime = false;
            }

            catch (WebException error)
            {
                UpdateConsole(String.Format("You found an error, congratulations! \n This is a WebException error. It likely means that you have a malformed or otherwise mistyped subreddit in your list of subreddits. Look into that; maybe you put in an extra comma somewhere? Here's some more information, if you're the nerdy type. \n\n\n {0}", error));
            }
            catch (Exception error)
            {
                UpdateConsole(String.Format("You found an error, congratulations! \n I have no idea what you did to get this one. Here's some nerd stuff that might give you a clue. \n\n\n {0}", error));
            }
        }

        private void Threaddit()
        {
            download = "";
            try
            {
                //Log in to reddit
                Reddit reddit = new Reddit();
                //Pick a random sub, then remove it from the list so we don't keep looking there if nothing is found
                Random rng = new Random();
                int i = rng.Next(0, subs.Count - 1);
                workingSub = subs[i];
                Subreddit subreddit = reddit.GetSubreddit("/r/" + workingSub);
                if (subs.Count > 0)
                    subs.RemoveAt(i);

                //Take the sub's top 10 hot posts
                foreach (var post in subreddit.Hot.Take(10))
                {
                    if (LegitPost(post.Url.ToString()))
                    {
                        Properties.Settings.Default.CollectedUrls.Add(post.Url.ToString());
                        Properties.Settings.Default.Save();
                        title = post.Title;
                        download = urlModder(post.Url.ToString());
                        break;
                    }
                }
            }
            catch (Exception error)
            {
                UpdateConsole(String.Format("You found an error, congratulations! \n This happened when the Reddit API was being interacted with. Read on for more info... \n\n\n {0}", error));
            }
            if (download != "")
            {
                //Save the image to computer
                string saveName = Properties.Settings.Default.SaveDirectory;
                saveName = saveName + "\\" + workingSub + "\\";
                if (!Directory.Exists(saveName))
                    Directory.CreateDirectory(saveName);
                int fCount = Directory.GetFiles(saveName, "*", SearchOption.TopDirectoryOnly).Length;
                string suffix = "." + download.Substring(download.Length - 3, 3);
                saveName = saveName + "Image" + fCount.ToString() + suffix;
                WebClient web = new WebClient();
                using (web)
                {
                    try
                    {
                        web.DownloadFile(download, saveName);
                    }
                    catch (Exception except)
                    {
                        UpdateConsole("Error! Couldn't download file! More info... \n" + except);
                    }
                }


                //Now that we have the image saved, we can check the dimensions and make sure it fits.
                try
                {
                    int height = 0;
                    int width = 0;
                    using (Image dimensionschecker = Image.FromFile(saveName))
                    {
                        height = dimensionschecker.Height;
                        width = dimensionschecker.Width;
                    }

                    if ((height >= Properties.Settings.Default.MinHeight) &&
                        (width >= Properties.Settings.Default.MinWidth) &&
                        (height <= Properties.Settings.Default.MaxHeight) &&
                        (width <= Properties.Settings.Default.MaxWidth))
                    {
                        UpdateConsole(String.Format("Found a cool image from {0} - {1}", workingSub, title));
                        bool tooBig = ((height > Screen.PrimaryScreen.Bounds.Height * 1.1) ||
                            (width > Screen.PrimaryScreen.Bounds.Width * 1.1));
                        MakeBackground(saveName, tooBig);
                    }
                    else
                    {
                        //Image is wrong size. Delete it, then try again.
                        try { File.Delete(saveName); }
                        catch (IOException)
                        {
                            UpdateConsole("Tried to delete a file, but couldn't. This shouldn't be a problem, unless you see this message a lot.");
                        }
                        //UpdateConsole("Found an image, but it was not within your dimensions. If you're seeing this message a lot, you might try lowering your minimum height/width dimensions.");
                        firstTime = false;
                        RunReddit();
                    }

                }
                catch (Exception except)
                {
                    UpdateConsole("We couldn't make an image out of whatever we downloaded; must not have grabbed a real url. Try again..." + except);
                    try { File.Delete(saveName); }
                    catch (IOException)
                    {
                        UpdateConsole("Tried to delete a file (" + saveName + "), but couldn't. This shouldn't be a problem, unless you see this message a lot.");
                    }
                    firstTime = false;
                    RunReddit();
                }


            }
            else if (subs.Count >= 1)
            {
                UpdateConsole("Couldn't find any valid images in " + workingSub + ". Trying again.");
                firstTime = false;
                RecursiveReddit();
            }
            else
            {
                UpdateConsole("We've tried every sub on the list, and couldn't find anything that meets our requirements.");
                firstTime = true;
            }


        }


        private void RecursiveReddit()
        {
            //Do reddit stuff on its own thread so that it doesn't bog down everything
            Thread t = new Thread(new ThreadStart(Threaddit));
            if (firstTime)
                UpdateConsole("Working...");
            t.Start();
        }

        private void MakeBackground(string saveName, bool imageTooBig)
        {
            Wallpaper.Style style;
            switch (Properties.Settings.Default.WallpaperStyle)
            {
                case 0:
                    style = Wallpaper.Style.Centered;
                    break;
                case 1:
                    style = Wallpaper.Style.Stretched;
                    break;
                case 2:
                    style = Wallpaper.Style.Tiled;
                    break;
                default:
                    if (imageTooBig)
                        style = Wallpaper.Style.Stretched;
                    else
                        style = Wallpaper.Style.Centered;
                    break;
            }
            Wallpaper.Set(new Uri(saveName), style);
            UpdateConsole("Background updated!");
        }

        /// <summary>
        /// Checks the suffix of a url. We have to make sure it's a direct link to an image
        ///  file. If it's not, we'll tack on a .jpg and return that instead.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string urlModder(string url)
        {
            if ((url.EndsWith(".jpg")) || (url.EndsWith(".jpeg")) || (url.EndsWith(".png")))
            {
                return url;
            }
            return url + ".jpg";
        }

        private bool LegitPost(string url)
        {
            if (url.Contains("imgur") &&
                !url.Contains("gallery") &&
                !url.Contains("/a/") &&
                !url.Contains(',') &&
                !url.Contains(".gif") &&
                !Properties.Settings.Default.CollectedUrls.Contains(url))
                return true;
            return false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed += TimeSpan.FromSeconds(1);
            tslTimeElapsed.Text = String.Format("{0} remaining until next update", timeRemaining - timeElapsed);
            if (timeElapsed > timeRemaining - TimeSpan.FromSeconds(1))
            {
                ResetTimer();
                firstTime = true;
                RunReddit();
                UpdateConsole(String.Format("Sleeping for {0} minutes", timeRemaining));

            }
        }

        public void ResetTimer()
        {
            timeElapsed = TimeSpan.FromMinutes(0);
            timeRemaining = TimeSpan.FromMinutes(Properties.Settings.Default.UpdateRate);
            tslTimeElapsed.Text = String.Format("{0} remaining until next update", timeRemaining - timeElapsed);
        }

        private void btnImmediateBackground_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SaveDirectory == "none")
            {
                UpdateConsole("You need to select a default image save directory. Go to File...Settings to do this.");
            }
            else if (Properties.Settings.Default.Subreddits == "")
            {
                UpdateConsole("You need to select some subreddits to check. Go to File...Settings to do this. Don't worry, suggestions are provided!");
            }
            else
            {
                btnImmediateBackground.Enabled = false;
                firstTime = true;
                RunReddit();
                btnImmediateBackground.Enabled = true;
            }
        }

        private void frmMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit the application? You can hide it in the system tray by minimizing it.", "Really exit?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
    }


}
