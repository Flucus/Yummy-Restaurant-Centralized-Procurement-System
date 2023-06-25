
namespace YummyRestaurantSystem.src.PM
{
    partial class FrmEditPPO_Pur_Man_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditPPO_Pur_Man_));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtDeliverySchedule = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblDeliverySchedule = new System.Windows.Forms.Label();
            this.txtLocalID = new System.Windows.Forms.TextBox();
            this.lblLocalID = new System.Windows.Forms.Label();
            this.txtPPOID = new System.Windows.Forms.TextBox();
            this.lblPPOID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCA = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCAI = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(705, 71);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(339, 383);
            this.dataGridView3.TabIndex = 135;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(910, 517);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 38);
            this.btnEdit.TabIndex = 134;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(705, 517);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 38);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(478, 377);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(188, 20);
            this.txtCurrency.TabIndex = 132;
            // 
            // txtDeliverySchedule
            // 
            this.txtDeliverySchedule.Location = new System.Drawing.Point(478, 285);
            this.txtDeliverySchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeliverySchedule.Name = "txtDeliverySchedule";
            this.txtDeliverySchedule.Size = new System.Drawing.Size(188, 20);
            this.txtDeliverySchedule.TabIndex = 131;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency.Location = new System.Drawing.Point(266, 371);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(95, 24);
            this.lblCurrency.TabIndex = 130;
            this.lblCurrency.Text = "Currency";
            // 
            // lblDeliverySchedule
            // 
            this.lblDeliverySchedule.AutoSize = true;
            this.lblDeliverySchedule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverySchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliverySchedule.Location = new System.Drawing.Point(266, 278);
            this.lblDeliverySchedule.Name = "lblDeliverySchedule";
            this.lblDeliverySchedule.Size = new System.Drawing.Size(179, 24);
            this.lblDeliverySchedule.TabIndex = 129;
            this.lblDeliverySchedule.Text = "Delivery Schedule";
            // 
            // txtLocalID
            // 
            this.txtLocalID.Location = new System.Drawing.Point(478, 201);
            this.txtLocalID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalID.Name = "txtLocalID";
            this.txtLocalID.Size = new System.Drawing.Size(188, 20);
            this.txtLocalID.TabIndex = 128;
            // 
            // lblLocalID
            // 
            this.lblLocalID.AutoSize = true;
            this.lblLocalID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLocalID.Location = new System.Drawing.Point(266, 201);
            this.lblLocalID.Name = "lblLocalID";
            this.lblLocalID.Size = new System.Drawing.Size(88, 24);
            this.lblLocalID.TabIndex = 127;
            this.lblLocalID.Text = "Local ID";
            // 
            // txtPPOID
            // 
            this.txtPPOID.Location = new System.Drawing.Point(478, 128);
            this.txtPPOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPPOID.Name = "txtPPOID";
            this.txtPPOID.Size = new System.Drawing.Size(188, 20);
            this.txtPPOID.TabIndex = 126;
            // 
            // lblPPOID
            // 
            this.lblPPOID.AutoSize = true;
            this.lblPPOID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPOID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPPOID.Location = new System.Drawing.Point(266, 128);
            this.lblPPOID.Name = "lblPPOID";
            this.lblPPOID.Size = new System.Drawing.Size(81, 24);
            this.lblPPOID.TabIndex = 125;
            this.lblPPOID.Text = "PPO ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(255, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(504, 24);
            this.lblTitle.TabIndex = 124;
            this.lblTitle.Text = "The Yummy Restaurant Planned Purchase Order Edit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCA);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCAI);
            this.panel1.Controls.Add(this.btnCM);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 645);
            this.panel1.TabIndex = 138;
            // 
            // btnCA
            // 
            this.btnCA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCA.ForeColor = System.Drawing.Color.Black;
            this.btnCA.Location = new System.Drawing.Point(12, 427);
            this.btnCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(203, 38);
            this.btnCA.TabIndex = 99;
            this.btnCA.Text = "Create Agreement";
            this.btnCA.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(144, 594);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 38);
            this.button4.TabIndex = 97;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
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
            // btnCAI
            // 
            this.btnCAI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAI.ForeColor = System.Drawing.Color.Black;
            this.btnCAI.Location = new System.Drawing.Point(12, 354);
            this.btnCAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAI.Name = "btnCAI";
            this.btnCAI.Size = new System.Drawing.Size(203, 59);
            this.btnCAI.TabIndex = 95;
            this.btnCAI.Text = "Create Agreement Item";
            this.btnCAI.UseVisualStyleBackColor = false;
            this.btnCAI.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnCM
            // 
            this.btnCM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCM.ForeColor = System.Drawing.Color.Black;
            this.btnCM.Location = new System.Drawing.Point(12, 290);
            this.btnCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(203, 38);
            this.btnCM.TabIndex = 94;
            this.btnCM.Text = "Contract Manage";
            this.btnCM.UseVisualStyleBackColor = false;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEditPPO_Pur_Man_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnEdit);
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
            this.Name = "FrmEditPPO_Pur_Man_";
            this.Text = "Edit PPO";
            this.Load += new System.EventHandler(this.FrmEditPPO_Pur_Man__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtDeliverySchedule;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblDeliverySchedule;
        private System.Windows.Forms.TextBox txtLocalID;
        private System.Windows.Forms.Label lblLocalID;
        private System.Windows.Forms.TextBox txtPPOID;
        private System.Windows.Forms.Label lblPPOID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCAI;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCA;
    }
}