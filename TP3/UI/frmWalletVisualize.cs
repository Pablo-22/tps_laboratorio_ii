using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            catch (Exception)
            {
                Bank.Hardcode();
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
                dataGridMovements.Rows[n].Cells[1].Value = x.Amount;
                dataGridMovements.Rows[n].Cells[2].Value = x.Type;
            });
        }

        private void loadWalletData()
        {
            this.txtUserName.Text = this.SelectedUser.Name;
            this.txtBalance.Text = this.SelectedWallet.Balance.ToString();

            loadDataGrid();
        }

        private void btnNewMovement_Click(object sender, EventArgs e)
        {
            frmNewExpenseDialog newExpense = new frmNewExpenseDialog(selectedUser, selectedWallet, Movement.eType.Ingreso);
            newExpense.ShowDialog();
            if (newExpense.DialogResult == DialogResult.OK)
            {
                this.loadWalletData();
            }
        }

        private void btnNewExpense_Click(object sender, EventArgs e)
        {
            frmNewExpenseDialog newExpense = new frmNewExpenseDialog(selectedUser, selectedWallet, Movement.eType.Gasto);
            newExpense.ShowDialog();
            if (newExpense.DialogResult == DialogResult.OK)
            {
                this.loadWalletData();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            /*Xml<Wallet> walletSnapshot = new Xml<Wallet>();

            string path = PathsGenerator<Wallet>.xmlGeneratePath(SelectedWallet);
            walletSnapshot.Export(path, SelectedWallet);*/

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
    }
}
