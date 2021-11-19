using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using System.Windows.Forms;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.InputOutput;


namespace UI
{
    public partial class frmMainDashboard : Form
    {
        public frmStats stats;
        public frmMovements movements;
        private bool statsIsActive;
        private bool movementsIsActive;

        public bool FrmMovementsIsActive
        {
            get { return movementsIsActive; }
            set { movementsIsActive = value; }
        }


        public bool FrmStatsIsActive
        {
            get { return statsIsActive; }
            set { statsIsActive = value; }
        }


        public frmMainDashboard()
        {
            InitializeComponent();
            this.statsIsActive = false;
            this.movementsIsActive = false;
            this.movements = new frmMovements();
            this.stats = new frmStats(this.movements);
        }

        private void LoadUserData()
        {
            lblNumActualBalance.Text = Core.UserWallet.Balance.ToString("$##,##,##,##0.00");
            lblUserName.Text = Core.ActualUser.Name;
            lblNumWalletId.Text = Core.UserWallet.Id.ToString();
            lblNumTotalExpenses.Text = Bank.GetTotalExpensesAmount().ToString("$##,##,##,##0.00");
            lblNumTotalIncomes.Text = Bank.GetTotalIncomesAmount().ToString("$##,##,##,##0.00");
        }

        private void onNewMovement(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            movements.newMovement += onNewMovement;
            this.IsLogged(false);
            Core.GetProjectConfig();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblShowMovements_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowMovements_Click(object sender, EventArgs e)
        {
            if (!this.FrmMovementsIsActive)
            {
                movements.TopLevel = false;
                pnlFormsContainer.Controls.Add(movements);
                movements.Show();
                this.FrmMovementsIsActive = true;
            }
                movements.BringToFront();
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            if (!this.FrmStatsIsActive)
            {
                stats.TopLevel = false;
                pnlFormsContainer.Controls.Add(stats);
                stats.Show();
                this.FrmStatsIsActive = true;
            }
                stats.BringToFront();
        }

        private void btnLogInLogOut_Click(object sender, EventArgs e)
        {
            if (btnLogInLogOut.Text == "Iniciar sesión")
            {
                frmLogin login = new frmLogin();
                DialogResult result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.IsLogged(true);
                    this.LoadUserData();
                }
            }
            else
            {
                Core.LogOut();
                this.IsLogged(false);
            }
        }
        private void IsLogged(bool isLogged)
        {
            if (isLogged)
            {
                btnShowMovements.Enabled = true;
                btnShowStats.Enabled = true;
                btnLogInLogOut.Text = "Cerrar sesión";
            }
            else
            {
                btnShowMovements.Enabled = false;
                btnShowStats.Enabled = false;
                btnLogInLogOut.Text = "Iniciar sesión";
                this.movements.Visible = false;
                this.stats.Visible = false;
                this.movementsIsActive = false;
                this.statsIsActive = false;
            }
        }
    }
}
