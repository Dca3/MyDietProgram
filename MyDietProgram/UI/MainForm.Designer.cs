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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.flpMeals = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(135, 35);
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
            this.lblUserCalculatedCalorie.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCalculatedCalorie.Depth = 0;
            this.lblUserCalculatedCalorie.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserCalculatedCalorie.ForeColor = System.Drawing.Color.White;
            this.lblUserCalculatedCalorie.Location = new System.Drawing.Point(1194, 35);
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
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
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
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(190, 110);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(362, 33);
            this.dtpDate.TabIndex = 12;
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
            this.flpMeals.Location = new System.Drawing.Point(708, 113);
            this.flpMeals.Name = "flpMeals";
            this.flpMeals.Size = new System.Drawing.Size(550, 418);
            this.flpMeals.TabIndex = 13;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 582);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.flpMeals);
            this.Controls.Add(this.dtpDate);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANASAYFA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DateTimePicker dtpDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlowLayoutPanel flpMeals;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}