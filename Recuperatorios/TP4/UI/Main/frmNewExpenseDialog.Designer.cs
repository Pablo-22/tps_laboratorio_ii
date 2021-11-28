
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.ForeColor = System.Drawing.Color.Purple;
            this.btnAccept.Location = new System.Drawing.Point(528, 644);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.Purple;
            this.btnCancel.Location = new System.Drawing.Point(528, 707);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numAmount.Location = new System.Drawing.Point(528, 472);
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
            this.dateMovementDate.Location = new System.Drawing.Point(528, 386);
            this.dateMovementDate.Name = "dateMovementDate";
            this.dateMovementDate.Size = new System.Drawing.Size(313, 37);
            this.dateMovementDate.TabIndex = 3;
            // 
            // lblActualBalance
            // 
            this.lblActualBalance.AutoSize = true;
            this.lblActualBalance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActualBalance.Location = new System.Drawing.Point(528, 125);
            this.lblActualBalance.Name = "lblActualBalance";
            this.lblActualBalance.Size = new System.Drawing.Size(102, 23);
            this.lblActualBalance.TabIndex = 4;
            this.lblActualBalance.Text = "Saldo actual";
            // 
            // lblNumActualBalance
            // 
            this.lblNumActualBalance.BackColor = System.Drawing.Color.White;
            this.lblNumActualBalance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumActualBalance.Location = new System.Drawing.Point(573, 161);
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
            this.lblSymbol1.Location = new System.Drawing.Point(522, 159);
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
            this.lblSymbol2.Location = new System.Drawing.Point(523, 281);
            this.lblSymbol2.Name = "lblSymbol2";
            this.lblSymbol2.Size = new System.Drawing.Size(49, 59);
            this.lblSymbol2.TabIndex = 9;
            this.lblSymbol2.Text = "$";
            // 
            // lblNewBalance
            // 
            this.lblNewBalance.AutoSize = true;
            this.lblNewBalance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewBalance.Location = new System.Drawing.Point(523, 246);
            this.lblNewBalance.Name = "lblNewBalance";
            this.lblNewBalance.Size = new System.Drawing.Size(243, 23);
            this.lblNewBalance.TabIndex = 7;
            this.lblNewBalance.Text = "Saldo después del movimiento";
            // 
            // lblNumNewBalance
            // 
            this.lblNumNewBalance.BackColor = System.Drawing.Color.White;
            this.lblNumNewBalance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumNewBalance.Location = new System.Drawing.Point(576, 283);
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
            this.lblMovementDate.Location = new System.Drawing.Point(528, 365);
            this.lblMovementDate.Name = "lblMovementDate";
            this.lblMovementDate.Size = new System.Drawing.Size(151, 19);
            this.lblMovementDate.TabIndex = 11;
            this.lblMovementDate.Text = "Fecha del movimiento";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(528, 451);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 19);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Monto";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(528, 50);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(316, 53);
            this.cmbType.TabIndex = 16;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Nuevo gasto",
            "Nuevo ingreso"});
            this.cmbCategory.Location = new System.Drawing.Point(528, 572);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(316, 40);
            this.cmbCategory.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(528, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(528, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de movimiento";
            // 
            // frmNewExpenseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbType);
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
            this.Controls.SetChildIndex(this.cmbType, 0);
            this.Controls.SetChildIndex(this.cmbCategory, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
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
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}