
namespace UI
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblMensajeDeError = new System.Windows.Forms.Label();
            this.btnAutocomplete = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Location = new System.Drawing.Point(559, 420);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(250, 49);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Location = new System.Drawing.Point(559, 475);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(250, 49);
            this.btnRegistrarse.TabIndex = 3;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasenia.Location = new System.Drawing.Point(559, 310);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(250, 39);
            this.txtContrasenia.TabIndex = 1;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(559, 230);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(250, 39);
            this.txtNombreDeUsuario.TabIndex = 0;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(559, 204);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(250, 23);
            this.lblNombreDeUsuario.TabIndex = 4;
            this.lblNombreDeUsuario.Text = "Nombre de usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContrasenia.Location = new System.Drawing.Point(559, 284);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(250, 23);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblMensajeDeError
            // 
            this.lblMensajeDeError.AutoSize = true;
            this.lblMensajeDeError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeDeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDeError.Location = new System.Drawing.Point(559, 361);
            this.lblMensajeDeError.Name = "lblMensajeDeError";
            this.lblMensajeDeError.Size = new System.Drawing.Size(0, 15);
            this.lblMensajeDeError.TabIndex = 6;
            // 
            // btnAutocomplete
            // 
            this.btnAutocomplete.FlatAppearance.BorderSize = 0;
            this.btnAutocomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocomplete.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAutocomplete.Location = new System.Drawing.Point(559, 555);
            this.btnAutocomplete.Name = "btnAutocomplete";
            this.btnAutocomplete.Size = new System.Drawing.Size(250, 23);
            this.btnAutocomplete.TabIndex = 4;
            this.btnAutocomplete.Text = "Rellenar campos";
            this.btnAutocomplete.UseVisualStyleBackColor = true;
            this.btnAutocomplete.Click += new System.EventHandler(this.btnAutocomplete_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Calibri Light", 41F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(546, 113);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(274, 67);
            this.lblBienvenido.TabIndex = 8;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1321, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 21);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "⚫";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnAutocomplete);
            this.Controls.Add(this.lblMensajeDeError);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnAcceder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblMensajeDeError;
        private System.Windows.Forms.Button btnAutocomplete;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label btnExit;
    }
}