namespace OleSwitcheroo
{
    partial class frmSuggestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuggestions));
            this.cbxNature = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxSynthetic = new System.Windows.Forms.CheckedListBox();
            this.cbxOrganic = new System.Windows.Forms.CheckedListBox();
            this.cbxAesthetic = new System.Windows.Forms.CheckedListBox();
            this.cbxScholastic = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkCorgi = new System.Windows.Forms.CheckBox();
            this.chkImaginary = new System.Windows.Forms.CheckBox();
            this.chkThemes = new System.Windows.Forms.CheckBox();
            this.chkNSFW = new System.Windows.Forms.CheckBox();
            this.chkGeneral = new System.Windows.Forms.CheckBox();
            this.cbxCorgi = new System.Windows.Forms.CheckedListBox();
            this.cbxImagination = new System.Windows.Forms.CheckedListBox();
            this.cbxTheme = new System.Windows.Forms.CheckedListBox();
            this.cbxNSFW = new System.Windows.Forms.CheckedListBox();
            this.cbxGeneral = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkAesthetic = new System.Windows.Forms.CheckBox();
            this.chkOrganic = new System.Windows.Forms.CheckBox();
            this.chkScholastic = new System.Windows.Forms.CheckBox();
            this.chkSynthetic = new System.Windows.Forms.CheckBox();
            this.chkNature = new System.Windows.Forms.CheckBox();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxNature
            // 
            this.cbxNature.CheckOnClick = true;
            this.cbxNature.FormattingEnabled = true;
            this.cbxNature.Items.AddRange(new object[] {
            "EarthPorn",
            "BotanicalPorn",
            "WaterPorn",
            "SeaPorn",
            "SkyPorn",
            "FirePorn",
            "DesertPorn",
            "WinterPorn",
            "AutumnPorn",
            "WeatherPorn",
            "GeologyPorn",
            "SpacePorn",
            "BeachPorn",
            "MushroomPorn",
            "SpringPorn",
            "SummerPorn",
            "LavaPorn",
            "LakePorn"});
            this.cbxNature.Location = new System.Drawing.Point(6, 28);
            this.cbxNature.MultiColumn = true;
            this.cbxNature.Name = "cbxNature";
            this.cbxNature.Size = new System.Drawing.Size(402, 94);
            this.cbxNature.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(616, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save - will overwrite current subreddits!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(484, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxSynthetic
            // 
            this.cbxSynthetic.CheckOnClick = true;
            this.cbxSynthetic.FormattingEnabled = true;
            this.cbxSynthetic.Items.AddRange(new object[] {
            "CityPorn",
            "VillagePorn",
            "RuralPorn",
            "ArchitecturePorn",
            "HousePorn",
            "CabinPorn",
            "ChurchPorn",
            "AbandonedPorn",
            "CemeteryPorn",
            "InfrastructurePorn",
            "MachinePorn",
            "CarPorn",
            "F1Porn",
            "MotorcyclePorn",
            "MilitaryPorn",
            "GunPorn",
            "KnifePorn",
            "BoatPorn",
            "RidesPorn",
            "DestructionPorn",
            "ThingsCutInHalfPorn",
            "StarshipPorn",
            "ToolPorn",
            "TechnologyPorn",
            "BridgePorn",
            "PolicePorn",
            "SteamPorn",
            "RetailPorn",
            "SpaceFlightPorn"});
            this.cbxSynthetic.Location = new System.Drawing.Point(6, 151);
            this.cbxSynthetic.MultiColumn = true;
            this.cbxSynthetic.Name = "cbxSynthetic";
            this.cbxSynthetic.Size = new System.Drawing.Size(402, 154);
            this.cbxSynthetic.TabIndex = 8;
            // 
            // cbxOrganic
            // 
            this.cbxOrganic.CheckOnClick = true;
            this.cbxOrganic.FormattingEnabled = true;
            this.cbxOrganic.Items.AddRange(new object[] {
            "AnimalPorn",
            "HumanPorn",
            "EarthlingPorn",
            "AdrenalinePorn",
            "ClimbingPorn",
            "SportsPorn",
            "AgriculturePorn",
            "TeaPorn",
            "BonsaiPorn",
            "FoodPorn",
            "CulinaryPorn",
            "DessertPorn"});
            this.cbxOrganic.Location = new System.Drawing.Point(414, 28);
            this.cbxOrganic.MultiColumn = true;
            this.cbxOrganic.Name = "cbxOrganic";
            this.cbxOrganic.Size = new System.Drawing.Size(297, 94);
            this.cbxOrganic.TabIndex = 10;
            // 
            // cbxAesthetic
            // 
            this.cbxAesthetic.CheckOnClick = true;
            this.cbxAesthetic.FormattingEnabled = true;
            this.cbxAesthetic.Items.AddRange(new object[] {
            "DesignPorn",
            "RoomPorn",
            "AlbumArtPorn",
            "MetalPorn",
            "MoviePosterPorn",
            "TelevisionPosterPorn",
            "ComicBookPorn",
            "StreetArtPorn",
            "AdPorn",
            "ArtPorn",
            "FractalPorn",
            "InstrumentPorn",
            "ExposurePorn",
            "MacroPorn",
            "MicroPorn",
            "GeekPorn",
            "MTGPorn",
            "GamerPorn",
            "PowerWashingPorn",
            "AerialPorn",
            "OrganizationPorn",
            "FashionPorn",
            "AVPorn",
            "ApocalypsePorn",
            "InfraredPorn",
            "ViewPorn",
            "HellscapePorn ",
            "SculpturePorn"});
            this.cbxAesthetic.Location = new System.Drawing.Point(414, 151);
            this.cbxAesthetic.MultiColumn = true;
            this.cbxAesthetic.Name = "cbxAesthetic";
            this.cbxAesthetic.Size = new System.Drawing.Size(297, 244);
            this.cbxAesthetic.TabIndex = 12;
            // 
            // cbxScholastic
            // 
            this.cbxScholastic.CheckOnClick = true;
            this.cbxScholastic.FormattingEnabled = true;
            this.cbxScholastic.Items.AddRange(new object[] {
            "HistoryPorn",
            "UniformPorn",
            "MapPorn",
            "BookPorn",
            "NewsPorn",
            "QuotesPorn",
            "FuturePorn",
            "FossilPorn",
            "MegalithPorn",
            "ArtefactPorn"});
            this.cbxScholastic.Location = new System.Drawing.Point(6, 334);
            this.cbxScholastic.MultiColumn = true;
            this.cbxScholastic.Name = "cbxScholastic";
            this.cbxScholastic.Size = new System.Drawing.Size(402, 64);
            this.cbxScholastic.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 444);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkCorgi);
            this.tabPage2.Controls.Add(this.chkImaginary);
            this.tabPage2.Controls.Add(this.chkThemes);
            this.tabPage2.Controls.Add(this.chkNSFW);
            this.tabPage2.Controls.Add(this.chkGeneral);
            this.tabPage2.Controls.Add(this.cbxCorgi);
            this.tabPage2.Controls.Add(this.cbxImagination);
            this.tabPage2.Controls.Add(this.cbxTheme);
            this.tabPage2.Controls.Add(this.cbxNSFW);
            this.tabPage2.Controls.Add(this.cbxGeneral);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Background Subreddits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkCorgi
            // 
            this.chkCorgi.AutoSize = true;
            this.chkCorgi.Location = new System.Drawing.Point(468, 6);
            this.chkCorgi.Name = "chkCorgi";
            this.chkCorgi.Size = new System.Drawing.Size(50, 17);
            this.chkCorgi.TabIndex = 18;
            this.chkCorgi.Text = "Corgi";
            this.chkCorgi.UseVisualStyleBackColor = true;
            this.chkCorgi.CheckedChanged += new System.EventHandler(this.chkCorgi_CheckedChanged);
            // 
            // chkImaginary
            // 
            this.chkImaginary.AutoSize = true;
            this.chkImaginary.Location = new System.Drawing.Point(6, 309);
            this.chkImaginary.Name = "chkImaginary";
            this.chkImaginary.Size = new System.Drawing.Size(71, 17);
            this.chkImaginary.TabIndex = 17;
            this.chkImaginary.Text = "Imaginary";
            this.chkImaginary.UseVisualStyleBackColor = true;
            this.chkImaginary.CheckedChanged += new System.EventHandler(this.chkImaginary_CheckedChanged);
            // 
            // chkThemes
            // 
            this.chkThemes.AutoSize = true;
            this.chkThemes.Location = new System.Drawing.Point(6, 216);
            this.chkThemes.Name = "chkThemes";
            this.chkThemes.Size = new System.Drawing.Size(64, 17);
            this.chkThemes.TabIndex = 16;
            this.chkThemes.Text = "Themes";
            this.chkThemes.UseVisualStyleBackColor = true;
            this.chkThemes.CheckedChanged += new System.EventHandler(this.chkThemes_CheckedChanged);
            // 
            // chkNSFW
            // 
            this.chkNSFW.AutoSize = true;
            this.chkNSFW.Location = new System.Drawing.Point(6, 123);
            this.chkNSFW.Name = "chkNSFW";
            this.chkNSFW.Size = new System.Drawing.Size(58, 17);
            this.chkNSFW.TabIndex = 15;
            this.chkNSFW.Text = "NSFW";
            this.chkNSFW.UseVisualStyleBackColor = true;
            this.chkNSFW.CheckedChanged += new System.EventHandler(this.chkNSFW_CheckedChanged);
            // 
            // chkGeneral
            // 
            this.chkGeneral.AutoSize = true;
            this.chkGeneral.Location = new System.Drawing.Point(6, 6);
            this.chkGeneral.Name = "chkGeneral";
            this.chkGeneral.Size = new System.Drawing.Size(119, 17);
            this.chkGeneral.TabIndex = 14;
            this.chkGeneral.Text = "General Wallpapers";
            this.chkGeneral.UseVisualStyleBackColor = true;
            this.chkGeneral.CheckedChanged += new System.EventHandler(this.chkGeneral_CheckedChanged);
            // 
            // cbxCorgi
            // 
            this.cbxCorgi.CheckOnClick = true;
            this.cbxCorgi.FormattingEnabled = true;
            this.cbxCorgi.Items.AddRange(new object[] {
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi",
            "corgi"});
            this.cbxCorgi.Location = new System.Drawing.Point(468, 23);
            this.cbxCorgi.MultiColumn = true;
            this.cbxCorgi.Name = "cbxCorgi";
            this.cbxCorgi.Size = new System.Drawing.Size(248, 379);
            this.cbxCorgi.TabIndex = 13;
            // 
            // cbxImagination
            // 
            this.cbxImagination.CheckOnClick = true;
            this.cbxImagination.FormattingEnabled = true;
            this.cbxImagination.Items.AddRange(new object[] {
            "ImaginaryBattlefields",
            "ImaginaryLandscapes",
            "ImaginaryMonsters",
            "ImaginaryCharacters",
            "ImaginaryTechnology"});
            this.cbxImagination.Location = new System.Drawing.Point(6, 333);
            this.cbxImagination.Name = "cbxImagination";
            this.cbxImagination.Size = new System.Drawing.Size(399, 79);
            this.cbxImagination.TabIndex = 11;
            // 
            // cbxTheme
            // 
            this.cbxTheme.CheckOnClick = true;
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Items.AddRange(new object[] {
            "musicwallpapers",
            "ComicWalls",
            "startrekwallpaper",
            "desktoplego",
            "videogamewallpapers",
            "animewallpaper",
            "aww"});
            this.cbxTheme.Location = new System.Drawing.Point(6, 239);
            this.cbxTheme.MultiColumn = true;
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(399, 64);
            this.cbxTheme.TabIndex = 9;
            this.cbxTheme.SelectedIndexChanged += new System.EventHandler(this.cbxCool_SelectedIndexChanged);
            // 
            // cbxNSFW
            // 
            this.cbxNSFW.CheckOnClick = true;
            this.cbxNSFW.FormattingEnabled = true;
            this.cbxNSFW.Items.AddRange(new object[] {
            "offensive_wallpapers",
            "gmbwallpapers",
            "NSFW_Wallpapers",
            "nocontext_wallpapers"});
            this.cbxNSFW.Location = new System.Drawing.Point(6, 146);
            this.cbxNSFW.MultiColumn = true;
            this.cbxNSFW.Name = "cbxNSFW";
            this.cbxNSFW.Size = new System.Drawing.Size(399, 64);
            this.cbxNSFW.TabIndex = 8;
            // 
            // cbxGeneral
            // 
            this.cbxGeneral.CheckOnClick = true;
            this.cbxGeneral.FormattingEnabled = true;
            this.cbxGeneral.Items.AddRange(new object[] {
            "wallpaper",
            "wallpapers",
            "WQHD_Wallpaper",
            "minimalwallpapers",
            "quotepaper",
            "backgroundart"});
            this.cbxGeneral.Location = new System.Drawing.Point(6, 23);
            this.cbxGeneral.Name = "cbxGeneral";
            this.cbxGeneral.Size = new System.Drawing.Size(403, 94);
            this.cbxGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkAesthetic);
            this.tabPage1.Controls.Add(this.chkOrganic);
            this.tabPage1.Controls.Add(this.chkScholastic);
            this.tabPage1.Controls.Add(this.chkSynthetic);
            this.tabPage1.Controls.Add(this.chkNature);
            this.tabPage1.Controls.Add(this.cbxScholastic);
            this.tabPage1.Controls.Add(this.cbxNature);
            this.tabPage1.Controls.Add(this.cbxSynthetic);
            this.tabPage1.Controls.Add(this.cbxAesthetic);
            this.tabPage1.Controls.Add(this.cbxOrganic);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SafeForWork Porn Network";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chkAesthetic
            // 
            this.chkAesthetic.AutoSize = true;
            this.chkAesthetic.Location = new System.Drawing.Point(414, 128);
            this.chkAesthetic.Name = "chkAesthetic";
            this.chkAesthetic.Size = new System.Drawing.Size(70, 17);
            this.chkAesthetic.TabIndex = 20;
            this.chkAesthetic.Text = "Aesthetic";
            this.chkAesthetic.UseVisualStyleBackColor = true;
            this.chkAesthetic.CheckedChanged += new System.EventHandler(this.chkAesthetic_CheckedChanged);
            // 
            // chkOrganic
            // 
            this.chkOrganic.AutoSize = true;
            this.chkOrganic.Location = new System.Drawing.Point(414, 6);
            this.chkOrganic.Name = "chkOrganic";
            this.chkOrganic.Size = new System.Drawing.Size(63, 17);
            this.chkOrganic.TabIndex = 21;
            this.chkOrganic.Text = "Organic";
            this.chkOrganic.UseVisualStyleBackColor = true;
            this.chkOrganic.CheckedChanged += new System.EventHandler(this.chkOrganic_CheckedChanged);
            // 
            // chkScholastic
            // 
            this.chkScholastic.AutoSize = true;
            this.chkScholastic.Location = new System.Drawing.Point(6, 311);
            this.chkScholastic.Name = "chkScholastic";
            this.chkScholastic.Size = new System.Drawing.Size(75, 17);
            this.chkScholastic.TabIndex = 21;
            this.chkScholastic.Text = "Scholastic";
            this.chkScholastic.UseVisualStyleBackColor = true;
            this.chkScholastic.CheckedChanged += new System.EventHandler(this.chkScholastic_CheckedChanged);
            // 
            // chkSynthetic
            // 
            this.chkSynthetic.AutoSize = true;
            this.chkSynthetic.Location = new System.Drawing.Point(6, 128);
            this.chkSynthetic.Name = "chkSynthetic";
            this.chkSynthetic.Size = new System.Drawing.Size(70, 17);
            this.chkSynthetic.TabIndex = 20;
            this.chkSynthetic.Text = "Synthetic";
            this.chkSynthetic.UseVisualStyleBackColor = true;
            this.chkSynthetic.CheckedChanged += new System.EventHandler(this.chkSynthetic_CheckedChanged);
            // 
            // chkNature
            // 
            this.chkNature.AutoSize = true;
            this.chkNature.Location = new System.Drawing.Point(6, 6);
            this.chkNature.Name = "chkNature";
            this.chkNature.Size = new System.Drawing.Size(58, 17);
            this.chkNature.TabIndex = 19;
            this.chkNature.Text = "Nature";
            this.chkNature.UseVisualStyleBackColor = true;
            this.chkNature.CheckedChanged += new System.EventHandler(this.chkNature_CheckedChanged);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(12, 475);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(92, 23);
            this.btnUncheckAll.TabIndex = 17;
            this.btnUncheckAll.Text = "Uncheck ALL";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(110, 475);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 18;
            this.btnCheckAll.Text = "Check ALL";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // frmSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 510);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuggestions";
            this.Text = "Suggested Subreddits";
            this.Load += new System.EventHandler(this.frmSuggestions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox cbxNature;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox cbxSynthetic;
        private System.Windows.Forms.CheckedListBox cbxOrganic;
        private System.Windows.Forms.CheckedListBox cbxAesthetic;
        private System.Windows.Forms.CheckedListBox cbxScholastic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox cbxGeneral;
        private System.Windows.Forms.CheckedListBox cbxTheme;
        private System.Windows.Forms.CheckedListBox cbxNSFW;
        private System.Windows.Forms.CheckedListBox cbxImagination;
        private System.Windows.Forms.CheckedListBox cbxCorgi;
        private System.Windows.Forms.CheckBox chkGeneral;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.CheckBox chkCorgi;
        private System.Windows.Forms.CheckBox chkImaginary;
        private System.Windows.Forms.CheckBox chkThemes;
        private System.Windows.Forms.CheckBox chkNSFW;
        private System.Windows.Forms.CheckBox chkAesthetic;
        private System.Windows.Forms.CheckBox chkOrganic;
        private System.Windows.Forms.CheckBox chkScholastic;
        private System.Windows.Forms.CheckBox chkSynthetic;
        private System.Windows.Forms.CheckBox chkNature;
    }
}