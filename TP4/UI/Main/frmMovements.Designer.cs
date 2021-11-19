
namespace UI
{
    partial class frmMovements
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlMovements = new System.Windows.Forms.Panel();
            this.btnAddMovement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(19, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(178, 37);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Movimientos";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(49, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.White;
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.ForeColor = System.Drawing.Color.Silver;
            this.lblAmount.Location = new System.Drawing.Point(248, 80);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Monto";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.Silver;
            this.lblType.Location = new System.Drawing.Point(419, 80);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 25);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipo";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.White;
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.ForeColor = System.Drawing.Color.Silver;
            this.lblCategory.Location = new System.Drawing.Point(587, 80);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 25);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Categoría";
            // 
            // pnlMovements
            // 
            this.pnlMovements.AutoScroll = true;
            this.pnlMovements.Location = new System.Drawing.Point(23, 118);
            this.pnlMovements.Name = "pnlMovements";
            this.pnlMovements.Size = new System.Drawing.Size(941, 346);
            this.pnlMovements.TabIndex = 7;
            // 
            // btnAddMovement
            // 
            this.btnAddMovement.BackgroundImage = global::UI.Properties.Resources.AddButton;
            this.btnAddMovement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddMovement.FlatAppearance.BorderSize = 0;
            this.btnAddMovement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddMovement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovement.Location = new System.Drawing.Point(890, 9);
            this.btnAddMovement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMovement.Name = "btnAddMovement";
            this.btnAddMovement.Size = new System.Drawing.Size(99, 96);
            this.btnAddMovement.TabIndex = 8;
            this.btnAddMovement.UseVisualStyleBackColor = true;
            this.btnAddMovement.Click += new System.EventHandler(this.btnAddMovement_Click);
            this.btnAddMovement.MouseLeave += new System.EventHandler(this.btnAddMovement_MouseLeave);
            this.btnAddMovement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAddMovement_MouseMove);
            // 
            // frmMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 487);
            this.Controls.Add(this.btnAddMovement);
            this.Controls.Add(this.pnlMovements);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovements";
            this.Text = "frmMovements";
            this.Load += new System.EventHandler(this.frmMovements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlMovements;
        private System.Windows.Forms.Button btnAddMovement;
    }
}