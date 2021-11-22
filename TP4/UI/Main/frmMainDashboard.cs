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
        public event EventHandler logIn;
        public event EventHandler logOut;

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

        private void Clean()
        {
            lblNumActualBalance.Text = "$00,000.00";
            lblUserName.Text = "Nombre";
            lblNumWalletId.Text = "";
            lblNumTotalExpenses.Text = "$00,000.00";
            lblNumTotalIncomes.Text = "$00,000.00";
        }

        private void onNewMovement(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void onLogIn(object sender, EventArgs e)
        {
            stats.LoadStats();
            movements.LoadWalletData();
            this.LoadUserData();
        }

        private void onLogOut(object sender, EventArgs e)
        {
            this.IsLogged(false);
            stats.ResetDefaultText();
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            movements.newMovement += onNewMovement;
            this.logIn += onLogIn;
            this.logOut += onLogOut;
            this.IsLogged(false);
            try
            {
                Core.GetProjectConfig();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar el archivo config.json\n\n Por favor, verifique el archivo e intente nuevamente.", "ATENCIÓN");
                btnLogInLogOut.Enabled = false;
            }
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
                    this.logIn?.Invoke(this, EventArgs.Empty);
                    this.IsLogged(true);
                    
                }
            }
            else
            {
                Core.LogOut();
                this.logOut?.Invoke(this, EventArgs.Empty);
            }
        }
        private void IsLogged(bool isLogged)
        {
            btnExport.Enabled = isLogged;
            btnShowMovements.Enabled = isLogged;
            btnShowStats.Enabled = isLogged;
            btnSave.Enabled = isLogged;

            if (isLogged)
            {
                btnLogInLogOut.Text = "Cerrar sesión";
            }
            else
            {
                btnLogInLogOut.Text = "Iniciar sesión";
                this.stats.Visible = isLogged;
                this.movementsIsActive = isLogged;
                this.statsIsActive = isLogged;
                this.movements.Visible = isLogged;
                this.Clean();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbService.SaveMovements(Core.UserWallet);
            DbService.UpdateWalletBalance(Core.UserWallet);
        }



        private void pnlFormsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<User> usersList = DbService.GetUsers();
            List<Wallet> walletList = DbService.GetWallets();

            walletList.ForEach(wallet =>
            {
                wallet.MoneyMovements = DbService.GetMovements(wallet.Id);
            });

            BankSnapshot bankSnapshot = new BankSnapshot(usersList, walletList);

            Json<BankSnapshot> snapshotIO = new Json<BankSnapshot>();

            snapshotIO.Export(PathsGenerator.JsonPath, bankSnapshot.Id.ToString() + ".json", bankSnapshot);
        }
    }
}
