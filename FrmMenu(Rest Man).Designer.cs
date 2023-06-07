namespace YummyRestaurantSystem
{
    partial class FrmMenuRestMan
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
            this.btnInvMan = new System.Windows.Forms.Button();
            this.btnCheckReq = new System.Windows.Forms.Button();
            this.btnOrderPlacement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(12, 13);
            this.lblHelloMsg.Name = "lblHelloMsg";
            this.lblHelloMsg.Size = new System.Drawing.Size(178, 24);
            this.lblHelloMsg.TabIndex = 3;
            this.lblHelloMsg.Text = "Hello [UserName]!";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(196, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 34);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnInvMan
            // 
            this.btnInvMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInvMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvMan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvMan.ForeColor = System.Drawing.Color.Black;
            this.btnInvMan.Location = new System.Drawing.Point(92, 63);
            this.btnInvMan.Name = "btnInvMan";
            this.btnInvMan.Size = new System.Drawing.Size(140, 38);
            this.btnInvMan.TabIndex = 8;
            this.btnInvMan.Text = "Inventory Manage";
            this.btnInvMan.UseVisualStyleBackColor = false;
            // 
            // btnCheckReq
            // 
            this.btnCheckReq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckReq.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReq.ForeColor = System.Drawing.Color.Black;
            this.btnCheckReq.Location = new System.Drawing.Point(92, 174);
            this.btnCheckReq.Name = "btnCheckReq";
            this.btnCheckReq.Size = new System.Drawing.Size(140, 38);
            this.btnCheckReq.TabIndex = 10;
            this.btnCheckReq.Text = "Check Request";
            this.btnCheckReq.UseVisualStyleBackColor = false;
            // 
            // btnOrderPlacement
            // 
            this.btnOrderPlacement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderPlacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPlacement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPlacement.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPlacement.Location = new System.Drawing.Point(92, 120);
            this.btnOrderPlacement.Name = "btnOrderPlacement";
            this.btnOrderPlacement.Size = new System.Drawing.Size(140, 38);
            this.btnOrderPlacement.TabIndex = 9;
            this.btnOrderPlacement.Text = "Order Placement";
            this.btnOrderPlacement.UseVisualStyleBackColor = false;
            // 
            // FrmMenuRestMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 244);
            this.Controls.Add(this.btnCheckReq);
            this.Controls.Add(this.btnOrderPlacement);
            this.Controls.Add(this.btnInvMan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Name = "FrmMenuRestMan";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloMsg;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInvMan;
        private System.Windows.Forms.Button btnCheckReq;
        private System.Windows.Forms.Button btnOrderPlacement;
    }
}