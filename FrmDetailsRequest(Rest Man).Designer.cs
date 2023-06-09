
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
            this.dateEffect = new System.Windows.Forms.DateTimePicker();
            this.dateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtRestID = new System.Windows.Forms.TextBox();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblEffectiveDates = new System.Windows.Forms.Label();
            this.lblRestID = new System.Windows.Forms.Label();
            this.lblExpectedDate = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(713, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 35);
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dateExpect
            // 
            this.dateExpect.Location = new System.Drawing.Point(659, 325);
            this.dateExpect.Name = "dateExpect";
            this.dateExpect.Size = new System.Drawing.Size(188, 22);
            this.dateExpect.TabIndex = 87;
            // 
            // dateEffect
            // 
            this.dateEffect.Location = new System.Drawing.Point(659, 240);
            this.dateEffect.Name = "dateEffect";
            this.dateEffect.Size = new System.Drawing.Size(188, 22);
            this.dateEffect.TabIndex = 86;
            // 
            // dateCreate
            // 
            this.dateCreate.Location = new System.Drawing.Point(659, 198);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Size = new System.Drawing.Size(188, 22);
            this.dateCreate.TabIndex = 85;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(659, 373);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(188, 22);
            this.txtRemark.TabIndex = 84;
            // 
            // txtRestID
            // 
            this.txtRestID.Location = new System.Drawing.Point(659, 280);
            this.txtRestID.Name = "txtRestID";
            this.txtRestID.Size = new System.Drawing.Size(188, 22);
            this.txtRestID.TabIndex = 83;
            // 
            // txtManagerID
            // 
            this.txtManagerID.Location = new System.Drawing.Point(659, 153);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.Size = new System.Drawing.Size(188, 22);
            this.txtManagerID.TabIndex = 82;
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(659, 111);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(188, 22);
            this.txtRequestID.TabIndex = 81;
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(300, 28);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(272, 24);
            this.lblRestaurant.TabIndex = 80;
            this.lblRestaurant.Text = "[restaurant] Request Details";
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRequestID.Location = new System.Drawing.Point(402, 111);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(109, 24);
            this.lblRequestID.TabIndex = 79;
            this.lblRequestID.Text = "RequestID";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemark.Location = new System.Drawing.Point(402, 373);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(82, 24);
            this.lblRemark.TabIndex = 78;
            this.lblRemark.Text = "Remark";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreatedDate.Location = new System.Drawing.Point(402, 198);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(136, 24);
            this.lblCreatedDate.TabIndex = 77;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // lblEffectiveDates
            // 
            this.lblEffectiveDates.AutoSize = true;
            this.lblEffectiveDates.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveDates.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEffectiveDates.Location = new System.Drawing.Point(402, 240);
            this.lblEffectiveDates.Name = "lblEffectiveDates";
            this.lblEffectiveDates.Size = new System.Drawing.Size(155, 24);
            this.lblEffectiveDates.TabIndex = 76;
            this.lblEffectiveDates.Text = "Effective Dates";
            // 
            // lblRestID
            // 
            this.lblRestID.AutoSize = true;
            this.lblRestID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestID.Location = new System.Drawing.Point(402, 280);
            this.lblRestID.Name = "lblRestID";
            this.lblRestID.Size = new System.Drawing.Size(134, 24);
            this.lblRestID.TabIndex = 75;
            this.lblRestID.Text = "RestaurantID";
            // 
            // lblExpectedDate
            // 
            this.lblExpectedDate.AutoSize = true;
            this.lblExpectedDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExpectedDate.Location = new System.Drawing.Point(402, 325);
            this.lblExpectedDate.Name = "lblExpectedDate";
            this.lblExpectedDate.Size = new System.Drawing.Size(219, 24);
            this.lblExpectedDate.TabIndex = 74;
            this.lblExpectedDate.Text = "ExpectedDeliveryDate";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManagerID.Location = new System.Drawing.Point(402, 153);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(113, 24);
            this.lblManagerID.TabIndex = 73;
            this.lblManagerID.Text = "ManagerID";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblState.Location = new System.Drawing.Point(402, 422);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 24);
            this.lblState.TabIndex = 89;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(659, 426);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(188, 22);
            this.txtState.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 595);
            this.panel1.TabIndex = 95;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(153, 548);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 35);
            this.btnLogout.TabIndex = 93;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDetailsRequestRestMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateExpect);
            this.Controls.Add(this.dateEffect);
            this.Controls.Add(this.dateCreate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtRestID);
            this.Controls.Add(this.txtManagerID);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.lblEffectiveDates);
            this.Controls.Add(this.lblRestID);
            this.Controls.Add(this.lblExpectedDate);
            this.Controls.Add(this.lblManagerID);
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
        private System.Windows.Forms.DateTimePicker dateEffect;
        private System.Windows.Forms.DateTimePicker dateCreate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtRestID;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblEffectiveDates;
        private System.Windows.Forms.Label lblRestID;
        private System.Windows.Forms.Label lblExpectedDate;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}