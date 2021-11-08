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
using Entities;
using InputOutputLibrary;

namespace UI
{
    public partial class frmWalletVisualize : frmWalletBase
    {
        private Wallet selectedWallet;
        private User selectedUser;

        public Wallet SelectedWallet { get => selectedWallet; set => selectedWallet = value; }
        public User SelectedUser { get => selectedUser; set => selectedUser = value; }

        public frmWalletVisualize()
        {
            InitializeComponent();
        }

        private void LoadBankSnapshot()
        {
            BankSnapshot snapshot = new BankSnapshot(Bank.Users, Bank.Wallets);

            Json<BankSnapshot> snapshotIO = new Json<BankSnapshot>();

            string path = PathsGenerator<BankSnapshot>.jsonGeneratePath(snapshot);
            try
            {
                snapshotIO.Import(path, out snapshot);
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

        private void frmWalletVisualize_Load(object sender, EventArgs e)
        {
            LoadBankSnapshot();
            this.lstUsers.DataSource = Bank.Users;
            this.lstUsers.Refresh();
        } 

        private void loadDataGrid()
        {
            dataGridMovements.Rows.Clear();
            this.selectedWallet.MoneyMovements.ForEach(x =>
            {
                int n = dataGridMovements.Rows.Add();

                dataGridMovements.Rows[n].Cells[0].Value = x.PurchaseDate;
                dataGridMovements.Rows[n].Cells[1].Value = "$" + x.Amount;
                dataGridMovements.Rows[n].Cells[2].Value = x.Type;
            });
            dataGridMovements.Sort(dataGridMovements.Columns[0], ListSortDirection.Descending);
        }

        private void loadWalletData()
        {
            this.txtUserName.Text = this.SelectedUser.Name;
            this.txtBalance.Text = this.SelectedWallet.Balance.ToString();

            loadDataGrid();
            loadQuerys();
        }

        private void loadQuerys()
        {
            lblTotalMovements.Text = Bank.GetTotalMovements().ToString();
            lblTodayMovements.Text = Bank.GetTodayMovements().ToString();

            StringBuilder usersWithBiggestMovementInfo = new StringBuilder();
            List<User> usersWithBiggestMovement = Bank.GetUsersWithBiggestMovementAmount();
            usersWithBiggestMovement.ForEach(user =>
            {
                usersWithBiggestMovementInfo.Append(user.ToString());
                usersWithBiggestMovementInfo.Append("  ");
            });
            lblUserWithBiggestMovement.Text = usersWithBiggestMovementInfo.ToString();


            StringBuilder usersWithMoreMovementsInfo = new StringBuilder();
            List<User> usersWithMoreMovements = Bank.GetUsersWithMoreMovements();
            usersWithMoreMovements.ForEach(user =>
            {
                usersWithMoreMovementsInfo.Append(user.ToString());
                usersWithMoreMovementsInfo.Append("  ");
            });
            lblUserWithMoreMovements.Text = usersWithMoreMovementsInfo.ToString();

            lblBiggestIncome.Text = "$" + Bank.getBiggestIncomeAmount().ToString();
        }

        private void btnNewMovement_Click(object sender, EventArgs e)
        {
            if (Bank.Users.Count > 0 && SelectedWallet.Balance > 0)
            {
                frmNewExpenseDialog newExpense = new frmNewExpenseDialog(SelectedUser, SelectedWallet, Movement.eType.Ingreso);
                newExpense.ShowDialog();
                if (newExpense.DialogResult == DialogResult.OK)
                {
                    this.loadWalletData();
                }
            }
        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            if (Bank.Users.Count > 0 && SelectedWallet.Balance > 0)
            {
                frmNewExpenseDialog newExpense = new frmNewExpenseDialog(SelectedUser, SelectedWallet, Movement.eType.Gasto);
                newExpense.ShowDialog();
                if (newExpense.DialogResult == DialogResult.OK)
                {
                    this.loadWalletData();
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            BankSnapshot snapshot = new BankSnapshot(Bank.Users, Bank.Wallets);

            Json<BankSnapshot> walletSnapshot = new Json<BankSnapshot>();

            string path = PathsGenerator<BankSnapshot>.jsonGeneratePath(snapshot);
            walletSnapshot.Export(path, snapshot);
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedUser = (User)lstUsers.SelectedItem;
            if (SelectedUser.IdWallet > -1)
            {
                SelectedWallet = Bank.Wallets[Bank.SearchWalletIndexById(SelectedUser.IdWallet)];
                loadWalletData();
            }
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
