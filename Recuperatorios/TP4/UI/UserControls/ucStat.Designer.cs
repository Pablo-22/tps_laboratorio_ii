
namespace UI
{
    partial class ucStat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblThanPreviousMonth = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.picboxDivider = new System.Windows.Forms.PictureBox();
            this.lblPreviousMonthAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDivider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategory.Location = new System.Drawing.Point(23, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(185, 35);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoría";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblThanPreviousWeek
            // 
            this.lblThanPreviousMonth.AutoSize = true;
            this.lblThanPreviousMonth.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThanPreviousMonth.ForeColor = System.Drawing.Color.DarkGray;
            this.lblThanPreviousMonth.Location = new System.Drawing.Point(413, 49);
            this.lblThanPreviousMonth.Name = "lblThanPreviousWeek";
            this.lblThanPreviousMonth.Size = new System.Drawing.Size(107, 25);
            this.lblThanPreviousMonth.TabIndex = 2;
            this.lblThanPreviousMonth.Text = "Cargando...";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(23, 51);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(185, 33);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Cargando...";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblPercentage.Location = new System.Drawing.Point(214, 36);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(193, 47);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "...";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picboxDivider
            // 
            this.picboxDivider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picboxDivider.Location = new System.Drawing.Point(23, 102);
            this.picboxDivider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxDivider.Name = "picboxDivider";
            this.picboxDivider.Size = new System.Drawing.Size(883, 2);
            this.picboxDivider.TabIndex = 5;
            this.picboxDivider.TabStop = false;
            // 
            // lblPreviousMonthAmount
            // 
            this.lblPreviousMonthAmount.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreviousMonthAmount.ForeColor = System.Drawing.Color.Black;
            this.lblPreviousMonthAmount.Location = new System.Drawing.Point(776, 50);
            this.lblPreviousMonthAmount.Name = "lblPreviousMonthAmount";
            this.lblPreviousMonthAmount.Size = new System.Drawing.Size(130, 31);
            this.lblPreviousMonthAmount.TabIndex = 6;
            this.lblPreviousMonthAmount.Text = "Cargando...";
            this.lblPreviousMonthAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(793, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mes pasado";
            // 
            // ucStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPreviousMonthAmount);
            this.Controls.Add(this.picboxDivider);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblThanPreviousMonth);
            this.Controls.Add(this.lblCategory);
            this.Name = "ucStat";
            this.Size = new System.Drawing.Size(929, 123);
            this.Load += new System.EventHandler(this.ucStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxDivider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblThanPreviousMonth;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.PictureBox picboxDivider;
        private System.Windows.Forms.Label lblPreviousMonthAmount;
        private System.Windows.Forms.Label label1;
    }
}
