
namespace UI
{
    partial class frmStats
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
            this.lblIncomes = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblExpensesPercentage = new System.Windows.Forms.Label();
            this.lblExpensesMoreOrLess = new System.Windows.Forms.Label();
            this.lblIncomesMoreOrLess = new System.Windows.Forms.Label();
            this.lblIncomesPercentage = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.ucStat3 = new UI.ucStat();
            this.ucStat2 = new UI.ucStat();
            this.ucStat1 = new UI.ucStat();
            this.ucStat4 = new UI.ucStat();
            this.ucStat5 = new UI.ucStat();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.BackColor = System.Drawing.Color.White;
            this.lblIncomes.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncomes.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIncomes.Location = new System.Drawing.Point(435, 29);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(94, 30);
            this.lblIncomes.TabIndex = 2;
            this.lblIncomes.Text = "Ingresos";
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.BackColor = System.Drawing.Color.White;
            this.lblExpenses.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpenses.ForeColor = System.Drawing.Color.DarkGray;
            this.lblExpenses.Location = new System.Drawing.Point(758, 29);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(78, 30);
            this.lblExpenses.TabIndex = 3;
            this.lblExpenses.Text = "Gastos";
            // 
            // lblExpensesPercentage
            // 
            this.lblExpensesPercentage.BackColor = System.Drawing.Color.White;
            this.lblExpensesPercentage.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpensesPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblExpensesPercentage.Location = new System.Drawing.Point(663, 63);
            this.lblExpensesPercentage.Name = "lblExpensesPercentage";
            this.lblExpensesPercentage.Size = new System.Drawing.Size(276, 50);
            this.lblExpensesPercentage.TabIndex = 4;
            this.lblExpensesPercentage.Text = "Cargando...";
            this.lblExpensesPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpensesMoreOrLess
            // 
            this.lblExpensesMoreOrLess.BackColor = System.Drawing.Color.White;
            this.lblExpensesMoreOrLess.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpensesMoreOrLess.ForeColor = System.Drawing.Color.DarkGray;
            this.lblExpensesMoreOrLess.Location = new System.Drawing.Point(663, 119);
            this.lblExpensesMoreOrLess.Name = "lblExpensesMoreOrLess";
            this.lblExpensesMoreOrLess.Size = new System.Drawing.Size(276, 30);
            this.lblExpensesMoreOrLess.TabIndex = 5;
            this.lblExpensesMoreOrLess.Text = "más que el mes pasado";
            this.lblExpensesMoreOrLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncomesMoreOrLess
            // 
            this.lblIncomesMoreOrLess.BackColor = System.Drawing.Color.White;
            this.lblIncomesMoreOrLess.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncomesMoreOrLess.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIncomesMoreOrLess.Location = new System.Drawing.Point(350, 119);
            this.lblIncomesMoreOrLess.Name = "lblIncomesMoreOrLess";
            this.lblIncomesMoreOrLess.Size = new System.Drawing.Size(276, 30);
            this.lblIncomesMoreOrLess.TabIndex = 6;
            this.lblIncomesMoreOrLess.Text = "más que el mes pasado";
            this.lblIncomesMoreOrLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncomesPercentage
            // 
            this.lblIncomesPercentage.BackColor = System.Drawing.Color.White;
            this.lblIncomesPercentage.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncomesPercentage.ForeColor = System.Drawing.Color.Black;
            this.lblIncomesPercentage.Location = new System.Drawing.Point(350, 63);
            this.lblIncomesPercentage.Name = "lblIncomesPercentage";
            this.lblIncomesPercentage.Size = new System.Drawing.Size(276, 50);
            this.lblIncomesPercentage.TabIndex = 7;
            this.lblIncomesPercentage.Text = "Cargando...";
            this.lblIncomesPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.White;
            this.lblMonth.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMonth.Location = new System.Drawing.Point(148, 31);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 30);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "Mes";
            // 
            // lblMonthName
            // 
            this.lblMonthName.BackColor = System.Drawing.Color.White;
            this.lblMonthName.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonthName.ForeColor = System.Drawing.Color.Black;
            this.lblMonthName.Location = new System.Drawing.Point(36, 61);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(276, 49);
            this.lblMonthName.TabIndex = 9;
            this.lblMonthName.Text = "Cargando...";
            this.lblMonthName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.BackColor = System.Drawing.Color.White;
            this.lblStatsTitle.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatsTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStatsTitle.Location = new System.Drawing.Point(36, 119);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(276, 30);
            this.lblStatsTitle.TabIndex = 10;
            this.lblStatsTitle.Text = "Estadísticas";
            this.lblStatsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStats
            // 
            this.pnlStats.AutoScroll = true;
            this.pnlStats.Controls.Add(this.ucStat5);
            this.pnlStats.Controls.Add(this.ucStat4);
            this.pnlStats.Controls.Add(this.ucStat3);
            this.pnlStats.Controls.Add(this.ucStat2);
            this.pnlStats.Controls.Add(this.ucStat1);
            this.pnlStats.Location = new System.Drawing.Point(12, 175);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(977, 300);
            this.pnlStats.TabIndex = 11;
            // 
            // ucStat3
            // 
            this.ucStat3.BackColor = System.Drawing.Color.White;
            this.ucStat3.Location = new System.Drawing.Point(24, 226);
            this.ucStat3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucStat3.Name = "ucStat3";
            this.ucStat3.Size = new System.Drawing.Size(929, 123);
            this.ucStat3.TabIndex = 2;
            // 
            // ucStat2
            // 
            this.ucStat2.BackColor = System.Drawing.Color.White;
            this.ucStat2.Location = new System.Drawing.Point(24, 114);
            this.ucStat2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucStat2.Name = "ucStat2";
            this.ucStat2.Size = new System.Drawing.Size(929, 123);
            this.ucStat2.TabIndex = 1;
            // 
            // ucStat1
            // 
            this.ucStat1.BackColor = System.Drawing.Color.White;
            this.ucStat1.Location = new System.Drawing.Point(24, 3);
            this.ucStat1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucStat1.Name = "ucStat1";
            this.ucStat1.Size = new System.Drawing.Size(929, 123);
            this.ucStat1.TabIndex = 0;
            // 
            // ucStat4
            // 
            this.ucStat4.BackColor = System.Drawing.Color.White;
            this.ucStat4.Location = new System.Drawing.Point(24, 344);
            this.ucStat4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucStat4.Name = "ucStat4";
            this.ucStat4.Size = new System.Drawing.Size(929, 123);
            this.ucStat4.TabIndex = 3;
            // 
            // ucStat5
            // 
            this.ucStat5.BackColor = System.Drawing.Color.White;
            this.ucStat5.Location = new System.Drawing.Point(24, 473);
            this.ucStat5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucStat5.Name = "ucStat5";
            this.ucStat5.Size = new System.Drawing.Size(929, 123);
            this.ucStat5.TabIndex = 4;
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.Properties.Resources.StatsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 487);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.lblStatsTitle);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblIncomesPercentage);
            this.Controls.Add(this.lblIncomesMoreOrLess);
            this.Controls.Add(this.lblExpensesMoreOrLess);
            this.Controls.Add(this.lblExpensesPercentage);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblIncomes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStats";
            this.Text = "frmStats";
            this.Load += new System.EventHandler(this.frmStats_Load);
            this.pnlStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncomes;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblExpensesPercentage;
        private System.Windows.Forms.Label lblExpensesMoreOrLess;
        private System.Windows.Forms.Label lblIncomesMoreOrLess;
        private System.Windows.Forms.Label lblIncomesPercentage;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Panel pnlStats;
        private ucStat ucStat3;
        private ucStat ucStat2;
        private ucStat ucStat1;
        private ucStat ucStat5;
        private ucStat ucStat4;
    }
}