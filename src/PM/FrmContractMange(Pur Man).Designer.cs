
namespace YummyRestaurantSystem
{
    partial class FrmContractMange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContractMange));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.cboAgreement = new System.Windows.Forms.ComboBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblContractNumber = new System.Windows.Forms.Label();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.contractTable = new System.Windows.Forms.DataGridView();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCA = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCAI = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contractTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(263, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(439, 24);
            this.lblTitle.TabIndex = 91;
            this.lblTitle.Text = "The Yummy Restaurant Contract Management";
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgreement.Location = new System.Drawing.Point(263, 213);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(121, 24);
            this.lblAgreement.TabIndex = 90;
            this.lblAgreement.Text = " Agreement:";
            // 
            // cboAgreement
            // 
            this.cboAgreement.FormattingEnabled = true;
            this.cboAgreement.Location = new System.Drawing.Point(452, 219);
            this.cboAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAgreement.Name = "cboAgreement";
            this.cboAgreement.Size = new System.Drawing.Size(143, 21);
            this.cboAgreement.TabIndex = 89;
            this.cboAgreement.SelectedIndexChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierName.Location = new System.Drawing.Point(263, 158);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(151, 24);
            this.lblSupplierName.TabIndex = 88;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreateDate.Location = new System.Drawing.Point(263, 259);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(172, 24);
            this.lblCreateDate.TabIndex = 87;
            this.lblCreateDate.Text = "Created Date ±7:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(452, 158);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(143, 20);
            this.txtSupplierName.TabIndex = 86;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(849, 247);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 38);
            this.btnEdit.TabIndex = 84;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(724, 247);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(102, 37);
            this.btnCheck.TabIndex = 83;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblContractNumber
            // 
            this.lblContractNumber.AutoSize = true;
            this.lblContractNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContractNumber.Location = new System.Drawing.Point(263, 99);
            this.lblContractNumber.Name = "lblContractNumber";
            this.lblContractNumber.Size = new System.Drawing.Size(173, 24);
            this.lblContractNumber.TabIndex = 82;
            this.lblContractNumber.Text = "Contract Number:";
            // 
            // createDatePicker
            // 
            this.createDatePicker.Location = new System.Drawing.Point(452, 261);
            this.createDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(143, 20);
            this.createDatePicker.TabIndex = 81;
            this.createDatePicker.ValueChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // contractTable
            // 
            this.contractTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractTable.Location = new System.Drawing.Point(267, 301);
            this.contractTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractTable.Name = "contractTable";
            this.contractTable.RowHeadersWidth = 51;
            this.contractTable.RowTemplate.Height = 24;
            this.contractTable.Size = new System.Drawing.Size(790, 312);
            this.contractTable.TabIndex = 78;
            this.contractTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(452, 99);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(143, 20);
            this.txtContactNumber.TabIndex = 77;
            this.txtContactNumber.TextChanged += new System.EventHandler(this.txtContactNumber_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(985, 30);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 38);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panel1.TabIndex = 101;
            // 
            // btnCA
            // 
            this.btnCA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCA.ForeColor = System.Drawing.Color.Black;
            this.btnCA.Location = new System.Drawing.Point(12, 425);
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
            this.lblTime.Location = new System.Drawing.Point(19, 609);
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
            this.btnCAI.Location = new System.Drawing.Point(12, 353);
            this.btnCAI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCAI.Name = "btnCAI";
            this.btnCAI.Size = new System.Drawing.Size(203, 57);
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
            this.pictureBox1.Size = new System.Drawing.Size(169, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmContractMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.cboAgreement);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblContractNumber);
            this.Controls.Add(this.createDatePicker);
            this.Controls.Add(this.contractTable);
            this.Controls.Add(this.txtContactNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmContractMange";
            this.Text = "Contract Mangement";
            this.Load += new System.EventHandler(this.FrmContractMange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.ComboBox cboAgreement;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblContractNumber;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.DataGridView contractTable;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCAI;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCA;
    }
}