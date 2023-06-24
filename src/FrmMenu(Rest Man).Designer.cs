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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuRestMan));
            this.lblHelloMsg = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInvMan = new System.Windows.Forms.Button();
            this.btnCheckReq = new System.Windows.Forms.Button();
            this.btnOrderPlacement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCDN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnOP = new System.Windows.Forms.Button();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCheckDN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(379, 35);
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
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(1244, 35);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 39);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInvMan
            // 
            this.btnInvMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInvMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvMan.ForeColor = System.Drawing.Color.Black;
            this.btnInvMan.Location = new System.Drawing.Point(392, 227);
            this.btnInvMan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnInvMan.Name = "btnInvMan";
            this.btnInvMan.Size = new System.Drawing.Size(267, 125);
            this.btnInvMan.TabIndex = 8;
            this.btnInvMan.Text = "Inventory Manage";
            this.btnInvMan.UseVisualStyleBackColor = false;
            this.btnInvMan.Click += new System.EventHandler(this.btnInvMan_Click);
            // 
            // btnCheckReq
            // 
            this.btnCheckReq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckReq.ForeColor = System.Drawing.Color.Black;
            this.btnCheckReq.Location = new System.Drawing.Point(392, 435);
            this.btnCheckReq.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCheckReq.Name = "btnCheckReq";
            this.btnCheckReq.Size = new System.Drawing.Size(267, 125);
            this.btnCheckReq.TabIndex = 10;
            this.btnCheckReq.Text = "Check Request";
            this.btnCheckReq.UseVisualStyleBackColor = false;
            this.btnCheckReq.Click += new System.EventHandler(this.btnCheckReq_Click);
            // 
            // btnOrderPlacement
            // 
            this.btnOrderPlacement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderPlacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPlacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPlacement.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPlacement.Location = new System.Drawing.Point(940, 227);
            this.btnOrderPlacement.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOrderPlacement.Name = "btnOrderPlacement";
            this.btnOrderPlacement.Size = new System.Drawing.Size(267, 125);
            this.btnOrderPlacement.TabIndex = 9;
            this.btnOrderPlacement.Text = "Order Placement";
            this.btnOrderPlacement.UseVisualStyleBackColor = false;
            this.btnOrderPlacement.Click += new System.EventHandler(this.btnOrderPlacement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCDN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCR);
            this.panel1.Controls.Add(this.btnOP);
            this.panel1.Controls.Add(this.btnIM);
            this.panel1.Controls.Add(this.btnLogout2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 100;
            // 
            // btnCDN
            // 
            this.btnCDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDN.ForeColor = System.Drawing.Color.Black;
            this.btnCDN.Location = new System.Drawing.Point(16, 546);
            this.btnCDN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCDN.Name = "btnCDN";
            this.btnCDN.Size = new System.Drawing.Size(271, 44);
            this.btnCDN.TabIndex = 104;
            this.btnCDN.Text = "Check Delivery Note";
            this.btnCDN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(192, 685);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 103;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 703);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 97;
            this.lblTime.Text = "Time";
            // 
            // btnCR
            // 
            this.btnCR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCR.ForeColor = System.Drawing.Color.Black;
            this.btnCR.Location = new System.Drawing.Point(16, 478);
            this.btnCR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(271, 44);
            this.btnCR.TabIndex = 96;
            this.btnCR.Text = "Check Request";
            this.btnCR.UseVisualStyleBackColor = false;
            this.btnCR.Click += new System.EventHandler(this.btnCR_Click);
            // 
            // btnOP
            // 
            this.btnOP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOP.ForeColor = System.Drawing.Color.Black;
            this.btnOP.Location = new System.Drawing.Point(16, 407);
            this.btnOP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(271, 44);
            this.btnOP.TabIndex = 95;
            this.btnOP.Text = "Order Placement";
            this.btnOP.UseVisualStyleBackColor = false;
            this.btnOP.Click += new System.EventHandler(this.btnOP_Click);
            // 
            // btnIM
            // 
            this.btnIM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIM.ForeColor = System.Drawing.Color.Black;
            this.btnIM.Location = new System.Drawing.Point(16, 335);
            this.btnIM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(271, 44);
            this.btnIM.TabIndex = 94;
            this.btnIM.Text = "Inventory Manage";
            this.btnIM.UseVisualStyleBackColor = false;
            this.btnIM.Click += new System.EventHandler(this.btnIM_Click);
            // 
            // btnLogout2
            // 
            this.btnLogout2.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout2.Location = new System.Drawing.Point(241, 856);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(141, 55);
            this.btnLogout2.TabIndex = 93;
            this.btnLogout2.Text = "Logout";
            this.btnLogout2.UseVisualStyleBackColor = false;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCheckDN
            // 
            this.btnCheckDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDN.ForeColor = System.Drawing.Color.Black;
            this.btnCheckDN.Location = new System.Drawing.Point(940, 435);
            this.btnCheckDN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCheckDN.Name = "btnCheckDN";
            this.btnCheckDN.Size = new System.Drawing.Size(267, 125);
            this.btnCheckDN.TabIndex = 101;
            this.btnCheckDN.Text = "Check Delivery Note";
            this.btnCheckDN.UseVisualStyleBackColor = false;
            this.btnCheckDN.Click += new System.EventHandler(this.btnCheckDN_Click);
            // 
            // FrmMenuRestMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.btnCheckDN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckReq);
            this.Controls.Add(this.btnOrderPlacement);
            this.Controls.Add(this.btnInvMan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmMenuRestMan";
            this.Text = "Restaurant Manager Menu";
            this.Load += new System.EventHandler(this.FrmMenuRestMan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloMsg;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInvMan;
        private System.Windows.Forms.Button btnCheckReq;
        private System.Windows.Forms.Button btnOrderPlacement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCR;
        private System.Windows.Forms.Button btnOP;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckDN;
        private System.Windows.Forms.Button btnCDN;
    }
}