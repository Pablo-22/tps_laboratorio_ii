
namespace UI
{
    partial class frmWalletBase
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
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lblUsersList = new System.Windows.Forms.Label();
            this.btnVisualize = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblMovements = new System.Windows.Forms.Label();
            this.dataGridMovements = new System.Windows.Forms.DataGridView();
            this.lblAppName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 15;
            this.lstUsers.Location = new System.Drawing.Point(25, 279);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(256, 420);
            this.lstUsers.TabIndex = 1;
            // 
            // lblUsersList
            // 
            this.lblUsersList.AutoSize = true;
            this.lblUsersList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsersList.Location = new System.Drawing.Point(25, 249);
            this.lblUsersList.Name = "lblUsersList";
            this.lblUsersList.Size = new System.Drawing.Size(61, 18);
            this.lblUsersList.TabIndex = 2;
            this.lblUsersList.Text = "Usuarios";
            // 
            // btnVisualize
            // 
            this.btnVisualize.Location = new System.Drawing.Point(25, 705);
            this.btnVisualize.Name = "btnVisualize";
            this.btnVisualize.Size = new System.Drawing.Size(256, 35);
            this.btnVisualize.TabIndex = 4;
            this.btnVisualize.Text = "Visualizar";
            this.btnVisualize.UseVisualStyleBackColor = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClient.Location = new System.Drawing.Point(735, 246);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(59, 18);
            this.lblClient.TabIndex = 6;
            this.lblClient.Text = "Usuario:";
            this.lblClient.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(801, 237);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(375, 30);
            this.txtUserName.TabIndex = 7;
            // 
            // lblMovements
            // 
            this.lblMovements.AutoSize = true;
            this.lblMovements.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMovements.Location = new System.Drawing.Point(296, 249);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(90, 18);
            this.lblMovements.TabIndex = 8;
            this.lblMovements.Text = "Movimientos";
            // 
            // dataGridMovements
            // 
            this.dataGridMovements.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMovements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovements.Location = new System.Drawing.Point(296, 279);
            this.dataGridMovements.Name = "dataGridMovements";
            this.dataGridMovements.RowTemplate.Height = 25;
            this.dataGridMovements.Size = new System.Drawing.Size(880, 461);
            this.dataGridMovements.TabIndex = 10;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.Location = new System.Drawing.Point(25, 21);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(110, 42);
            this.lblAppName.TabIndex = 11;
            this.lblAppName.Text = "Wallet";
            // 
            // frmWalletBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.dataGridMovements);
            this.Controls.Add(this.lblMovements);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnVisualize);
            this.Controls.Add(this.lblUsersList);
            this.Controls.Add(this.lstUsers);
            this.Name = "frmWalletBase";
            this.Text = "frmTxtFileViewer";
            this.Load += new System.EventHandler(this.frmTxtFileViewer_Load);
            this.Controls.SetChildIndex(this.lstUsers, 0);
            this.Controls.SetChildIndex(this.lblUsersList, 0);
            this.Controls.SetChildIndex(this.btnVisualize, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.lblMovements, 0);
            this.Controls.SetChildIndex(this.dataGridMovements, 0);
            this.Controls.SetChildIndex(this.lblAppName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label lblUsersList;
        private System.Windows.Forms.Button btnVisualize;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblMovements;
        private System.Windows.Forms.DataGridView dataGridMovements;
        private System.Windows.Forms.Label lblAppName;
    }
}