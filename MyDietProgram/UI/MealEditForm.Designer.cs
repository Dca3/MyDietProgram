namespace MyDietProgram.UI
{
    partial class MealEditForm
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
            this.flpFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpFoods
            // 
            this.flpFoods.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFoods.Location = new System.Drawing.Point(25, 97);
            this.flpFoods.Name = "flpFoods";
            this.flpFoods.Size = new System.Drawing.Size(472, 314);
            this.flpFoods.TabIndex = 0;
            // 
            // MealEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.flpFoods);
            this.MaximizeBox = false;
            this.Name = "MealEditForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğün Düzenle";
            this.Load += new System.EventHandler(this.MealEditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpFoods;
    }
}