namespace YummyRestaurantSystem
{
    partial class FrmMenu
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
            this.lblHelloMsg = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRequestManagement = new System.Windows.Forms.Button();
            this.btnContractManagement = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnItemManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(16, 15);
            this.lblHelloMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloMsg.Name = "lblHelloMsg";
            this.lblHelloMsg.Size = new System.Drawing.Size(235, 32);
            this.lblHelloMsg.TabIndex = 3;
            this.lblHelloMsg.Text = "Hello [UserName]!";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(261, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 39);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnRequestManagement
            // 
            this.btnRequestManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRequestManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestManagement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestManagement.ForeColor = System.Drawing.Color.Black;
            this.btnRequestManagement.Location = new System.Drawing.Point(129, 70);
            this.btnRequestManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRequestManagement.Name = "btnRequestManagement";
            this.btnRequestManagement.Size = new System.Drawing.Size(168, 44);
            this.btnRequestManagement.TabIndex = 8;
            this.btnRequestManagement.Text = "Request Manage";
            this.btnRequestManagement.UseVisualStyleBackColor = false;
            // 
            // btnContractManagement
            // 
            this.btnContractManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContractManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractManagement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractManagement.ForeColor = System.Drawing.Color.Black;
            this.btnContractManagement.Location = new System.Drawing.Point(129, 198);
            this.btnContractManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContractManagement.Name = "btnContractManagement";
            this.btnContractManagement.Size = new System.Drawing.Size(168, 44);
            this.btnContractManagement.TabIndex = 10;
            this.btnContractManagement.Text = "Contract Manage";
            this.btnContractManagement.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(129, 261);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(168, 44);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnItemManagement
            // 
            this.btnItemManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemManagement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManagement.ForeColor = System.Drawing.Color.Black;
            this.btnItemManagement.Location = new System.Drawing.Point(129, 136);
            this.btnItemManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItemManagement.Name = "btnItemManagement";
            this.btnItemManagement.Size = new System.Drawing.Size(168, 44);
            this.btnItemManagement.TabIndex = 9;
            this.btnItemManagement.Text = "Item Manage";
            this.btnItemManagement.UseVisualStyleBackColor = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 335);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnContractManagement);
            this.Controls.Add(this.btnItemManagement);
            this.Controls.Add(this.btnRequestManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloMsg;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRequestManagement;
        private System.Windows.Forms.Button btnContractManagement;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnItemManagement;
    }
}