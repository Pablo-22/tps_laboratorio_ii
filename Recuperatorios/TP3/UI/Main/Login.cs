using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.InputOutput;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombreDeUsuario.Text = "";
            txtContrasenia.Text = "";
        }

        /// <summary>
        /// Inicia sesión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text != "" && txtContrasenia.Text != "")
            {
                try
                {
                    Core.LogIn(txtNombreDeUsuario.Text, txtContrasenia.Text);
                    this.DialogResult = DialogResult.OK;
                }
                catch
                {
                    lblMensajeDeError.Text = "*Usuario o contraseña incorrecto/s";
                }
            }
        }

        private void btnAutocomplete_Click(object sender, EventArgs e)
        {
            txtNombreDeUsuario.Text = "Pablo";
            txtContrasenia.Text = "12345";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Registra a un usuario. Comprueba que el nombre de usuario no exista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasenia.Text) == false && string.IsNullOrEmpty(txtNombreDeUsuario.Text) == false)
            {
                if (Core.SignIn(txtNombreDeUsuario.Text, txtContrasenia.Text) == true)
                {
                    MessageBox.Show("Usuario registrado exitosamente.\nAhora ingrese sus credenciales para acceder.", "¡Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("No se ha podido completar el registro. Es posible que haya ingresado datos inválidos " +
                        "o que ya exista un usuario con ese nombre.\nIntente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.DarkRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Red;
        }
    }
}
