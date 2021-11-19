
namespace UI
{
    partial class ucMovement
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.picboxDivider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDivider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(29, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 21);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fecha";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(228, 9);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 21);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Monto";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(398, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 21);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Tipo";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(570, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 21);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // picboxDivider
            // 
            this.picboxDivider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picboxDivider.Location = new System.Drawing.Point(3, 48);
            this.picboxDivider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxDivider.Name = "picboxDivider";
            this.picboxDivider.Size = new System.Drawing.Size(883, 2);
            this.picboxDivider.TabIndex = 4;
            this.picboxDivider.TabStop = false;
            // 
            // ucMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picboxDivider);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Name = "ucMovement";
            this.Size = new System.Drawing.Size(888, 55);
            this.Load += new System.EventHandler(this.ucMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxDivider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox picboxDivider;
    }
}
