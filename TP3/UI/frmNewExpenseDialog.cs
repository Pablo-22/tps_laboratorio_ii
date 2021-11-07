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

namespace UI
{
    public partial class frmNewExpenseDialog : frmDialogBase
    {
        private Wallet selectedWallet;
        private User selectedUser;
        private Movement.eType type;

        public Wallet SelectedWallet { get => selectedWallet; set => selectedWallet = value; }
        public User SelectedUser { get => selectedUser; set => selectedUser = value; }
        public Movement.eType Type { get => type; }

        public frmNewExpenseDialog()
        {
            InitializeComponent();
        }

        public frmNewExpenseDialog(User selectedUser, Wallet selectedWallet, Movement.eType isExpense): this()
        {
            this.selectedUser = selectedUser;
            this.selectedWallet = selectedWallet;
            this.type = isExpense;
        }

        private void loadWalletData()
        {
            float nextBalance = this.SelectedWallet.Balance;
            if (type == Movement.eType.Gasto)
            {
                if (SelectedWallet.Balance >= (float)this.numAmount.Value)
                {
                    nextBalance = this.SelectedWallet.Balance - (float)this.numAmount.Value;
                }
            }
            else
            {
                nextBalance = this.SelectedWallet.Balance + (float)this.numAmount.Value;
            }
            this.lblNumActualBalance.Text = this.SelectedWallet.Balance.ToString();
            this.lblNumNewBalance.Text = nextBalance.ToString();
        }

        private void frmNewExpenseDialog_Load(object sender, EventArgs e)
        {
            if (type == Movement.eType.Gasto)
            {
                numAmount.Maximum = (decimal)selectedWallet.Balance;
            }
            else
            {
                numAmount.Maximum = 9999999;
            }
            this.loadWalletData();
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            this.loadWalletData();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            float amount = (float)numAmount.Value;
            this.SelectedWallet.SaveNewMovement(amount, dateMovementDate.Value, Type);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
