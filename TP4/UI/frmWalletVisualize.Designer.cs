
namespace UI
{
    partial class frmWalletVisualize
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
            this.btnNewMovement = new System.Windows.Forms.Button();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUserWithMoreMovements = new System.Windows.Forms.Label();
            this.lblTodayMovements = new System.Windows.Forms.Label();
            this.lblUserWithBiggestMovement = new System.Windows.Forms.Label();
            this.lblTotalMovements = new System.Windows.Forms.Label();
            this.lblBiggestIncome = new System.Windows.Forms.Label();
            this.panelMovements = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstUsers.Size = new System.Drawing.Size(256, 465);
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(296, 32);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(296, 58);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.PlaceholderText = "Nombre";
            this.txtUserName.Size = new System.Drawing.Size(445, 40);
            // 
            // btnNewMovement
            // 
            this.btnNewMovement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewMovement.FlatAppearance.BorderSize = 0;
            this.btnNewMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMovement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewMovement.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNewMovement.Location = new System.Drawing.Point(25, 17);
            this.btnNewMovement.Name = "btnNewMovement";
            this.btnNewMovement.Size = new System.Drawing.Size(189, 42);
            this.btnNewMovement.TabIndex = 11;
            this.btnNewMovement.Text = "Nuevo ingreso";
            this.btnNewMovement.UseVisualStyleBackColor = false;
            this.btnNewMovement.Click += new System.EventHandler(this.btnNewMovement_Click);
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewExpense.FlatAppearance.BorderSize = 0;
            this.btnNewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewExpense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewExpense.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnNewExpense.Location = new System.Drawing.Point(25, 69);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(189, 42);
            this.btnNewExpense.TabIndex = 13;
            this.btnNewExpense.Text = "Nuevo gasto";
            this.btnNewExpense.UseVisualStyleBackColor = false;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(296, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(295, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 40);
            this.label3.TabIndex = 17;
            this.label3.Text = "$";
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBalance.Location = new System.Drawing.Point(337, 165);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(404, 46);
            this.txtBalance.TabIndex = 18;
            this.txtBalance.Text = "Saldo";
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Location = new System.Drawing.Point(25, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(447, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "El/los usuario/s con más movimientos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(447, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad de movimientos el día de hoy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(447, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(433, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "El/los usuario/s con el movimiento de más dinero";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(447, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total de movimientos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(447, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "El mayor ingreso registrado";
            // 
            // lblUserWithMoreMovements
            // 
            this.lblUserWithMoreMovements.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserWithMoreMovements.Location = new System.Drawing.Point(447, 509);
            this.lblUserWithMoreMovements.Name = "lblUserWithMoreMovements";
            this.lblUserWithMoreMovements.Size = new System.Drawing.Size(312, 90);
            this.lblUserWithMoreMovements.TabIndex = 26;
            this.lblUserWithMoreMovements.Text = "-";
            // 
            // lblTodayMovements
            // 
            this.lblTodayMovements.AutoSize = true;
            this.lblTodayMovements.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTodayMovements.Location = new System.Drawing.Point(447, 211);
            this.lblTodayMovements.Name = "lblTodayMovements";
            this.lblTodayMovements.Size = new System.Drawing.Size(24, 36);
            this.lblTodayMovements.TabIndex = 27;
            this.lblTodayMovements.Text = "-";
            // 
            // lblUserWithBiggestMovement
            // 
            this.lblUserWithBiggestMovement.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserWithBiggestMovement.Location = new System.Drawing.Point(447, 364);
            this.lblUserWithBiggestMovement.Name = "lblUserWithBiggestMovement";
            this.lblUserWithBiggestMovement.Size = new System.Drawing.Size(270, 98);
            this.lblUserWithBiggestMovement.TabIndex = 28;
            this.lblUserWithBiggestMovement.Text = "-";
            // 
            // lblTotalMovements
            // 
            this.lblTotalMovements.AutoSize = true;
            this.lblTotalMovements.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMovements.Location = new System.Drawing.Point(447, 69);
            this.lblTotalMovements.Name = "lblTotalMovements";
            this.lblTotalMovements.Size = new System.Drawing.Size(24, 36);
            this.lblTotalMovements.TabIndex = 29;
            this.lblTotalMovements.Text = "-";
            // 
            // lblBiggestIncome
            // 
            this.lblBiggestIncome.AutoSize = true;
            this.lblBiggestIncome.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBiggestIncome.Location = new System.Drawing.Point(447, 648);
            this.lblBiggestIncome.Name = "lblBiggestIncome";
            this.lblBiggestIncome.Size = new System.Drawing.Size(24, 36);
            this.lblBiggestIncome.TabIndex = 30;
            this.lblBiggestIncome.Text = "-";
            // 
            // panelMovements
            // 
            this.panelMovements.AutoScroll = true;
            this.panelMovements.Location = new System.Drawing.Point(893, 44);
            this.panelMovements.Name = "panelMovements";
            this.panelMovements.Size = new System.Drawing.Size(373, 685);
            this.panelMovements.TabIndex = 31;
            // 
            // frmWalletVisualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 768);
            this.Controls.Add(this.panelMovements);
            this.Controls.Add(this.lblBiggestIncome);
            this.Controls.Add(this.lblTotalMovements);
            this.Controls.Add(this.lblUserWithBiggestMovement);
            this.Controls.Add(this.lblTodayMovements);
            this.Controls.Add(this.lblUserWithMoreMovements);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewExpense);
            this.Controls.Add(this.btnNewMovement);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmWalletVisualize";
            this.Text = "frmWalletVisualize";
            this.Load += new System.EventHandler(this.frmWalletVisualize_Load);
            this.Controls.SetChildIndex(this.lblUsersList, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.lblMovements, 0);
            this.Controls.SetChildIndex(this.lstUsers, 0);
            this.Controls.SetChildIndex(this.btnNewMovement, 0);
            this.Controls.SetChildIndex(this.btnNewExpense, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtBalance, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblUserWithMoreMovements, 0);
            this.Controls.SetChildIndex(this.lblTodayMovements, 0);
            this.Controls.SetChildIndex(this.lblUserWithBiggestMovement, 0);
            this.Controls.SetChildIndex(this.lblTotalMovements, 0);
            this.Controls.SetChildIndex(this.lblBiggestIncome, 0);
            this.Controls.SetChildIndex(this.panelMovements, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewMovement;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUserWithMoreMovements;
        private System.Windows.Forms.Label lblTodayMovements;
        private System.Windows.Forms.Label lblUserWithBiggestMovement;
        private System.Windows.Forms.Label lblTotalMovements;
        private System.Windows.Forms.Label lblBiggestIncome;
        private System.Windows.Forms.Panel panelMovements;
    }
}