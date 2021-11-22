using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using System.Windows.Forms;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.InputOutput;
using System.Threading;

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
        /// Carga los informes generales sobre los gastos 
        /// e ingresos de la wallet del usuario logueado
        /// </summary>
        public void LoadHeaderValues()
        {

            bool nowIsMore;
            bool initialValueIsNull;
            if (Core.UserWallet != null)
            {
                lblMonthName.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
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
        }

        /// <summary>
        /// Carga los informes de gastos según categorías de la wallet del usuario logueado
        /// utiliza task. Genera un delay de 5 segundos para simular tiempo de procesamiento.
        /// </summary>
        /// <returns></returns>
        public Task LoadCategoriesStats()
        {
            return Task.Run(() =>
            {
                this.ResetDefaultText();
                int index = 0;
                int x = 0;
                int y = 0;
                float monthTotal = 0;
                float previousMonthTotal = 0;
                float percentage = 0;
                bool nowIsMore;
                bool initialValueIsNull;

                Thread.Sleep(5000);
                if (pnlStats.InvokeRequired)
                {
                    pnlStats.BeginInvoke((MethodInvoker)delegate()
                    {
                        pnlStats.Controls.Clear();
                        Bank.ExpensesCategories.ForEach(category =>
                        {
                            if (Core.UserWallet != null)
                            {
                                monthTotal = Core.UserWallet.getMonthTotal(DateTime.Now, Movement.eType.Gasto, category);
                                percentage = Core.UserWallet.CompareNowWithPreviousMonth(Movement.eType.Gasto, category, out nowIsMore, out initialValueIsNull);
                                previousMonthTotal = Core.UserWallet.getMonthTotal(DateTime.Now.AddMonths(-1), Movement.eType.Gasto, category);

                                pnlStats.Controls.Add(new ucStat(category, monthTotal, previousMonthTotal, percentage, nowIsMore, initialValueIsNull));
                                pnlStats.Controls[index].Location = new Point(x, y);
                                y += 135;
                                index++;
                            }
                        });
                    });
                }
            });
        }

        /// <summary>
        /// Resetea los labels del formulario.
        /// </summary>
        /// <returns></returns>
        public Task ResetDefaultText()
        {
            return Task.Run(() =>
            {
                int index = 0;
                int x = 0;
                int y = 0;

                if (lblIncomesPercentage.InvokeRequired)
                {
                    lblIncomesPercentage.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblIncomesPercentage.Text = "Cargando...";
                    });
                }

                if (lblMonthName.InvokeRequired)
                {
                    lblMonthName.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblMonthName.Text = "Cargando...";
                    });
                }

                if (lblExpensesPercentage.InvokeRequired)
                {
                    lblExpensesPercentage.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblExpensesPercentage.Text = "Cargando...";
                    });
                }


                if (pnlStats.InvokeRequired)
                {
                    pnlStats.BeginInvoke((MethodInvoker)delegate ()
                    {
                        pnlStats.Controls.Clear();
                        Bank.ExpensesCategories.ForEach(category =>
                        {
                            pnlStats.Controls.Add(new ucStat());
                            pnlStats.Controls[index].Location = new Point(x, y);
                            y += 135;
                            index++;
                        });
                    });
                }

            });
        }

        private void OnNewMovement(object sender, EventArgs e)
        {
            LoadStats();
        }

        /// <summary>
        /// Carga primero los informes de las categorías
        /// y luego los generales.
        /// </summary>
        public async void LoadStats()
        {
            await LoadCategoriesStats();
            LoadHeaderValues();
        }


        private void frmStats_Load(object sender, EventArgs e)
        {
            movements.newMovement += OnNewMovement;
            LoadStats();
        }
    }
}
