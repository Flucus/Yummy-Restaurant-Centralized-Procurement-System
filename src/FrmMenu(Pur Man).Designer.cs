namespace YummyRestaurantSystem
{
    partial class FrmMenuPurMan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPurMan));
            this.btnCreOrder = new System.Windows.Forms.Button();
            this.btnOrderMan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHelloMsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnOM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreOrder
            // 
            this.btnCreOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCreOrder.Location = new System.Drawing.Point(705, 198);
            this.btnCreOrder.Name = "btnCreOrder";
            this.btnCreOrder.Size = new System.Drawing.Size(200, 108);
            this.btnCreOrder.TabIndex = 15;
            this.btnCreOrder.Text = "Create Agreement";
            this.btnCreOrder.UseVisualStyleBackColor = false;
            this.btnCreOrder.Click += new System.EventHandler(this.btnCreOrder_Click);
            // 
            // btnOrderMan
            // 
            this.btnOrderMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMan.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMan.Location = new System.Drawing.Point(294, 198);
            this.btnOrderMan.Name = "btnOrderMan";
            this.btnOrderMan.Size = new System.Drawing.Size(200, 108);
            this.btnOrderMan.TabIndex = 14;
            this.btnOrderMan.Text = "Contract Manage";
            this.btnOrderMan.UseVisualStyleBackColor = false;
            this.btnOrderMan.Click += new System.EventHandler(this.btnOrderMan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(933, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 34);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(284, 30);
            this.lblHelloMsg.Name = "lblHelloMsg";
            this.lblHelloMsg.Size = new System.Drawing.Size(178, 24);
            this.lblHelloMsg.TabIndex = 12;
            this.lblHelloMsg.Text = "Hello [UserName]!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCO);
            this.panel1.Controls.Add(this.btnOM);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 645);
            this.panel1.TabIndex = 100;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(150, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 34);
            this.button4.TabIndex = 97;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 608);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // btnCO
            // 
            this.btnCO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.ForeColor = System.Drawing.Color.Black;
            this.btnCO.Location = new System.Drawing.Point(12, 354);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(203, 38);
            this.btnCO.TabIndex = 95;
            this.btnCO.Text = "Create Order";
            this.btnCO.UseVisualStyleBackColor = false;
            // 
            // btnOM
            // 
            this.btnOM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOM.ForeColor = System.Drawing.Color.Black;
            this.btnOM.Location = new System.Drawing.Point(12, 290);
            this.btnOM.Name = "btnOM";
            this.btnOM.Size = new System.Drawing.Size(203, 38);
            this.btnOM.TabIndex = 94;
            this.btnOM.Text = "Order Manage";
            this.btnOM.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenuPurMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreOrder);
            this.Controls.Add(this.btnOrderMan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Name = "FrmMenuPurMan";
            this.Text = "Purchase Manager Menu";
            this.Load += new System.EventHandler(this.FrmMenuPurMan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreOrder;
        private System.Windows.Forms.Button btnOrderMan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHelloMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnOM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
    }
}