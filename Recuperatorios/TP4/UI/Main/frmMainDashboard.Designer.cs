
namespace UI
{
    partial class frmMainDashboard
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWalletId = new System.Windows.Forms.Label();
            this.lblNumWalletId = new System.Windows.Forms.Label();
            this.lblActualBalance = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblTotalIncomes = new System.Windows.Forms.Label();
            this.lblNumActualBalance = new System.Windows.Forms.Label();
            this.lblNumTotalIncomes = new System.Windows.Forms.Label();
            this.lblNumTotalExpenses = new System.Windows.Forms.Label();
            this.pnlFormsContainer = new System.Windows.Forms.Panel();
            this.lblTips = new System.Windows.Forms.Label();
            this.btnShowMovements = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.btnLogInLogOut = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Label();
            this.pnlFormsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(20, 68);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(251, 37);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Nombre";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWalletId
            // 
            this.lblWalletId.AutoSize = true;
            this.lblWalletId.BackColor = System.Drawing.Color.White;
            this.lblWalletId.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWalletId.ForeColor = System.Drawing.Color.Silver;
            this.lblWalletId.Location = new System.Drawing.Point(47, 105);
            this.lblWalletId.Name = "lblWalletId";
            this.lblWalletId.Size = new System.Drawing.Size(103, 30);
            this.lblWalletId.TabIndex = 1;
            this.lblWalletId.Text = "Wallet ID:";
            // 
            // lblNumWalletId
            // 
            this.lblNumWalletId.BackColor = System.Drawing.Color.White;
            this.lblNumWalletId.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumWalletId.ForeColor = System.Drawing.Color.Silver;
            this.lblNumWalletId.Location = new System.Drawing.Point(156, 106);
            this.lblNumWalletId.Name = "lblNumWalletId";
            this.lblNumWalletId.Size = new System.Drawing.Size(115, 30);
            this.lblNumWalletId.TabIndex = 2;
            this.lblNumWalletId.Text = "-";
            // 
            // lblActualBalance
            // 
            this.lblActualBalance.AutoSize = true;
            this.lblActualBalance.BackColor = System.Drawing.Color.White;
            this.lblActualBalance.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualBalance.ForeColor = System.Drawing.Color.Purple;
            this.lblActualBalance.Location = new System.Drawing.Point(414, 82);
            this.lblActualBalance.Name = "lblActualBalance";
            this.lblActualBalance.Size = new System.Drawing.Size(116, 25);
            this.lblActualBalance.TabIndex = 6;
            this.lblActualBalance.Text = "Saldo actual";
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.BackColor = System.Drawing.Color.White;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalExpenses.ForeColor = System.Drawing.Color.Red;
            this.lblTotalExpenses.Location = new System.Drawing.Point(1089, 86);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(113, 21);
            this.lblTotalExpenses.TabIndex = 7;
            this.lblTotalExpenses.Text = "Gastos totales";
            // 
            // lblTotalIncomes
            // 
            this.lblTotalIncomes.AutoSize = true;
            this.lblTotalIncomes.BackColor = System.Drawing.Color.White;
            this.lblTotalIncomes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIncomes.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalIncomes.Location = new System.Drawing.Point(743, 82);
            this.lblTotalIncomes.Name = "lblTotalIncomes";
            this.lblTotalIncomes.Size = new System.Drawing.Size(127, 21);
            this.lblTotalIncomes.TabIndex = 8;
            this.lblTotalIncomes.Text = "Ingresos totales";
            // 
            // lblNumActualBalance
            // 
            this.lblNumActualBalance.BackColor = System.Drawing.Color.White;
            this.lblNumActualBalance.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumActualBalance.Location = new System.Drawing.Point(313, 111);
            this.lblNumActualBalance.Name = "lblNumActualBalance";
            this.lblNumActualBalance.Size = new System.Drawing.Size(321, 50);
            this.lblNumActualBalance.TabIndex = 9;
            this.lblNumActualBalance.Text = "$00,000.00";
            this.lblNumActualBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumTotalIncomes
            // 
            this.lblNumTotalIncomes.BackColor = System.Drawing.Color.White;
            this.lblNumTotalIncomes.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumTotalIncomes.Location = new System.Drawing.Point(647, 111);
            this.lblNumTotalIncomes.Name = "lblNumTotalIncomes";
            this.lblNumTotalIncomes.Size = new System.Drawing.Size(322, 50);
            this.lblNumTotalIncomes.TabIndex = 10;
            this.lblNumTotalIncomes.Text = "$00,000.00";
            this.lblNumTotalIncomes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumTotalExpenses
            // 
            this.lblNumTotalExpenses.BackColor = System.Drawing.Color.White;
            this.lblNumTotalExpenses.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumTotalExpenses.Location = new System.Drawing.Point(980, 111);
            this.lblNumTotalExpenses.Name = "lblNumTotalExpenses";
            this.lblNumTotalExpenses.Size = new System.Drawing.Size(325, 50);
            this.lblNumTotalExpenses.TabIndex = 11;
            this.lblNumTotalExpenses.Text = "$00,000.00";
            this.lblNumTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFormsContainer
            // 
            this.pnlFormsContainer.Controls.Add(this.lblTips);
            this.pnlFormsContainer.Location = new System.Drawing.Point(311, 245);
            this.pnlFormsContainer.Name = "pnlFormsContainer";
            this.pnlFormsContainer.Size = new System.Drawing.Size(1001, 487);
            this.pnlFormsContainer.TabIndex = 12;
            this.pnlFormsContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormsContainer_Paint);
            // 
            // lblTips
            // 
            this.lblTips.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTips.ForeColor = System.Drawing.Color.LightGray;
            this.lblTips.Location = new System.Drawing.Point(14, 181);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(972, 125);
            this.lblTips.TabIndex = 1;
            this.lblTips.Text = "Inicie sesión para comenzar";
            this.lblTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowMovements
            // 
            this.btnShowMovements.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowMovements.FlatAppearance.BorderSize = 0;
            this.btnShowMovements.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnShowMovements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnShowMovements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMovements.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowMovements.Location = new System.Drawing.Point(20, 264);
            this.btnShowMovements.Name = "btnShowMovements";
            this.btnShowMovements.Size = new System.Drawing.Size(251, 37);
            this.btnShowMovements.TabIndex = 13;
            this.btnShowMovements.Text = "Movimientos     ";
            this.btnShowMovements.UseVisualStyleBackColor = true;
            this.btnShowMovements.Click += new System.EventHandler(this.btnShowMovements_Click);
            // 
            // btnShowStats
            // 
            this.btnShowStats.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowStats.FlatAppearance.BorderSize = 0;
            this.btnShowStats.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnShowStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnShowStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStats.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowStats.Location = new System.Drawing.Point(20, 317);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(251, 37);
            this.btnShowStats.TabIndex = 14;
            this.btnShowStats.Text = "Informes            ";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // btnLogInLogOut
            // 
            this.btnLogInLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogInLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogInLogOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLogInLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogInLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogInLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInLogOut.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogInLogOut.Location = new System.Drawing.Point(20, 695);
            this.btnLogInLogOut.Name = "btnLogInLogOut";
            this.btnLogInLogOut.Size = new System.Drawing.Size(251, 37);
            this.btnLogInLogOut.TabIndex = 15;
            this.btnLogInLogOut.Text = "Cerrar sesión    ";
            this.btnLogInLogOut.UseVisualStyleBackColor = true;
            this.btnLogInLogOut.Click += new System.EventHandler(this.btnLogInLogOut_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(20, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(251, 37);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar              ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Location = new System.Drawing.Point(20, 423);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(251, 37);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Exportar             ";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1324, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 21);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "⚫";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // frmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLogInLogOut);
            this.Controls.Add(this.btnShowStats);
            this.Controls.Add(this.btnShowMovements);
            this.Controls.Add(this.pnlFormsContainer);
            this.Controls.Add(this.lblNumTotalExpenses);
            this.Controls.Add(this.lblNumTotalIncomes);
            this.Controls.Add(this.lblNumActualBalance);
            this.Controls.Add(this.lblTotalIncomes);
            this.Controls.Add(this.lblTotalExpenses);
            this.Controls.Add(this.lblActualBalance);
            this.Controls.Add(this.lblNumWalletId);
            this.Controls.Add(this.lblWalletId);
            this.Controls.Add(this.lblUserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainDashboard";
            this.Load += new System.EventHandler(this.frmMainDashboard_Load);
            this.pnlFormsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWalletId;
        private System.Windows.Forms.Label lblNumWalletId;
        private System.Windows.Forms.Label lblActualBalance;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblTotalIncomes;
        private System.Windows.Forms.Label lblNumActualBalance;
        private System.Windows.Forms.Label lblNumTotalIncomes;
        private System.Windows.Forms.Label lblNumTotalExpenses;
        private System.Windows.Forms.Panel pnlFormsContainer;
        private System.Windows.Forms.Button btnShowMovements;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Button btnLogInLogOut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label btnExit;
    }
}