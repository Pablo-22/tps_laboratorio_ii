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
        /// Carga los datos del usuario en los labels del form
        /// </summary>
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

        /// <summary>
        /// Carga los eventos con los métodos correspondientes
        /// Importa los usuarios y wallets del banco desde un archivo .json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
            movements.newMovement += onNewMovement;
            this.logIn += onLogIn;
            this.logOut += onLogOut;
            this.IsLogged(false);

            BankSnapshot snapshot = new BankSnapshot(Bank.Users, Bank.Wallets);

            Json<BankSnapshot> snapshotIO = new Json<BankSnapshot>();
            try
            {
                snapshotIO.Import(PathsGenerator.JsonPath, snapshot.Id.ToString() + ".json", ref snapshot);
                Bank.LoadFromSnapshot(snapshot);
            }
            catch
            {
                try
                {
                    if (!File.Exists("-1.json"))
                    {
                        throw new PathDoNotExistException();
                    }
                    string dataCollected = File.ReadAllText("-1.json");
                    snapshot = JsonSerializer.Deserialize<BankSnapshot>(dataCollected);
                    Bank.LoadFromSnapshot(snapshot);
                }
                catch
                {
                    Bank.Hardcode();
                }
            }
        }

        /// <summary>
        /// Muestra el formulario de movimientos en el panel del frmMainDashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Muestra el formulario de estadísticas en el panel del frmMainDashboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Funciona como toggle button. Inicia sesión o cierra sesión. Invoca un evento diferente en cada caso.
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
                    this.IsLogged(true);
                    this.LoadUserData();
                    this.logIn.Invoke(this, null);
                }
            }
            else
            {
                Core.LogOut();
                this.IsLogged(false);
                this.logOut.Invoke(this, null);
            }
        }

        /// <summary>
        /// Modifica el estado de los controles, según el boolean recibido por parámetro.
        /// </summary>
        /// <param name="isLogged"></param>
        private void IsLogged(bool isLogged)
        {
            if (isLogged)
            {
                btnShowMovements.Enabled = true;
                btnShowStats.Enabled = true;
                btnLogInLogOut.Text = "Cerrar sesión";
                btnSave.Enabled = true;
            }
            else
            {
                btnShowMovements.Enabled = false;
                btnShowStats.Enabled = false;
                btnLogInLogOut.Text = "Iniciar sesión";
                btnSave.Enabled = false;
                this.movements.Visible = false;
                this.stats.Visible = false;
                this.movementsIsActive = false;
                this.statsIsActive = false;
            }
        }

        
        /// <summary>
        /// Exporta un archivo que representa un snapshot del banco.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            BankSnapshot snapshot = new BankSnapshot(Bank.Users, Bank.Wallets);

            Json<BankSnapshot> walletSnapshot = new Json<BankSnapshot>();

            walletSnapshot.Export(PathsGenerator.JsonPath, snapshot.Id.ToString() + ".json", snapshot);
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
