using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using InputOutputLibrary;

namespace UI
{
    public partial class frmStats : Form
    {
        public frmMovements movements;

        public frmStats()
        {
            InitializeComponent();
        }

        public frmStats(frmMovements movements)
        {
            InitializeComponent();
            this.movements = movements;
        }

        private void loadHeaderValues()
        {
            lblMonthName.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            bool nowIsMore;
            lblExpensesPercentage.Text = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Gasto, out nowIsMore).ToString() + "%";
            if (nowIsMore)
            {
                lblExpensesMoreOrLess.Text = "más que el mes pasado";
            }
            else
            {
                lblExpensesMoreOrLess.Text = "menos que el mes pasado";
            }

            lblIncomesPercentage.Text = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Ingreso, out nowIsMore).ToString() + "%";
            if (nowIsMore)
            {
                lblIncomesMoreOrLess.Text = "más que el mes pasado";
            }
            else
            {
                lblIncomesMoreOrLess.Text = "menos que el mes pasado";
            }
        }

        private void onNewMovement(object sender, EventArgs e)
        {
            loadHeaderValues();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            movements.newMovement += onNewMovement;

            loadHeaderValues();


            pnlStats.Controls.Clear();
            int index = 0;
            int x = 0;
            int y = 0;

            Bank.ExpensesCategories.ForEach(movement =>
            {
                pnlStats.Controls.Add(new ucStat());
                pnlStats.Controls[index].Location = new Point(x, y);
                y += 80;
                index++;
            });
        }
    }
}
