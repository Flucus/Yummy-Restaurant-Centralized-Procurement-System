
namespace YummyRestaurantSystem.src.PM
{
    partial class FrmPPO_Pur_Man_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPPO_Pur_Man_));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnOM = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtDeliverySchedule = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblDeliverySchedule = new System.Windows.Forms.Label();
            this.txtLocalID = new System.Windows.Forms.TextBox();
            this.lblLocalID = new System.Windows.Forms.Label();
            this.txtPPOID = new System.Windows.Forms.TextBox();
            this.lblPPOID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.PPOTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPOTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCO);
            this.panel1.Controls.Add(this.btnOM);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 102;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 702);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // btnCO
            // 
            this.btnCO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.ForeColor = System.Drawing.Color.Black;
            this.btnCO.Location = new System.Drawing.Point(16, 408);
            this.btnCO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(271, 44);
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
            this.btnOM.Location = new System.Drawing.Point(16, 335);
            this.btnOM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnOM.Name = "btnOM";
            this.btnOM.Size = new System.Drawing.Size(271, 44);
            this.btnOM.TabIndex = 94;
            this.btnOM.Text = "Order Manage";
            this.btnOM.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(192, 685);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 44);
            this.btnLogout.TabIndex = 93;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 218);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(360, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 32);
            this.lblTitle.TabIndex = 112;
            this.lblTitle.Text = "The Yummy Restaurant Planned Purchase Order Create";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(657, 435);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(249, 25);
            this.txtCurrency.TabIndex = 120;
            // 
            // txtDeliverySchedule
            // 
            this.txtDeliverySchedule.Location = new System.Drawing.Point(657, 329);
            this.txtDeliverySchedule.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDeliverySchedule.Name = "txtDeliverySchedule";
            this.txtDeliverySchedule.Size = new System.Drawing.Size(249, 25);
            this.txtDeliverySchedule.TabIndex = 119;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(375, 428);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(125, 32);
            this.lblCurrency.TabIndex = 118;
            this.lblCurrency.Text = "Currency";
            // 
            // lblDeliverySchedule
            // 
            this.lblDeliverySchedule.AutoSize = true;
            this.lblDeliverySchedule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverySchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliverySchedule.Location = new System.Drawing.Point(375, 321);
            this.lblDeliverySchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliverySchedule.Name = "lblDeliverySchedule";
            this.lblDeliverySchedule.Size = new System.Drawing.Size(233, 32);
            this.lblDeliverySchedule.TabIndex = 117;
            this.lblDeliverySchedule.Text = "Delivery Schedule";
            // 
            // txtLocalID
            // 
            this.txtLocalID.Location = new System.Drawing.Point(657, 232);
            this.txtLocalID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLocalID.Name = "txtLocalID";
            this.txtLocalID.Size = new System.Drawing.Size(249, 25);
            this.txtLocalID.TabIndex = 116;
            // 
            // lblLocalID
            // 
            this.lblLocalID.AutoSize = true;
            this.lblLocalID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLocalID.Location = new System.Drawing.Point(375, 232);
            this.lblLocalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalID.Name = "lblLocalID";
            this.lblLocalID.Size = new System.Drawing.Size(115, 32);
            this.lblLocalID.TabIndex = 115;
            this.lblLocalID.Text = "Local ID";
            // 
            // txtPPOID
            // 
            this.txtPPOID.Location = new System.Drawing.Point(657, 148);
            this.txtPPOID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPPOID.Name = "txtPPOID";
            this.txtPPOID.ReadOnly = true;
            this.txtPPOID.Size = new System.Drawing.Size(249, 25);
            this.txtPPOID.TabIndex = 114;
            // 
            // lblPPOID
            // 
            this.lblPPOID.AutoSize = true;
            this.lblPPOID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPOID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPPOID.Location = new System.Drawing.Point(375, 148);
            this.lblPPOID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPOID.Name = "lblPPOID";
            this.lblPPOID.Size = new System.Drawing.Size(105, 32);
            this.lblPPOID.TabIndex = 113;
            this.lblPPOID.Text = "PPO ID";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(1233, 596);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(179, 44);
            this.btnCreate.TabIndex = 122;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(960, 596);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 44);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PPOTable
            // 
            this.PPOTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PPOTable.Location = new System.Drawing.Point(960, 82);
            this.PPOTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPOTable.Name = "PPOTable";
            this.PPOTable.RowHeadersWidth = 51;
            this.PPOTable.RowTemplate.Height = 24;
            this.PPOTable.Size = new System.Drawing.Size(452, 442);
            this.PPOTable.TabIndex = 123;
            // 
            // FrmPPO_Pur_Man_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.PPOTable);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtDeliverySchedule);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblDeliverySchedule);
            this.Controls.Add(this.txtLocalID);
            this.Controls.Add(this.lblLocalID);
            this.Controls.Add(this.txtPPOID);
            this.Controls.Add(this.lblPPOID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPPO_Pur_Man_";
            this.Text = "CreatePPO";
            this.Load += new System.EventHandler(this.FrmPPO_Pur_Man__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPOTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnOM;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtDeliverySchedule;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblDeliverySchedule;
        private System.Windows.Forms.TextBox txtLocalID;
        private System.Windows.Forms.Label lblLocalID;
        private System.Windows.Forms.TextBox txtPPOID;
        private System.Windows.Forms.Label lblPPOID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView PPOTable;
    }
}