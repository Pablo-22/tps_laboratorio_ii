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

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text != "" && txtContrasenia.Text != "")
            {
                try
                {
                    Core.LogIn(txtNombreDeUsuario.Text, txtContrasenia.Text);
                    this.DialogResult = DialogResult.OK;
                }
                catch(InvalidUserException)
                {
                    lblMensajeDeError.Text = "* Usuario o contraseña incorrecto/s";
                }
                catch(Exception)
                {
                    lblMensajeDeError.Text = "* Ha habido un error";
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasenia.Text) == false && string.IsNullOrEmpty(txtNombreDeUsuario.Text) == false)
            {
                try
                {
                    Core.SignIn(txtNombreDeUsuario.Text, txtContrasenia.Text);
                    MessageBox.Show("Usuario registrado exitosamente.\nAhora ingrese sus credenciales para acceder.", "¡Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                }
                catch
                {
                    MessageBox.Show("No se ha podido completar el registro. Es posible que haya ingresado datos inválidos " +
                        "o que ya exista un usuario con ese nombre.\nIntente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
