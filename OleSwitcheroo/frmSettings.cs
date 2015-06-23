using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OleSwitcheroo
{
    public partial class frmSettings : Form
    {
        frmMain theMain;

        public frmSettings(frmMain theMain)
        {
            InitializeComponent();
            //Needs a reference to the main form so we can update console.
            this.theMain = theMain;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveBrowser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSaveDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            UpdateForm();
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            Properties.Settings.Default.SaveDirectory = txtSaveDirectory.Text;
            Properties.Settings.Default.Subreddits = txtSubreddits.Text;
            Properties.Settings.Default.UpdateRate = Convert.ToInt32(numFrequency.Value);
            Properties.Settings.Default.MinHeight = Convert.ToInt32(numHeight.Value);
            Properties.Settings.Default.MinWidth = Convert.ToInt32(numWidth.Value);
            Properties.Settings.Default.MaxHeight = Convert.ToInt32(numMaxHeight.Value);
            Properties.Settings.Default.MaxWidth = Convert.ToInt32(numMaxWidth.Value);
            if (rbnCentered.Checked)
                Properties.Settings.Default.WallpaperStyle = 0;
            else if (rbnStretched.Checked)
                Properties.Settings.Default.WallpaperStyle = 1;
            else if (rbnTiled.Checked)
                Properties.Settings.Default.WallpaperStyle = 2;
            else
                Properties.Settings.Default.WallpaperStyle = 3;


            Properties.Settings.Default.Save();
            theMain.UpdateConsole("Saved settings - timer reset.");
            theMain.ResetTimer();
            this.Close();
        }

        private void txtSaveDirectory_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtSubreddits_TextChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void numFrequency_ValueChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void txtSubreddits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '_'))
            {
                e.Handled = true;
            }
        }

        private void btnSuggestions_Click(object sender, EventArgs e)
        {

            Form suggestions = new frmSuggestions(txtSubreddits);
            suggestions.ShowDialog();
        }

        private void button1(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to reset settings to default values?",
                                        "Confirm Settings Reset",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Properties.Settings.Default.SaveDirectory = "none";
                Properties.Settings.Default.Subreddits = "";
                Properties.Settings.Default.UpdateRate = 30;
                Properties.Settings.Default.MinHeight = 600;
                Properties.Settings.Default.MinWidth = 800;
                Properties.Settings.Default.MinHeight = 9999;
                Properties.Settings.Default.MinWidth = 9999;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.WallpaperStyle = 3;
                UpdateForm();
                theMain.UpdateConsole("Settings reset to default values.");

            }
        }

        private void UpdateForm()
        {
            txtSaveDirectory.Text = Properties.Settings.Default.SaveDirectory;
            txtSubreddits.Text = Properties.Settings.Default.Subreddits;
            numFrequency.Value = Properties.Settings.Default.UpdateRate;
            numHeight.Value = Properties.Settings.Default.MinHeight;
            numWidth.Value = Properties.Settings.Default.MinWidth;
            numMaxHeight.Value = Properties.Settings.Default.MaxHeight;
            numMaxWidth.Value = Properties.Settings.Default.MaxWidth;
            switch (Properties.Settings.Default.WallpaperStyle)
            {
                case 0:
                    rbnCentered.PerformClick();
                    break;
                case 1:
                    rbnStretched.PerformClick();
                    break;
                case 2:
                    rbnTiled.PerformClick();
                    break;
                default:
                    rbnBestFit.PerformClick();
                    break;
            }
        }

        private void btnFlush_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete your database of already acquired URLs? This will not delete any actual files. It will only allow you to re-download previously acquired images.",
                                        "Confirm cache flush",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Properties.Settings.Default.CollectedUrls.Clear();
                Properties.Settings.Default.Save();
                MessageBox.Show("Cache flushed!","Success");
                theMain.UpdateConsole("Cache flushed.");
            }
        }

        private void rbnCentered_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

        }

        private void rbnStretched_CheckedChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void rbnTiled_CheckedChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void rbnBestFit_CheckedChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

        }
    }
}
