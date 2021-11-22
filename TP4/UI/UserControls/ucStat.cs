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
using Entities.InputOutput;
using Entities.WalletEntities;
using Entities.SystemCore;

namespace UI
{
    public partial class ucStat : UserControl
    {
        public ucStat()
        {
            InitializeComponent();
            lblAmount.Text = "Cargando...";
            lblPercentage.Text = "Cargando...";
            lblThanPreviousMonth.Text = "Cargando...";
            lblCategory.Text = "Cargando...";
        }

        public ucStat(string category, float monthTotal, float previousMonthAmount, float percentage, bool nowIsMore, bool initialValueIsNull) : this()
        {
            lblCategory.Text = category;
            lblAmount.Text = monthTotal.ToString("$##,##,##,##0.00");
            lblPreviousMonthAmount.Text = previousMonthAmount.ToString("$##,##,##,##0.00");
            lblPercentage.Text = percentage.ToString("0.00");
            if (initialValueIsNull)
            {
                lblPercentage.Text += "%";
            }
            else
            {
                lblPercentage.Text = "$" + lblPercentage.Text;
            }

            if (nowIsMore)
            {
                lblThanPreviousMonth.Text = "más que el mes pasado";
            }
            else
            {
                lblThanPreviousMonth.Text = "menos que el mes pasado";
            }
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void ucStat_Load(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
