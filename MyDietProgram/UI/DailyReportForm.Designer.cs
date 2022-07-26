namespace MyDietProgram.UI
{
    partial class DailyReportForm
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
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalCal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaily
            // 
            this.dgvDaily.AllowUserToAddRows = false;
            this.dgvDaily.AllowUserToDeleteRows = false;
            this.dgvDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaily.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaily.Location = new System.Drawing.Point(-3, 64);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.ReadOnly = true;
            this.dgvDaily.RowHeadersVisible = false;
            this.dgvDaily.RowTemplate.Height = 25;
            this.dgvDaily.Size = new System.Drawing.Size(574, 230);
            this.dgvDaily.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(452, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(111, 30);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "01.01.2022";
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCal.Location = new System.Drawing.Point(303, 297);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(260, 30);
            this.lblTotalCal.TabIndex = 1;
            this.lblTotalCal.Text = "Toplam: 1000 kcal";
            this.lblTotalCal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 330);
            this.Controls.Add(this.lblTotalCal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvDaily);
            this.MaximizeBox = false;
            this.Name = "DailyReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDaily;
        private DataGridViewTextBoxColumn MealName;
        private Label lblDate;
        private Label lblTotalCal;
    }
}