namespace MyDietProgram.UI
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
            this.btnDaily = new MaterialSkin.Controls.MaterialButton();
            this.btnOverview = new MaterialSkin.Controls.MaterialButton();
            this.btnFoodStats = new MaterialSkin.Controls.MaterialButton();
            this.lblFoodDetails = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.swhTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.lblUserCalculatedCalorie = new System.Windows.Forms.Label();
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
            this.cbMeals.Location = new System.Drawing.Point(155, 158);
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
            this.cbCategories.Location = new System.Drawing.Point(155, 221);
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
            this.btnNewFood.Location = new System.Drawing.Point(525, 291);
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
            this.cbFoods.Location = new System.Drawing.Point(155, 286);
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
            this.txtAmount.Location = new System.Drawing.Point(156, 349);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.MaxLength = 50;
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
            this.btnAddMeal.Location = new System.Drawing.Point(156, 424);
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
            this.materialLabel2.Location = new System.Drawing.Point(82, 173);
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
            this.materialLabel4.Location = new System.Drawing.Point(59, 236);
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
            this.materialLabel5.Location = new System.Drawing.Point(64, 301);
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
            this.materialLabel6.Location = new System.Drawing.Point(75, 367);
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
            this.dtpDate.Location = new System.Drawing.Point(156, 109);
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
            this.materialLabel1.Location = new System.Drawing.Point(82, 122);
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
            this.flpMeals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMeals.Location = new System.Drawing.Point(686, 118);
            this.flpMeals.Name = "flpMeals";
            this.flpMeals.Size = new System.Drawing.Size(554, 388);
            this.flpMeals.TabIndex = 13;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(1156, 86);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(84, 29);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Öğünler";
            // 
            // btnDaily
            // 
            this.btnDaily.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnDaily.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDaily.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDaily.Depth = 0;
            this.btnDaily.HighEmphasis = true;
            this.btnDaily.Icon = null;
            this.btnDaily.Location = new System.Drawing.Point(812, 520);
            this.btnDaily.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDaily.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDaily.Size = new System.Drawing.Size(112, 36);
            this.btnDaily.TabIndex = 16;
            this.btnDaily.Text = "Gün Raporu";
            this.btnDaily.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDaily.UseAccentColor = false;
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnOverview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOverview.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOverview.Depth = 0;
            this.btnOverview.HighEmphasis = true;
            this.btnOverview.Icon = null;
            this.btnOverview.Location = new System.Drawing.Point(932, 520);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOverview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnOverview.Size = new System.Drawing.Size(123, 36);
            this.btnOverview.TabIndex = 16;
            this.btnOverview.Text = "Kıyas Raporu";
            this.btnOverview.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOverview.UseAccentColor = false;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // btnFoodStats
            // 
            this.btnFoodStats.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnFoodStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFoodStats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFoodStats.Depth = 0;
            this.btnFoodStats.HighEmphasis = true;
            this.btnFoodStats.Icon = null;
            this.btnFoodStats.Location = new System.Drawing.Point(1063, 520);
            this.btnFoodStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFoodStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFoodStats.Name = "btnFoodStats";
            this.btnFoodStats.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnFoodStats.Size = new System.Drawing.Size(179, 36);
            this.btnFoodStats.TabIndex = 16;
            this.btnFoodStats.Text = "YEMEK İSTATİSTİKLERİ";
            this.btnFoodStats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFoodStats.UseAccentColor = false;
            this.btnFoodStats.UseVisualStyleBackColor = true;
            this.btnFoodStats.Click += new System.EventHandler(this.btnFoodStats_Click);
            // 
            // lblFoodDetails
            // 
            this.lblFoodDetails.AutoSize = true;
            this.lblFoodDetails.Depth = 0;
            this.lblFoodDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFoodDetails.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFoodDetails.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblFoodDetails.Location = new System.Drawing.Point(323, 367);
            this.lblFoodDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFoodDetails.Name = "lblFoodDetails";
            this.lblFoodDetails.Size = new System.Drawing.Size(53, 24);
            this.lblFoodDetails.TabIndex = 9;
            this.lblFoodDetails.Text = "0 kcal";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(637, 67);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 496);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // swhTheme
            // 
            this.swhTheme.AutoSize = true;
            this.swhTheme.Depth = 0;
            this.swhTheme.Location = new System.Drawing.Point(25, 519);
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
            this.lblUserCalculatedCalorie.Location = new System.Drawing.Point(913, 33);
            this.lblUserCalculatedCalorie.Name = "lblUserCalculatedCalorie";
            this.lblUserCalculatedCalorie.Size = new System.Drawing.Size(327, 23);
            this.lblUserCalculatedCalorie.TabIndex = 21;
            this.lblUserCalculatedCalorie.Text = "Günlük hedef: 1000 kcal";
            this.lblUserCalculatedCalorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 569);
            this.Controls.Add(this.lblUserCalculatedCalorie);
            this.Controls.Add(this.swhTheme);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnFoodStats);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnDaily);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private MaterialSkin.Controls.MaterialButton btnDaily;
        private MaterialSkin.Controls.MaterialButton btnOverview;
        private MaterialSkin.Controls.MaterialButton btnFoodStats;
        private MaterialSkin.Controls.MaterialLabel lblFoodDetails;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSwitch swhTheme;
        private Label lblUserCalculatedCalorie;
    }
}