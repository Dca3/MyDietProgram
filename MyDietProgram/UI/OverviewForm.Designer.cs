namespace MyDietProgram.UI
{
    partial class OverviewForm
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
            this.rbWeek = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMonth = new MaterialSkin.Controls.MaterialRadioButton();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.rbCategory = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMeal = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblDates = new MaterialSkin.Controls.MaterialLabel();
            this.btnPrev = new MaterialSkin.Controls.MaterialButton();
            this.btnNext = new MaterialSkin.Controls.MaterialButton();
            this.gbDateTypes = new System.Windows.Forms.GroupBox();
            this.gbFilterTypes = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.gbDateTypes.SuspendLayout();
            this.gbFilterTypes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Checked = true;
            this.rbWeek.Depth = 0;
            this.rbWeek.Location = new System.Drawing.Point(32, 33);
            this.rbWeek.Margin = new System.Windows.Forms.Padding(0);
            this.rbWeek.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbWeek.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Ripple = true;
            this.rbWeek.Size = new System.Drawing.Size(91, 37);
            this.rbWeek.TabIndex = 1;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Haftalık";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Depth = 0;
            this.rbMonth.Location = new System.Drawing.Point(147, 33);
            this.rbMonth.Margin = new System.Windows.Forms.Padding(0);
            this.rbMonth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Ripple = true;
            this.rbMonth.Size = new System.Drawing.Size(69, 37);
            this.rbMonth.TabIndex = 1;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Aylık";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(17, 177);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(894, 400);
            this.dgvResults.TabIndex = 2;
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Depth = 0;
            this.rbCategory.Location = new System.Drawing.Point(141, 33);
            this.rbCategory.Margin = new System.Windows.Forms.Padding(0);
            this.rbCategory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Ripple = true;
            this.rbCategory.Size = new System.Drawing.Size(94, 37);
            this.rbCategory.TabIndex = 1;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Kategori";
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.CheckedChanged += new System.EventHandler(this.rbCategory_CheckedChanged);
            // 
            // rbMeal
            // 
            this.rbMeal.AutoSize = true;
            this.rbMeal.Checked = true;
            this.rbMeal.Depth = 0;
            this.rbMeal.Location = new System.Drawing.Point(31, 32);
            this.rbMeal.Margin = new System.Windows.Forms.Padding(0);
            this.rbMeal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMeal.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMeal.Name = "rbMeal";
            this.rbMeal.Ripple = true;
            this.rbMeal.Size = new System.Drawing.Size(73, 37);
            this.rbMeal.TabIndex = 1;
            this.rbMeal.TabStop = true;
            this.rbMeal.Text = "Öğün";
            this.rbMeal.UseVisualStyleBackColor = true;
            this.rbMeal.CheckedChanged += new System.EventHandler(this.rbMeal_CheckedChanged);
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Depth = 0;
            this.lblDates.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDates.Location = new System.Drawing.Point(90, 16);
            this.lblDates.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(173, 19);
            this.lblDates.TabIndex = 3;
            this.lblDates.Text = "01.01.2022 - 01.01.2022";
            // 
            // btnPrev
            // 
            this.btnPrev.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrev.Depth = 0;
            this.btnPrev.HighEmphasis = true;
            this.btnPrev.Icon = null;
            this.btnPrev.Location = new System.Drawing.Point(4, 6);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnPrev.Size = new System.Drawing.Size(64, 36);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrev.UseAccentColor = false;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNext.Depth = 0;
            this.btnNext.HighEmphasis = true;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(285, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.NoAccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnNext.Size = new System.Drawing.Size(64, 36);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNext.UseAccentColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbDateTypes
            // 
            this.gbDateTypes.Controls.Add(this.rbWeek);
            this.gbDateTypes.Controls.Add(this.rbMonth);
            this.gbDateTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDateTypes.Location = new System.Drawing.Point(34, 76);
            this.gbDateTypes.Name = "gbDateTypes";
            this.gbDateTypes.Size = new System.Drawing.Size(267, 95);
            this.gbDateTypes.TabIndex = 5;
            this.gbDateTypes.TabStop = false;
            this.gbDateTypes.Text = "Zaman aralığı";
            // 
            // gbFilterTypes
            // 
            this.gbFilterTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilterTypes.Controls.Add(this.rbCategory);
            this.gbFilterTypes.Controls.Add(this.rbMeal);
            this.gbFilterTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFilterTypes.Location = new System.Drawing.Point(625, 76);
            this.gbFilterTypes.Name = "gbFilterTypes";
            this.gbFilterTypes.Size = new System.Drawing.Size(267, 95);
            this.gbFilterTypes.TabIndex = 6;
            this.gbFilterTypes.TabStop = false;
            this.gbFilterTypes.Text = "Filtre türü";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.lblDates);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(284, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 47);
            this.panel1.TabIndex = 7;
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFilterTypes);
            this.Controls.Add(this.gbDateTypes);
            this.Controls.Add(this.dgvResults);
            this.Name = "OverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karşılaştırma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.gbDateTypes.ResumeLayout(false);
            this.gbDateTypes.PerformLayout();
            this.gbFilterTypes.ResumeLayout(false);
            this.gbFilterTypes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton rbWeek;
        private MaterialSkin.Controls.MaterialRadioButton rbMonth;
        private DataGridView dgvResults;
        private MaterialSkin.Controls.MaterialRadioButton rbCategory;
        private MaterialSkin.Controls.MaterialRadioButton rbMeal;
        private MaterialSkin.Controls.MaterialLabel lblDates;
        private MaterialSkin.Controls.MaterialButton btnPrev;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private GroupBox gbDateTypes;
        private GroupBox gbFilterTypes;
        private Panel panel1;
    }
}