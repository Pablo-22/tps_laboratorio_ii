
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
            this.lblThanPreviousWeek = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.picboxDivider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDivider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategory.Location = new System.Drawing.Point(24, 24);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(249, 47);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Indumentaria";
            // 
            // lblThanPreviousWeek
            // 
            this.lblThanPreviousWeek.AutoSize = true;
            this.lblThanPreviousWeek.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThanPreviousWeek.ForeColor = System.Drawing.Color.DarkGray;
            this.lblThanPreviousWeek.Location = new System.Drawing.Point(645, 37);
            this.lblThanPreviousWeek.Name = "lblThanPreviousWeek";
            this.lblThanPreviousWeek.Size = new System.Drawing.Size(260, 25);
            this.lblThanPreviousWeek.TabIndex = 2;
            this.lblThanPreviousWeek.Text = "menos que la semana pasada";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(279, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(177, 47);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "$800";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblPercentage.Location = new System.Drawing.Point(481, 24);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(162, 47);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "%100";
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
            // ucStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picboxDivider);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblThanPreviousWeek);
            this.Controls.Add(this.lblCategory);
            this.Name = "ucStat";
            this.Size = new System.Drawing.Size(929, 123);
            ((System.ComponentModel.ISupportInitialize)(this.picboxDivider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblThanPreviousWeek;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.PictureBox picboxDivider;
    }
}
