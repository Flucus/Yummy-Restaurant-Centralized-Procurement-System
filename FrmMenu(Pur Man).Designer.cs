namespace YummyRestaurantSystem
{
    partial class FrmMenu_Pur_Man_
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
            this.btnPurOrder = new System.Windows.Forms.Button();
            this.btnOrderMan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHelloMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPurOrder
            // 
            this.btnPurOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPurOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurOrder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPurOrder.Location = new System.Drawing.Point(90, 120);
            this.btnPurOrder.Name = "btnPurOrder";
            this.btnPurOrder.Size = new System.Drawing.Size(140, 38);
            this.btnPurOrder.TabIndex = 15;
            this.btnPurOrder.Text = "Purchase Order";
            this.btnPurOrder.UseVisualStyleBackColor = false;
            // 
            // btnOrderMan
            // 
            this.btnOrderMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMan.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMan.Location = new System.Drawing.Point(90, 63);
            this.btnOrderMan.Name = "btnOrderMan";
            this.btnOrderMan.Size = new System.Drawing.Size(140, 38);
            this.btnOrderMan.TabIndex = 14;
            this.btnOrderMan.Text = "Order Manage";
            this.btnOrderMan.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(194, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 34);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(10, 13);
            this.lblHelloMsg.Name = "lblHelloMsg";
            this.lblHelloMsg.Size = new System.Drawing.Size(178, 24);
            this.lblHelloMsg.TabIndex = 12;
            this.lblHelloMsg.Text = "Hello [UserName]!";
            // 
            // FrmMenu_Pur_Man_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 198);
            this.Controls.Add(this.btnPurOrder);
            this.Controls.Add(this.btnOrderMan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Name = "FrmMenu_Pur_Man_";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPurOrder;
        private System.Windows.Forms.Button btnOrderMan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHelloMsg;
    }
}