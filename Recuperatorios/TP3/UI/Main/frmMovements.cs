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
    public partial class frmMovements : Form
    {
        public event EventHandler newMovement;


        public frmMovements()
        {
            InitializeComponent();
        }

        private void frmMovements_Load(object sender, EventArgs e)
        {

            LoadWalletData();
        }

        private void LoadWalletData()
        {
            pnlMovements.Controls.Clear();
            int index = 0;
            int x = 0;
            int y = 0;

            Core.UserWallet.SortMovementsByMoreRecentDate();
            Core.UserWallet.MoneyMovements.ForEach(movement =>
            {
                pnlMovements.Controls.Add(new ucMovement(movement.PurchaseDate, movement.Amount, movement.Type, movement.Category));
                pnlMovements.Controls[index].Location = new Point(x, y);
                y += 80;
                index++;
            });
        }

        private void btnAddMovement_Click(object sender, EventArgs e)
        {
            frmNewExpenseDialog newExpense = new frmNewExpenseDialog();
            newExpense.ShowDialog();
            if (newExpense.DialogResult == DialogResult.OK)
            {
                this.LoadWalletData();
                this.newMovement?.Invoke(this, EventArgs.Empty);
            }
        }





        // UI EFFECTS
        private void btnAddMovement_MouseLeave(object sender, EventArgs e)
        {
            btnAddMovement.BackgroundImage = new Bitmap(Properties.Resources.AddButton);
        }

        private void btnAddMovement_MouseMove(object sender, MouseEventArgs e)
        {
            btnAddMovement.BackgroundImage = new Bitmap(Properties.Resources.AddButtonHover);
        }
    }
}