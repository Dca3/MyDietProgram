﻿namespace MyDietProgram.UI
{
    partial class MainForm
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
            this.cbMeals = new MaterialSkin.Controls.MaterialComboBox();
            this.cbCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.btnNewFood = new MaterialSkin.Controls.MaterialButton();
            this.cbFoods = new MaterialSkin.Controls.MaterialComboBox();
            this.txtAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAddMeal = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.flpMeals = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.lblFoodDetails = new MaterialSkin.Controls.MaterialLabel();
            this.swhTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.lblUserCalculatedCalorie = new System.Windows.Forms.Label();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFoodStats = new System.Windows.Forms.Label();
            this.lblOverview = new System.Windows.Forms.Label();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMeals
            // 
            this.cbMeals.AutoResize = false;
            this.cbMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMeals.Depth = 0;
            this.cbMeals.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMeals.DropDownHeight = 174;
            this.cbMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeals.DropDownWidth = 121;
            this.cbMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMeals.FormattingEnabled = true;
            this.cbMeals.IntegralHeight = false;
            this.cbMeals.ItemHeight = 43;
            this.cbMeals.Items.AddRange(new object[] {
            "Kahvaltı",
            "Öğle yemeği",
            "Akşam yemeği",
            "Atıştırmalık"});
            this.cbMeals.Location = new System.Drawing.Point(348, 158);
            this.cbMeals.Margin = new System.Windows.Forms.Padding(4);
            this.cbMeals.MaxDropDownItems = 4;
            this.cbMeals.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMeals.Name = "cbMeals";
            this.cbMeals.Size = new System.Drawing.Size(362, 49);
            this.cbMeals.StartIndex = 0;
            this.cbMeals.TabIndex = 8;
            this.cbMeals.UseAccent = false;
            // 
            // cbCategories
            // 
            this.cbCategories.AutoResize = false;
            this.cbCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCategories.Depth = 0;
            this.cbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCategories.DropDownHeight = 174;
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.DropDownWidth = 121;
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.IntegralHeight = false;
            this.cbCategories.ItemHeight = 43;
            this.cbCategories.Location = new System.Drawing.Point(348, 221);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.MaxDropDownItems = 4;
            this.cbCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(362, 49);
            this.cbCategories.StartIndex = 0;
            this.cbCategories.TabIndex = 8;
            this.cbCategories.UseAccent = false;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // btnNewFood
            // 
            this.btnNewFood.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnNewFood.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewFood.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewFood.Depth = 0;
            this.btnNewFood.HighEmphasis = true;
            this.btnNewFood.Icon = null;
            this.btnNewFood.Location = new System.Drawing.Point(718, 291);
            this.btnNewFood.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnNewFood.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewFood.Name = "btnNewFood";
            this.btnNewFood.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNewFood.Size = new System.Drawing.Size(64, 36);
            this.btnNewFood.TabIndex = 7;
            this.btnNewFood.Text = "+";
            this.btnNewFood.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewFood.UseAccentColor = false;
            this.btnNewFood.UseVisualStyleBackColor = true;
            this.btnNewFood.Click += new System.EventHandler(this.btnNewFood_Click);
            // 
            // cbFoods
            // 
            this.cbFoods.AutoResize = false;
            this.cbFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFoods.Depth = 0;
            this.cbFoods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFoods.DropDownHeight = 174;
            this.cbFoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoods.DropDownWidth = 121;
            this.cbFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFoods.FormattingEnabled = true;
            this.cbFoods.IntegralHeight = false;
            this.cbFoods.ItemHeight = 43;
            this.cbFoods.Location = new System.Drawing.Point(348, 286);
            this.cbFoods.Margin = new System.Windows.Forms.Padding(4);
            this.cbFoods.MaxDropDownItems = 4;
            this.cbFoods.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFoods.Name = "cbFoods";
            this.cbFoods.Size = new System.Drawing.Size(362, 49);
            this.cbFoods.StartIndex = 0;
            this.cbFoods.TabIndex = 8;
            this.cbFoods.UseAccent = false;
            this.cbFoods.SelectedIndexChanged += new System.EventHandler(this.cbFoods_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Depth = 0;
            this.txtAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmount.LeadingIcon = null;
            this.txtAmount.Location = new System.Drawing.Point(349, 349);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.MaxLength = 8;
            this.txtAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(142, 50);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.Text = "1";
            this.txtAmount.TrailingIcon = null;
            this.txtAmount.UseAccent = false;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAddMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMeal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMeal.Depth = 0;
            this.btnAddMeal.HighEmphasis = true;
            this.btnAddMeal.Icon = null;
            this.btnAddMeal.Location = new System.Drawing.Point(349, 424);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnAddMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddMeal.Size = new System.Drawing.Size(64, 36);
            this.btnAddMeal.TabIndex = 7;
            this.btnAddMeal.Text = "Ekle";
            this.btnAddMeal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMeal.UseAccentColor = false;
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(275, 173);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Öğün";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(252, 236);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(60, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Kategori";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(257, 301);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Yiyecek";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(268, 367);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Miktar";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(349, 109);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(362, 33);
            this.dtpDate.TabIndex = 12;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(275, 122);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Tarih";
            // 
            // flpMeals
            // 
            this.flpMeals.AutoScroll = true;
            this.flpMeals.Location = new System.Drawing.Point(879, 118);
            this.flpMeals.Name = "flpMeals";
            this.flpMeals.Size = new System.Drawing.Size(554, 416);
            this.flpMeals.TabIndex = 13;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(1349, 86);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(84, 29);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Öğünler";
            // 
            // lblFoodDetails
            // 
            this.lblFoodDetails.AutoSize = true;
            this.lblFoodDetails.Depth = 0;
            this.lblFoodDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoodDetails.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFoodDetails.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblFoodDetails.Location = new System.Drawing.Point(516, 367);
            this.lblFoodDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFoodDetails.Name = "lblFoodDetails";
            this.lblFoodDetails.Size = new System.Drawing.Size(53, 24);
            this.lblFoodDetails.TabIndex = 9;
            this.lblFoodDetails.Text = "0 kcal";
            // 
            // swhTheme
            // 
            this.swhTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.swhTheme.AutoSize = true;
            this.swhTheme.Depth = 0;
            this.swhTheme.Location = new System.Drawing.Point(0, 413);
            this.swhTheme.Margin = new System.Windows.Forms.Padding(0);
            this.swhTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swhTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.swhTheme.Name = "swhTheme";
            this.swhTheme.Ripple = true;
            this.swhTheme.Size = new System.Drawing.Size(139, 37);
            this.swhTheme.TabIndex = 18;
            this.swhTheme.Text = "Koyu Tema";
            this.swhTheme.UseVisualStyleBackColor = true;
            this.swhTheme.CheckedChanged += new System.EventHandler(this.swhTheme_CheckedChanged);
            // 
            // lblUserCalculatedCalorie
            // 
            this.lblUserCalculatedCalorie.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCalculatedCalorie.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserCalculatedCalorie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserCalculatedCalorie.Location = new System.Drawing.Point(1108, 30);
            this.lblUserCalculatedCalorie.Name = "lblUserCalculatedCalorie";
            this.lblUserCalculatedCalorie.Size = new System.Drawing.Size(327, 23);
            this.lblUserCalculatedCalorie.TabIndex = 21;
            this.lblUserCalculatedCalorie.Text = "Günlük hedef: 1000 kcal";
            this.lblUserCalculatedCalorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(0, 456);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLogout.Size = new System.Drawing.Size(204, 36);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "ÇIKIŞ YAP";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(830, 67);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 526);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.lblFoodStats);
            this.panel1.Controls.Add(this.lblOverview);
            this.panel1.Controls.Add(this.lblDailyReport);
            this.panel1.Controls.Add(this.lblProfile);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.swhTheme);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 492);
            this.panel1.TabIndex = 23;
            // 
            // lblFoodStats
            // 
            this.lblFoodStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoodStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFoodStats.Location = new System.Drawing.Point(0, 129);
            this.lblFoodStats.Name = "lblFoodStats";
            this.lblFoodStats.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblFoodStats.Size = new System.Drawing.Size(204, 43);
            this.lblFoodStats.TabIndex = 28;
            this.lblFoodStats.Text = "Yemek istatistikleri";
            this.lblFoodStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFoodStats.Click += new System.EventHandler(this.btnFoodStats_Click);
            this.lblFoodStats.MouseEnter += new System.EventHandler(this.lblMouseEnter);
            this.lblFoodStats.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            // 
            // lblOverview
            // 
            this.lblOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOverview.Location = new System.Drawing.Point(0, 86);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblOverview.Size = new System.Drawing.Size(204, 43);
            this.lblOverview.TabIndex = 27;
            this.lblOverview.Text = "Karşılaştırma";
            this.lblOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOverview.Click += new System.EventHandler(this.btnOverview_Click);
            this.lblOverview.MouseEnter += new System.EventHandler(this.lblMouseEnter);
            this.lblOverview.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDailyReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDailyReport.Location = new System.Drawing.Point(0, 43);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblDailyReport.Size = new System.Drawing.Size(204, 43);
            this.lblDailyReport.TabIndex = 26;
            this.lblDailyReport.Text = "Gün raporu";
            this.lblDailyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDailyReport.Click += new System.EventHandler(this.btnDaily_Click);
            this.lblDailyReport.MouseEnter += new System.EventHandler(this.lblMouseEnter);
            this.lblDailyReport.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            // 
            // lblProfile
            // 
            this.lblProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.Location = new System.Drawing.Point(0, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblProfile.Size = new System.Drawing.Size(204, 43);
            this.lblProfile.TabIndex = 25;
            this.lblProfile.Text = "Profil";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            this.lblProfile.MouseEnter += new System.EventHandler(this.lblMouseEnter);
            this.lblProfile.MouseLeave += new System.EventHandler(this.lblMouseLeave);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLogout;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserCalculatedCalorie);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.flpMeals);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblFoodDetails);
            this.Controls.Add(this.cbFoods);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbMeals);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.btnNewFood);
            this.DrawerAutoHide = false;
            this.DrawerIsOpen = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cbMeals;
        private MaterialSkin.Controls.MaterialComboBox cbCategories;
        private MaterialSkin.Controls.MaterialButton btnNewFood;
        private MaterialSkin.Controls.MaterialComboBox cbFoods;
        private MaterialSkin.Controls.MaterialTextBox txtAmount;
        private MaterialSkin.Controls.MaterialButton btnAddMeal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DateTimePicker dtpDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlowLayoutPanel flpMeals;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel lblFoodDetails;
        private MaterialSkin.Controls.MaterialSwitch swhTheme;
        private Label lblUserCalculatedCalorie;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Panel panel1;
        private Label lblFoodStats;
        private Label lblOverview;
        private Label lblDailyReport;
        private Label lblProfile;
    }
}