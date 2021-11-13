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
    public partial class frmStats : Form
    {
        private Wallet selectedWallet;
        private User selectedUser;

        public Wallet SelectedWallet { get => selectedWallet; set => selectedWallet = value; }
        public User SelectedUser { get => selectedUser; set => selectedUser = value; }

        public frmStats()
        {
            InitializeComponent();
        }

        public frmStats(User selectedUser, Wallet selectedWallet) : this()
        {
            this.selectedUser = selectedUser;
            this.selectedWallet = selectedWallet;
        }


        private void frmStats_Load(object sender, EventArgs e)
        {

        }
    }
}
