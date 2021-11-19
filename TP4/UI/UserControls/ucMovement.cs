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
    public partial class ucMovement : UserControl
    {
        public ucMovement()
        {
            InitializeComponent();
        }

        public ucMovement(DateTime movementDate, float amount, Movement.eType type, string category) : this()
        {
            lblAmount.Text = amount.ToString();
            lblDate.Text = movementDate.ToString();
            lblType.Text = type.ToString();
            lblCategory.Text = category;
        }

        private void ucMovement_Load(object sender, EventArgs e)
        {

        }
    }
}
