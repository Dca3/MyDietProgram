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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserCalculatedCalorie = new MaterialSkin.Controls.MaterialLabel();
            this.cbMeals = new MaterialSkin.Controls.MaterialComboBox();
            this.cbCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.btnNewFood = new MaterialSkin.Controls.MaterialButton();
            this.cbFoods = new MaterialSkin.Controls.MaterialComboBox();
            this.txtAmount = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTotalCalorie = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddMeal = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.flpMeals = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.flpMeals.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 37);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnMinimize.AutoSize = false;
            this.btnMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinimize.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMinimize.Depth = 0;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HighEmphasis = true;
            this.btnMinimize.Icon = null;
            this.btnMinimize.Location = new System.Drawing.Point(1200, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnMinimize.Size = new System.Drawing.Size(47, 37);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMinimize.UseAccentColor = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnClose.AutoSize = false;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(1247, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnClose.Size = new System.Drawing.Size(47, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.Location = new System.Drawing.Point(23, 53);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(184, 19);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Hoşgeldiniz, Lorem İpsum";
            // 
            // lblUserCalculatedCalorie
            // 
            this.lblUserCalculatedCalorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserCalculatedCalorie.AutoSize = true;
            this.lblUserCalculatedCalorie.Depth = 0;
            this.lblUserCalculatedCalorie.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserCalculatedCalorie.Location = new System.Drawing.Point(1248, 53);
            this.lblUserCalculatedCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserCalculatedCalorie.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserCalculatedCalorie.Name = "lblUserCalculatedCalorie";
            this.lblUserCalculatedCalorie.Size = new System.Drawing.Size(10, 19);
            this.lblUserCalculatedCalorie.TabIndex = 6;
            this.lblUserCalculatedCalorie.Text = "0";
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
            this.cbMeals.Location = new System.Drawing.Point(189, 159);
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
            this.cbCategories.Location = new System.Drawing.Point(189, 222);
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
            this.btnNewFood.Location = new System.Drawing.Point(559, 300);
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
            this.cbFoods.Location = new System.Drawing.Point(189, 287);
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
            this.txtAmount.Location = new System.Drawing.Point(189, 363);
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
            // lblTotalCalorie
            // 
            this.lblTotalCalorie.AutoSize = true;
            this.lblTotalCalorie.Depth = 0;
            this.lblTotalCalorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCalorie.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalCalorie.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTotalCalorie.Location = new System.Drawing.Point(189, 447);
            this.lblTotalCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCalorie.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalCalorie.Name = "lblTotalCalorie";
            this.lblTotalCalorie.Size = new System.Drawing.Size(45, 24);
            this.lblTotalCalorie.TabIndex = 9;
            this.lblTotalCalorie.Text = "0000";
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnAddMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMeal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMeal.Depth = 0;
            this.btnAddMeal.HighEmphasis = true;
            this.btnAddMeal.Icon = null;
            this.btnAddMeal.Location = new System.Drawing.Point(190, 492);
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
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(116, 174);
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
            this.materialLabel4.Location = new System.Drawing.Point(93, 237);
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
            this.materialLabel5.Location = new System.Drawing.Point(98, 302);
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
            this.materialLabel6.Location = new System.Drawing.Point(123, 381);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(46, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Miktar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 33);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(116, 123);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Tarih";
            // 
            // flpMeals
            // 
            this.flpMeals.Controls.Add(this.panel2);
            this.flpMeals.Controls.Add(this.panel3);
            this.flpMeals.Location = new System.Drawing.Point(723, 123);
            this.flpMeals.Name = "flpMeals";
            this.flpMeals.Size = new System.Drawing.Size(550, 418);
            this.flpMeals.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.materialLabel7);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 95);
            this.panel2.TabIndex = 0;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(290, 46);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(57, 19);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "400kcal";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(14, 46);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(202, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Domates, Salatalık, Yumurta";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(14, 11);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(74, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Kahvaltı";
            // 
            // materialButton1
            // 
            this.materialButton1.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(468, 36);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "SİL";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(375, 36);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialButton2.Size = new System.Drawing.Size(85, 36);
            this.materialButton2.TabIndex = 7;
            this.materialButton2.Text = "Düzenle";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(1174, 81);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(84, 29);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Öğünler";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialLabel10);
            this.panel3.Controls.Add(this.materialLabel11);
            this.panel3.Controls.Add(this.materialLabel12);
            this.panel3.Controls.Add(this.materialButton3);
            this.panel3.Controls.Add(this.materialButton4);
            this.panel3.Location = new System.Drawing.Point(3, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 95);
            this.panel3.TabIndex = 8;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(290, 46);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(57, 19);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "400kcal";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(14, 46);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(202, 19);
            this.materialLabel11.TabIndex = 0;
            this.materialLabel11.Text = "Domates, Salatalık, Yumurta";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel12.Location = new System.Drawing.Point(14, 11);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(112, 24);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Öğle yemeği";
            // 
            // materialButton3
            // 
            this.materialButton3.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(375, 36);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialButton3.Size = new System.Drawing.Size(85, 36);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "Düzenle";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(468, 36);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.materialButton4.Size = new System.Drawing.Size(64, 36);
            this.materialButton4.TabIndex = 7;
            this.materialButton4.Text = "SİL";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton4.UseAccentColor = true;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 582);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.flpMeals);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTotalCalorie);
            this.Controls.Add(this.cbFoods);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbMeals);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.btnNewFood);
            this.Controls.Add(this.lblUserCalculatedCalorie);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.flpMeals.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnMinimize;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private MaterialSkin.Controls.MaterialLabel lblUserCalculatedCalorie;
        private MaterialSkin.Controls.MaterialComboBox cbMeals;
        private MaterialSkin.Controls.MaterialComboBox cbCategories;
        private MaterialSkin.Controls.MaterialButton btnNewFood;
        private MaterialSkin.Controls.MaterialComboBox cbFoods;
        private MaterialSkin.Controls.MaterialTextBox txtAmount;
        private MaterialSkin.Controls.MaterialLabel lblTotalCalorie;
        private MaterialSkin.Controls.MaterialButton btnAddMeal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlowLayoutPanel flpMeals;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}