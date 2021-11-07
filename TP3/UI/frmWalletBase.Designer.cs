
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lblUsersList = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblMovements = new System.Windows.Forms.Label();
            this.dataGridMovements = new System.Windows.Forms.DataGridView();
            this.movementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lstUsers.Size = new System.Drawing.Size(256, 450);
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
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClient.Location = new System.Drawing.Point(300, 204);
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
            this.txtUserName.Location = new System.Drawing.Point(366, 195);
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
            this.dataGridMovements.AllowUserToAddRows = false;
            this.dataGridMovements.AllowUserToDeleteRows = false;
            this.dataGridMovements.AllowUserToResizeColumns = false;
            this.dataGridMovements.AllowUserToResizeRows = false;
            this.dataGridMovements.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMovements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMovements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movementDate,
            this.amount,
            this.Type});
            this.dataGridMovements.Location = new System.Drawing.Point(296, 279);
            this.dataGridMovements.Name = "dataGridMovements";
            this.dataGridMovements.ReadOnly = true;
            this.dataGridMovements.RowHeadersVisible = false;
            this.dataGridMovements.RowHeadersWidth = 51;
            this.dataGridMovements.RowTemplate.Height = 25;
            this.dataGridMovements.Size = new System.Drawing.Size(495, 461);
            this.dataGridMovements.StandardTab = true;
            this.dataGridMovements.TabIndex = 10;
            // 
            // movementDate
            // 
            this.movementDate.HeaderText = "Fecha";
            this.movementDate.MinimumWidth = 6;
            this.movementDate.Name = "movementDate";
            this.movementDate.ReadOnly = true;
            this.movementDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.movementDate.Width = 200;
            // 
            // amount
            // 
            this.amount.HeaderText = "Monto";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 145;
            // 
            // frmWalletBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.dataGridMovements);
            this.Controls.Add(this.lblMovements);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblUsersList);
            this.Controls.Add(this.lstUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWalletBase";
            this.Text = "frmTxtFileViewer";
            this.Load += new System.EventHandler(this.frmTxtFileViewer_Load);
            this.Controls.SetChildIndex(this.lstUsers, 0);
            this.Controls.SetChildIndex(this.lblUsersList, 0);
            this.Controls.SetChildIndex(this.lblClient, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.lblMovements, 0);
            this.Controls.SetChildIndex(this.dataGridMovements, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ListBox lstUsers;
        protected System.Windows.Forms.Label lblUsersList;
        protected System.Windows.Forms.Label lblClient;
        protected System.Windows.Forms.TextBox txtUserName;
        protected System.Windows.Forms.Label lblMovements;
        protected System.Windows.Forms.DataGridView dataGridMovements;
        private System.Windows.Forms.DataGridViewTextBoxColumn movementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}