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

        /// <summary>
        /// Carga en el formulario principal los datos del usuario logueado.
        /// </summary>
        private void LoadUserData()
        {
            lblNumActualBalance.Text = Core.UserWallet.Balance.ToString("$##,##,##,##0.00");
            lblUserName.Text = Core.CurrentUser.Name;
            lblNumWalletId.Text = Core.UserWallet.Id.ToString();
            lblNumTotalExpenses.Text = Bank.GetTotalExpensesAmount().ToString("$##,##,##,##0.00");
            lblNumTotalIncomes.Text = Bank.GetTotalIncomesAmount().ToString("$##,##,##,##0.00");
        }

        /// <summary>
        /// Limpia el formulario.
        /// </summary>
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

            MessageBox.Show("Probando conexión con la base de datos...\n\nSi nota una demora en este proceso, " +
                "revise la ruta de conexión a la base de datos", "Cargando...");

            try
            {
                Core.GetProjectConfig();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar correctamente el archivo config.json\n\n Por favor, verifíquelo e intente nuevamente.", "ATENCIÓN");
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

        /// <summary>
        /// Inicia o cierra sesión según el estado del botón.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Setea el formulario para el status logueado o sin loguear
        /// </summary>
        /// <param name="isLogged"></param>
        private void IsLogged(bool isLogged)
        {
            btnExport.Enabled = isLogged;
            btnShowMovements.Enabled = isLogged;
            btnShowStats.Enabled = isLogged;
            btnSave.Enabled = isLogged;

            if (isLogged)
            {
                btnLogInLogOut.Text = "Cerrar sesión";
                lblTips.Text = "Seleccione una opción para visualizar la información.";
            }
            else
            {
                btnLogInLogOut.Text = "Iniciar sesión";
                this.stats.Visible = isLogged;
                this.movementsIsActive = isLogged;
                this.statsIsActive = isLogged;
                this.movements.Visible = isLogged;
                lblTips.Text = "Inicie sesión para comenzar.";

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

        /// <summary>
        /// Exporta los datos del usuario logueado,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            UserSnapshot userSnapshot = new UserSnapshot(Core.CurrentUser.Name, Core.UserWallet);

            Json<UserSnapshot> jsonSnapshot = new Json<UserSnapshot>();

            try
            {
                jsonSnapshot.Export(PathsGenerator.JsonPath, PathsGenerator.jsonGenerateFileName(userSnapshot.Name, ".json"), userSnapshot);
                MessageBox.Show("Se ha exportado el archivo con los datos del usuario. Consulte la carpeta 'Wallet' en Desktop.", "Operación exitosa", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido exportar el archivo con los datos del usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.DarkRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Red;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



/*
    Bank.Users = DbService.GetUsers();
    Bank.Wallets = DbService.GetWallets();

    Bank.Wallets.ForEach(wallet =>
    {
        wallet.MoneyMovements = DbService.GetMovements(wallet.Id);
    });

    BankSnapshot bankSnapshot = new BankSnapshot(Bank.Users, Bank.Wallets);

    Json<BankSnapshot> snapshotIO = new Json<BankSnapshot>();

    snapshotIO.Export(PathsGenerator.JsonPath, bankSnapshot.Id.ToString() + ".json", bankSnapshot); 
*/