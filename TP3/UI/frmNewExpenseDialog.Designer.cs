
namespace UI
{
    partial class frmNewExpenseDialog
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
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.dateMovementDate = new System.Windows.Forms.DateTimePicker();
            this.lblActualBalance = new System.Windows.Forms.Label();
            this.lblNumActualBalance = new System.Windows.Forms.Label();
            this.lblSymbol1 = new System.Windows.Forms.Label();
            this.lblSymbol2 = new System.Windows.Forms.Label();
            this.lblNewBalance = new System.Windows.Forms.Label();
            this.lblNumNewBalance = new System.Windows.Forms.Label();
            this.lblMovementDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numAmount.Location = new System.Drawing.Point(443, 477);
            this.numAmount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(313, 43);
            this.numAmount.TabIndex = 2;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // dateMovementDate
            // 
            this.dateMovementDate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateMovementDate.Location = new System.Drawing.Point(444, 391);
            this.dateMovementDate.Name = "dateMovementDate";
            this.dateMovementDate.Size = new System.Drawing.Size(313, 37);
            this.dateMovementDate.TabIndex = 3;
            // 
            // lblActualBalance
            // 
            this.lblActualBalance.AutoSize = true;
            this.lblActualBalance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualBalance.Location = new System.Drawing.Point(444, 114);
            this.lblActualBalance.Name = "lblActualBalance";
            this.lblActualBalance.Size = new System.Drawing.Size(102, 23);
            this.lblActualBalance.TabIndex = 4;
            this.lblActualBalance.Text = "Saldo actual";
            // 
            // lblNumActualBalance
            // 
            this.lblNumActualBalance.BackColor = System.Drawing.Color.White;
            this.lblNumActualBalance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumActualBalance.Location = new System.Drawing.Point(488, 150);
            this.lblNumActualBalance.Name = "lblNumActualBalance";
            this.lblNumActualBalance.Size = new System.Drawing.Size(268, 55);
            this.lblNumActualBalance.TabIndex = 5;
            this.lblNumActualBalance.Text = "23000";
            this.lblNumActualBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSymbol1
            // 
            this.lblSymbol1.AutoSize = true;
            this.lblSymbol1.BackColor = System.Drawing.Color.Transparent;
            this.lblSymbol1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSymbol1.Location = new System.Drawing.Point(437, 148);
            this.lblSymbol1.Name = "lblSymbol1";
            this.lblSymbol1.Size = new System.Drawing.Size(49, 59);
            this.lblSymbol1.TabIndex = 6;
            this.lblSymbol1.Text = "$";
            // 
            // lblSymbol2
            // 
            this.lblSymbol2.AutoSize = true;
            this.lblSymbol2.BackColor = System.Drawing.Color.Transparent;
            this.lblSymbol2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSymbol2.Location = new System.Drawing.Point(438, 270);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.Size = new System.Drawing.Size(49, 59);
            this.lblSymbol2.TabIndex = 9;
            this.lblSymbol2.Text = "$";
            // 
            // lblNewBalance
            // 
            this.lblNewBalance.AutoSize = true;
            this.lblNewBalance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewBalance.Location = new System.Drawing.Point(438, 235);
            this.lblNewBalance.Name = "lblNewBalance";
            this.lblNewBalance.Size = new System.Drawing.Size(243, 23);
            this.lblNewBalance.TabIndex = 7;
            this.lblNewBalance.Text = "Saldo después del movimiento";
            // 
            // lblNumNewBalance
            // 
            this.lblNumNewBalance.BackColor = System.Drawing.Color.White;
            this.lblNumNewBalance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumNewBalance.Location = new System.Drawing.Point(491, 272);
            this.lblNumNewBalance.Name = "lblNumNewBalance";
            this.lblNumNewBalance.Size = new System.Drawing.Size(268, 55);
            this.lblNumNewBalance.TabIndex = 10;
            this.lblNumNewBalance.Text = "23000";
            this.lblNumNewBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMovementDate
            // 
            this.lblMovementDate.AutoSize = true;
            this.lblMovementDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMovementDate.Location = new System.Drawing.Point(443, 370);
            this.lblMovementDate.Name = "lblMovementDate";
            this.lblMovementDate.Size = new System.Drawing.Size(151, 19);
            this.lblMovementDate.TabIndex = 11;
            this.lblMovementDate.Text = "Fecha del movimiento";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(443, 456);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 19);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Monto";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(444, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 39);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Nuevo movimiento";
            // 
            // frmNewExpenseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblMovementDate);
            this.Controls.Add(this.lblNumNewBalance);
            this.Controls.Add(this.lblSymbol2);
            this.Controls.Add(this.lblNewBalance);
            this.Controls.Add(this.lblSymbol1);
            this.Controls.Add(this.lblNumActualBalance);
            this.Controls.Add(this.lblActualBalance);
            this.Controls.Add(this.dateMovementDate);
            this.Controls.Add(this.numAmount);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNewExpenseDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewExpenseDialog";
            this.Load += new System.EventHandler(this.frmNewExpenseDialog_Load);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.numAmount, 0);
            this.Controls.SetChildIndex(this.dateMovementDate, 0);
            this.Controls.SetChildIndex(this.lblActualBalance, 0);
            this.Controls.SetChildIndex(this.lblNumActualBalance, 0);
            this.Controls.SetChildIndex(this.lblSymbol1, 0);
            this.Controls.SetChildIndex(this.lblNewBalance, 0);
            this.Controls.SetChildIndex(this.lblSymbol2, 0);
            this.Controls.SetChildIndex(this.lblNumNewBalance, 0);
            this.Controls.SetChildIndex(this.lblMovementDate, 0);
            this.Controls.SetChildIndex(this.lblAmount, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.DateTimePicker dateMovementDate;
        private System.Windows.Forms.Label lblActualBalance;
        private System.Windows.Forms.Label lblNumActualBalance;
        private System.Windows.Forms.Label lblSymbol1;
        private System.Windows.Forms.Label lblSymbol2;
        private System.Windows.Forms.Label lblNewBalance;
        private System.Windows.Forms.Label lblNumNewBalance;
        private System.Windows.Forms.Label lblMovementDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTitle;
    }
}