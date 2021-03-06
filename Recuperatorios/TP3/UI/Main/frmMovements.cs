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

        /// <summary>
        /// Crea un user control ucMovement por cada movimiento de la wallet, con los datos del mismo.
        /// </summary>
        public void LoadWalletData()
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

        /// <summary>
        /// Añade un movimiento a la wallet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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