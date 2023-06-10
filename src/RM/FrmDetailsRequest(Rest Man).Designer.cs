
namespace YummyRestaurantSystem
{
    partial class FrmDetailsRequestRestMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailsRequestRestMan));
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateExpect = new System.Windows.Forms.DateTimePicker();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtRestID = new System.Windows.Forms.TextBox();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblRestID = new System.Windows.Forms.Label();
            this.lblExpectedDate = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnOP = new System.Windows.Forms.Button();
            this.btnIM = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(951, 642);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 44);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateExpect
            // 
            this.dateExpect.Enabled = false;
            this.dateExpect.Location = new System.Drawing.Point(879, 359);
            this.dateExpect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateExpect.Name = "dateExpect";
            this.dateExpect.Size = new System.Drawing.Size(249, 25);
            this.dateExpect.TabIndex = 87;
            // 
            // dateCreate
            // 
            this.dateCreate.Enabled = false;
            this.dateCreate.Location = new System.Drawing.Point(879, 301);
            this.dateCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(249, 25);
            this.dateCreate.TabIndex = 85;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(879, 419);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(249, 25);
            this.txtRemark.TabIndex = 84;
            // 
            // txtRestID
            // 
            this.txtRestID.Location = new System.Drawing.Point(879, 249);
            this.txtRestID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRestID.Name = "txtRestID";
            this.txtRestID.ReadOnly = true;
            this.txtRestID.Size = new System.Drawing.Size(249, 25);
            this.txtRestID.TabIndex = 83;
            // 
            // txtManagerID
            // 
            this.txtManagerID.Location = new System.Drawing.Point(879, 192);
            this.txtManagerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.ReadOnly = true;
            this.txtManagerID.Size = new System.Drawing.Size(249, 25);
            this.txtManagerID.TabIndex = 82;
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(879, 138);
            this.txtRequestID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(249, 25);
            this.txtRequestID.TabIndex = 81;
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(400, 35);
            this.lblRestaurant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(355, 32);
            this.lblRestaurant.TabIndex = 80;
            this.lblRestaurant.Text = "[restaurant] Request Details";
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRequestID.Location = new System.Drawing.Point(536, 138);
            this.lblRequestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(144, 32);
            this.lblRequestID.TabIndex = 79;
            this.lblRequestID.Text = "RequestID";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemark.Location = new System.Drawing.Point(536, 409);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(109, 32);
            this.lblRemark.TabIndex = 78;
            this.lblRemark.Text = "Remark";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreatedDate.Location = new System.Drawing.Point(536, 295);
            this.lblCreatedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(177, 32);
            this.lblCreatedDate.TabIndex = 77;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // lblRestID
            // 
            this.lblRestID.AutoSize = true;
            this.lblRestID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestID.Location = new System.Drawing.Point(536, 242);
            this.lblRestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestID.Name = "lblRestID";
            this.lblRestID.Size = new System.Drawing.Size(176, 32);
            this.lblRestID.TabIndex = 75;
            this.lblRestID.Text = "RestaurantID";
            // 
            // lblExpectedDate
            // 
            this.lblExpectedDate.AutoSize = true;
            this.lblExpectedDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpectedDate.Location = new System.Drawing.Point(536, 353);
            this.lblExpectedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpectedDate.Name = "lblExpectedDate";
            this.lblExpectedDate.Size = new System.Drawing.Size(282, 32);
            this.lblExpectedDate.TabIndex = 74;
            this.lblExpectedDate.Text = "ExpectedDeliveryDate";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagerID.Location = new System.Drawing.Point(536, 192);
            this.lblManagerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(149, 32);
            this.lblManagerID.TabIndex = 73;
            this.lblManagerID.Text = "ManagerID";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblState.Location = new System.Drawing.Point(536, 466);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(78, 32);
            this.lblState.TabIndex = 89;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(879, 476);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(249, 25);
            this.txtState.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCR);
            this.panel1.Controls.Add(this.btnOP);
            this.panel1.Controls.Add(this.btnIM);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 101;
            // 
            // btnCR
            // 
            this.btnCR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCR.ForeColor = System.Drawing.Color.Black;
            this.btnCR.Location = new System.Drawing.Point(16, 477);
            this.btnCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(271, 44);
            this.btnCR.TabIndex = 96;
            this.btnCR.Text = "Check Request";
            this.btnCR.UseVisualStyleBackColor = false;
            // 
            // btnOP
            // 
            this.btnOP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOP.ForeColor = System.Drawing.Color.Black;
            this.btnOP.Location = new System.Drawing.Point(16, 407);
            this.btnOP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(271, 44);
            this.btnOP.TabIndex = 95;
            this.btnOP.Text = "Order Placement";
            this.btnOP.UseVisualStyleBackColor = false;
            // 
            // btnIM
            // 
            this.btnIM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIM.ForeColor = System.Drawing.Color.Black;
            this.btnIM.Location = new System.Drawing.Point(16, 335);
            this.btnIM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(271, 44);
            this.btnIM.TabIndex = 94;
            this.btnIM.Text = "Inventory Manage";
            this.btnIM.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logoutBtn.Location = new System.Drawing.Point(186, 685);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(101, 44);
            this.logoutBtn.TabIndex = 93;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDetailsRequestRestMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateExpect);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtRestID);
            this.Controls.Add(this.txtManagerID);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblRestID);
            this.Controls.Add(this.lblExpectedDate);
            this.Controls.Add(this.lblManagerID);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmDetailsRequestRestMan";
            this.Text = "Request Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateExpect;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRestID;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblRestID;
        private System.Windows.Forms.Label lblExpectedDate;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCR;
        private System.Windows.Forms.Button btnOP;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}