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
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.InputOutput;


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

        /// <summary>
        /// Carga los valores de los controles del header.
        /// </summary>
        private void loadHeaderValues()
        {
            lblMonthName.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            bool nowIsMore;
            bool initialValueIsNull;
            lblExpensesPercentage.Text = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Gasto, null, out nowIsMore, out initialValueIsNull).ToString("0.00");
            
            if (initialValueIsNull)
            {
                float auxPercentage = float.Parse(lblExpensesPercentage.Text);
                lblExpensesPercentage.Text += "%";
            }
            else
            {
                lblExpensesPercentage.Text = "$" + lblExpensesPercentage.Text;
            }

            if (nowIsMore)
            {
                lblExpensesMoreOrLess.Text = "más que el mes pasado";
            }
            else
            {
                lblExpensesMoreOrLess.Text = "menos que el mes pasado";
            }

            lblIncomesPercentage.Text = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Ingreso,null, out nowIsMore, out initialValueIsNull).ToString("0.00");
            if (initialValueIsNull)
            {
                lblIncomesPercentage.Text += "%";
            }
            else
            {
                lblIncomesPercentage.Text = "$" + lblIncomesPercentage.Text;
            }

            if (nowIsMore)
            {
                lblIncomesMoreOrLess.Text = "más que el mes pasado";
            }
            else
            {
                lblIncomesMoreOrLess.Text = "menos que el mes pasado";
            }
        }

        /// <summary>
        /// Carga los valores de los user controls con los porcentajes.
        /// </summary>
        private void loadStats()
        {
            pnlStats.Controls.Clear();
            int index = 0;
            int x = 0;
            int y = 0;
            float monthTotal = 0;
            float percentage = 0;
            bool nowIsMore;
            bool initialValueIsNull;

            Bank.ExpensesCategories.ForEach(category =>
            {
                monthTotal = Core.UserWallet.getMonthTotal(DateTime.Now, Movement.eType.Gasto, category);
                percentage = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Gasto, category, out nowIsMore, out initialValueIsNull);

                pnlStats.Controls.Add(new ucStat(category, monthTotal, percentage, nowIsMore, initialValueIsNull));
                pnlStats.Controls[index].Location = new Point(x, y);
                y += 120;
                index++;
            });
        }

        private void onNewMovement(object sender, EventArgs e)
        {
            loadHeaderValues();
            loadStats();
        }

        /// <summary>
        /// Resetea los labels del formulario.
        /// </summary>
        /// <returns></returns>
        public void ResetDefaultText()
        {
            int index = 0;
            int x = 0;
            int y = 0;

            lblIncomesPercentage.Text = "Cargando...";

            lblMonthName.Text = "Cargando...";

            lblExpensesPercentage.Text = "Cargando...";

            pnlStats.Controls.Clear();
            Bank.ExpensesCategories.ForEach(category =>
            {
                pnlStats.Controls.Add(new ucStat());
                pnlStats.Controls[index].Location = new Point(x, y);
                y += 135;
                index++;
            });
        }

        public void LoadStats()
        {
            loadStats();
            loadHeaderValues();
        }

        private void frmStats_Load(object sender, EventArgs e)
        {
            movements.newMovement += onNewMovement;

            loadHeaderValues();
            loadStats();
        }
    }
}
