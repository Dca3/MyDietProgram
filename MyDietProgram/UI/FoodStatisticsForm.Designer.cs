namespace MyDietProgram.UI
{
    partial class FoodStatisticsForm
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
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kahvaltı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÖğleYemegi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AkşamYemegi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atıştırma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStats
            // 
            this.dgvStats.AllowUserToAddRows = false;
            this.dgvStats.AllowUserToDeleteRows = false;
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Miktar,
            this.Kahvaltı,
            this.ÖğleYemegi,
            this.AkşamYemegi,
            this.Atıştırma});
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.Location = new System.Drawing.Point(3, 64);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.ReadOnly = true;
            this.dgvStats.RowHeadersVisible = false;
            this.dgvStats.RowTemplate.Height = 25;
            this.dgvStats.Size = new System.Drawing.Size(718, 394);
            this.dgvStats.TabIndex = 0;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // Kahvaltı
            // 
            this.Kahvaltı.DataPropertyName = "Kahvaltı";
            this.Kahvaltı.HeaderText = "Kahvaltı";
            this.Kahvaltı.Name = "Kahvaltı";
            this.Kahvaltı.ReadOnly = true;
            // 
            // ÖğleYemegi
            // 
            this.ÖğleYemegi.DataPropertyName = "ÖğleYemeği";
            this.ÖğleYemegi.HeaderText = "Öğle yemeği";
            this.ÖğleYemegi.Name = "ÖğleYemegi";
            this.ÖğleYemegi.ReadOnly = true;
            // 
            // AkşamYemegi
            // 
            this.AkşamYemegi.DataPropertyName = "AkşamYemeği";
            this.AkşamYemegi.HeaderText = "Akşam yemeği";
            this.AkşamYemegi.Name = "AkşamYemegi";
            this.AkşamYemegi.ReadOnly = true;
            // 
            // Atıştırma
            // 
            this.Atıştırma.DataPropertyName = "Atıştırma";
            this.Atıştırma.HeaderText = "Atıştırma";
            this.Atıştırma.Name = "Atıştırma";
            this.Atıştırma.ReadOnly = true;
            // 
            // FoodStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.dgvStats);
            this.Name = "FoodStatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yiyecek İstatistikleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvStats;
        private DataGridViewTextBoxColumn Ad;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Kahvaltı;
        private DataGridViewTextBoxColumn ÖğleYemegi;
        private DataGridViewTextBoxColumn AkşamYemegi;
        private DataGridViewTextBoxColumn Atıştırma;
    }
}