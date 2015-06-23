namespace OleSwitcheroo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.ntfTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnGo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslTimeElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslRunning = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnImmediateBackground = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(13, 28);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(381, 189);
            this.txtConsole.TabIndex = 1;
            this.txtConsole.TabStop = false;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // ntfTrayIcon
            // 
            this.ntfTrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfTrayIcon.BalloonTipText = "Minimized to System Tray";
            this.ntfTrayIcon.BalloonTipTitle = "The Ole Background Switcheroo";
            this.ntfTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfTrayIcon.Icon")));
            this.ntfTrayIcon.Text = "The Ole Background Switcheroo - Running";
            this.ntfTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfTrayIcon_MouseDoubleClick);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(319, 224);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Start";
            this.toolTip1.SetToolTip(this.btnGo, "Start/stop the timer for automatic background acquisition");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTimeElapsed,
            this.tslRunning});
            this.statusStrip1.Location = new System.Drawing.Point(0, 256);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(407, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslTimeElapsed
            // 
            this.tslTimeElapsed.Name = "tslTimeElapsed";
            this.tslTimeElapsed.Size = new System.Drawing.Size(0, 17);
            this.tslTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tslRunning
            // 
            this.tslRunning.Name = "tslRunning";
            this.tslRunning.Size = new System.Drawing.Size(392, 17);
            this.tslRunning.Spring = true;
            this.tslRunning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnImmediateBackground
            // 
            this.btnImmediateBackground.Location = new System.Drawing.Point(217, 224);
            this.btnImmediateBackground.Name = "btnImmediateBackground";
            this.btnImmediateBackground.Size = new System.Drawing.Size(96, 23);
            this.btnImmediateBackground.TabIndex = 4;
            this.btnImmediateBackground.Text = "Feeling Lucky!";
            this.toolTip1.SetToolTip(this.btnImmediateBackground, "Immediately grab a new background, bypassing the timer");
            this.btnImmediateBackground.UseVisualStyleBackColor = true;
            this.btnImmediateBackground.Click += new System.EventHandler(this.btnImmediateBackground_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 278);
            this.Controls.Add(this.btnImmediateBackground);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "The Ole Background Switcheroo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing_1);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.NotifyIcon ntfTrayIcon;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslTimeElapsed;
        private System.Windows.Forms.ToolStripStatusLabel tslRunning;
        private System.Windows.Forms.Button btnImmediateBackground;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

