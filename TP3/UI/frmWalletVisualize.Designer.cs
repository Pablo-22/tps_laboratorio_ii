
namespace UI
{
    partial class frmWalletVisualize
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
            this.btnNewMovement = new System.Windows.Forms.Button();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstUsers.Size = new System.Drawing.Size(256, 465);
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.Location = new System.Drawing.Point(296, 32);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(296, 58);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Size = new System.Drawing.Size(445, 30);
            // 
            // btnNewMovement
            // 
            this.btnNewMovement.Location = new System.Drawing.Point(25, 17);
            this.btnNewMovement.Name = "btnNewMovement";
            this.btnNewMovement.Size = new System.Drawing.Size(150, 42);
            this.btnNewMovement.TabIndex = 11;
            this.btnNewMovement.Text = "Nuevo ingreso";
            this.btnNewMovement.UseVisualStyleBackColor = true;
            this.btnNewMovement.Click += new System.EventHandler(this.btnNewMovement_Click);
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.Location = new System.Drawing.Point(25, 69);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(150, 42);
            this.btnNewExpense.TabIndex = 13;
            this.btnNewExpense.Text = "Nuevo gasto";
            this.btnNewExpense.UseVisualStyleBackColor = true;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(296, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(295, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 40);
            this.label3.TabIndex = 17;
            this.label3.Text = "$";
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBalance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBalance.Location = new System.Drawing.Point(337, 165);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(404, 46);
            this.txtBalance.TabIndex = 18;
            this.txtBalance.Text = "Saldo";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmWalletVisualize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewExpense);
            this.Controls.Add(this.btnNewMovement);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmWalletVisualize";
            this.Text = "frmWalletVisualize";
            this.Load += new System.EventHandler(this.frmWalletVisualize_Load);
            this.Controls.SetChildIndex(this.lblUsersList, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.lblMovements, 0);
            this.Controls.SetChildIndex(this.lstUsers, 0);
            this.Controls.SetChildIndex(this.btnNewMovement, 0);
            this.Controls.SetChildIndex(this.btnNewExpense, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtBalance, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewMovement;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnSave;
    }
}