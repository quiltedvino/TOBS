namespace OleSwitcheroo
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSaveDirectory = new System.Windows.Forms.TextBox();
            this.btnSaveBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubreddits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numFrequency = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnSuggestions = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnFlush = new System.Windows.Forms.Button();
            this.rbnCentered = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnBestFit = new System.Windows.Forms.RadioButton();
            this.rbnStretched = new System.Windows.Forms.RadioButton();
            this.rbnTiled = new System.Windows.Forms.RadioButton();
            this.numMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.numMaxWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaveDirectory
            // 
            this.txtSaveDirectory.Location = new System.Drawing.Point(157, 15);
            this.txtSaveDirectory.Name = "txtSaveDirectory";
            this.txtSaveDirectory.ReadOnly = true;
            this.txtSaveDirectory.Size = new System.Drawing.Size(221, 20);
            this.txtSaveDirectory.TabIndex = 0;
            this.txtSaveDirectory.TabStop = false;
            this.txtSaveDirectory.TextChanged += new System.EventHandler(this.txtSaveDirectory_TextChanged);
            // 
            // btnSaveBrowser
            // 
            this.btnSaveBrowser.Location = new System.Drawing.Point(384, 14);
            this.btnSaveBrowser.Name = "btnSaveBrowser";
            this.btnSaveBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBrowser.TabIndex = 1;
            this.btnSaveBrowser.Text = "Browse";
            this.btnSaveBrowser.UseVisualStyleBackColor = true;
            this.btnSaveBrowser.Click += new System.EventHandler(this.btnSaveBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image save directory";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(384, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subreddits to check (separate with commas)";
            // 
            // txtSubreddits
            // 
            this.txtSubreddits.Location = new System.Drawing.Point(157, 49);
            this.txtSubreddits.Multiline = true;
            this.txtSubreddits.Name = "txtSubreddits";
            this.txtSubreddits.Size = new System.Drawing.Size(221, 67);
            this.txtSubreddits.TabIndex = 2;
            this.txtSubreddits.TextChanged += new System.EventHandler(this.txtSubreddits_TextChanged);
            this.txtSubreddits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubreddits_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Update frequency (minutes)";
            // 
            // numFrequency
            // 
            this.numFrequency.Location = new System.Drawing.Point(157, 125);
            this.numFrequency.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numFrequency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrequency.Name = "numFrequency";
            this.numFrequency.Size = new System.Drawing.Size(96, 20);
            this.numFrequency.TabIndex = 4;
            this.numFrequency.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numFrequency.ValueChanged += new System.EventHandler(this.numFrequency_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum image width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minimum image height";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(157, 162);
            this.numWidth.Maximum = new decimal(new int[] {
            3840,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(96, 20);
            this.numWidth.TabIndex = 5;
            this.numWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(157, 190);
            this.numHeight.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(96, 20);
            this.numHeight.TabIndex = 6;
            this.numHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // btnSuggestions
            // 
            this.btnSuggestions.Location = new System.Drawing.Point(384, 49);
            this.btnSuggestions.Name = "btnSuggestions";
            this.btnSuggestions.Size = new System.Drawing.Size(75, 23);
            this.btnSuggestions.TabIndex = 3;
            this.btnSuggestions.Text = "Suggestions";
            this.btnSuggestions.UseVisualStyleBackColor = true;
            this.btnSuggestions.Click += new System.EventHandler(this.btnSuggestions_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(15, 274);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(108, 23);
            this.btnDefault.TabIndex = 11;
            this.btnDefault.Text = "Default Settings";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.button1);
            // 
            // btnFlush
            // 
            this.btnFlush.Location = new System.Drawing.Point(130, 274);
            this.btnFlush.Name = "btnFlush";
            this.btnFlush.Size = new System.Drawing.Size(82, 23);
            this.btnFlush.TabIndex = 12;
            this.btnFlush.Text = "Flush Cache";
            this.btnFlush.UseVisualStyleBackColor = true;
            this.btnFlush.Click += new System.EventHandler(this.btnFlush_Click);
            // 
            // rbnCentered
            // 
            this.rbnCentered.AutoSize = true;
            this.rbnCentered.Checked = true;
            this.rbnCentered.Location = new System.Drawing.Point(6, 18);
            this.rbnCentered.Name = "rbnCentered";
            this.rbnCentered.Size = new System.Drawing.Size(68, 17);
            this.rbnCentered.TabIndex = 13;
            this.rbnCentered.TabStop = true;
            this.rbnCentered.Text = "Centered";
            this.rbnCentered.UseVisualStyleBackColor = true;
            this.rbnCentered.CheckedChanged += new System.EventHandler(this.rbnCentered_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnBestFit);
            this.groupBox1.Controls.Add(this.rbnStretched);
            this.groupBox1.Controls.Add(this.rbnTiled);
            this.groupBox1.Controls.Add(this.rbnCentered);
            this.groupBox1.Location = new System.Drawing.Point(15, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 45);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallpaper Style";
            // 
            // rbnBestFit
            // 
            this.rbnBestFit.AutoSize = true;
            this.rbnBestFit.Location = new System.Drawing.Point(211, 19);
            this.rbnBestFit.Name = "rbnBestFit";
            this.rbnBestFit.Size = new System.Drawing.Size(60, 17);
            this.rbnBestFit.TabIndex = 16;
            this.rbnBestFit.Text = "Best Fit";
            this.rbnBestFit.UseVisualStyleBackColor = true;
            this.rbnBestFit.CheckedChanged += new System.EventHandler(this.rbnBestFit_CheckedChanged);
            // 
            // rbnStretched
            // 
            this.rbnStretched.AutoSize = true;
            this.rbnStretched.Location = new System.Drawing.Point(80, 18);
            this.rbnStretched.Name = "rbnStretched";
            this.rbnStretched.Size = new System.Drawing.Size(71, 17);
            this.rbnStretched.TabIndex = 15;
            this.rbnStretched.Text = "Stretched";
            this.rbnStretched.UseVisualStyleBackColor = true;
            this.rbnStretched.CheckedChanged += new System.EventHandler(this.rbnStretched_CheckedChanged);
            // 
            // rbnTiled
            // 
            this.rbnTiled.AutoSize = true;
            this.rbnTiled.Location = new System.Drawing.Point(157, 18);
            this.rbnTiled.Name = "rbnTiled";
            this.rbnTiled.Size = new System.Drawing.Size(48, 17);
            this.rbnTiled.TabIndex = 14;
            this.rbnTiled.Text = "Tiled";
            this.rbnTiled.UseVisualStyleBackColor = true;
            this.rbnTiled.CheckedChanged += new System.EventHandler(this.rbnTiled_CheckedChanged);
            // 
            // numMaxHeight
            // 
            this.numMaxHeight.Location = new System.Drawing.Point(320, 190);
            this.numMaxHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMaxHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxHeight.Name = "numMaxHeight";
            this.numMaxHeight.Size = new System.Drawing.Size(120, 20);
            this.numMaxHeight.TabIndex = 16;
            this.numMaxHeight.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMaxHeight.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numMaxWidth
            // 
            this.numMaxWidth.Location = new System.Drawing.Point(320, 162);
            this.numMaxWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMaxWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxWidth.Name = "numMaxWidth";
            this.numMaxWidth.Size = new System.Drawing.Size(120, 20);
            this.numMaxWidth.TabIndex = 15;
            this.numMaxWidth.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMaxWidth.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Max height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max width";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 309);
            this.Controls.Add(this.numMaxHeight);
            this.Controls.Add(this.numMaxWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFlush);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnSuggestions);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubreddits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveBrowser);
            this.Controls.Add(this.txtSaveDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtSaveDirectory;
        private System.Windows.Forms.Button btnSaveBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubreddits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnSuggestions;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnFlush;
        private System.Windows.Forms.RadioButton rbnCentered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnStretched;
        private System.Windows.Forms.RadioButton rbnTiled;
        private System.Windows.Forms.RadioButton rbnBestFit;
        private System.Windows.Forms.NumericUpDown numMaxHeight;
        private System.Windows.Forms.NumericUpDown numMaxWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}