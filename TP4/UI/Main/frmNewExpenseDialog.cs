using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using System.Windows.Forms;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.InputOutput;

namespace UI
{
    public partial class frmNewExpenseDialog : frmDialogBase
    {

        public frmNewExpenseDialog()
        {
            InitializeComponent();
        }

        private void setCategories()
        {
            cmbCategory.Items.Clear();
            if ((Movement.eType)cmbType.SelectedItem == Movement.eType.Gasto)
            {
                numAmount.Maximum = (decimal)Core.UserWallet.Balance;
                for (int i = 0; i < Bank.ExpensesCategories.Count; i++)
                {
                    cmbCategory.Items.Add(Bank.ExpensesCategories[i]);
                }
            }
            else
            {
                numAmount.Maximum = 9999999;
                for (int i = 0; i < Bank.IncomesCategories.Count; i++)
                {
                    cmbCategory.Items.Add(Bank.IncomesCategories[i]);

                }
            }
        }

        private void setTypeComboBox()
        {
            var types = Enum.GetNames(typeof(Movement.eType)).Length;

            for (int i = 0; i < types; i++)
            {
                cmbType.Items.Add((Movement.eType)i);
            }

            cmbType.SelectedIndex = 0;
        }

        private void loadWalletData()
        {
            float nextBalance = Core.UserWallet.Balance;
            if ( (Movement.eType)cmbType.SelectedItem == Movement.eType.Gasto )
            {
                if (Core.UserWallet.Balance >= (float)this.numAmount.Value)
                {
                    nextBalance = Core.UserWallet.Balance - (float)this.numAmount.Value;
                }
            }
            else
            {
                nextBalance = Core.UserWallet.Balance + (float)this.numAmount.Value;
            }
            this.lblNumActualBalance.Text = Core.UserWallet.Balance.ToString();
            this.lblNumNewBalance.Text = nextBalance.ToString();
        }

        private void frmNewExpenseDialog_Load(object sender, EventArgs e)
        {
            setTypeComboBox();
            this.loadWalletData();
            setCategories();
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            this.loadWalletData();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            float amount = (float)numAmount.Value;
            Core.UserWallet.SaveNewMovement(amount, dateMovementDate.Value, (Movement.eType)cmbType.SelectedItem, cmbCategory.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCategories();
            loadWalletData();
        }
    }
}
