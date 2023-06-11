
namespace YummyRestaurantSystem
{
    partial class FrmEditAgreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAgreement));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnOM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.txtAgreementType = new System.Windows.Forms.TextBox();
            this.txtAgreementID = new System.Windows.Forms.TextBox();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblAgreementType = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAgreementID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(402, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 24);
            this.lblTitle.TabIndex = 93;
            this.lblTitle.Text = "The Yummy Restaurant Edit Agreement";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCO);
            this.panel1.Controls.Add(this.btnOM);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 595);
            this.panel1.TabIndex = 101;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 562);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // btnCO
            // 
            this.btnCO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.ForeColor = System.Drawing.Color.Black;
            this.btnCO.Location = new System.Drawing.Point(12, 326);
            this.btnCO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(203, 35);
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
            this.btnOM.Location = new System.Drawing.Point(12, 268);
            this.btnOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOM.Name = "btnOM";
            this.btnOM.Size = new System.Drawing.Size(203, 35);
            this.btnOM.TabIndex = 94;
            this.btnOM.Text = "Order Manage";
            this.btnOM.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(144, 548);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 35);
            this.button4.TabIndex = 93;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(670, 468);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 35);
            this.btnEdit.TabIndex = 134;
            this.btnEdit.Text = "Create";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(465, 468);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 35);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(660, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker2.TabIndex = 132;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(660, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 22);
            this.dateTimePicker1.TabIndex = 131;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(660, 284);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(188, 20);
            this.cboState.TabIndex = 130;
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(660, 351);
            this.txtTerms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(188, 22);
            this.txtTerms.TabIndex = 129;
            // 
            // txtAgreementType
            // 
            this.txtAgreementType.Location = new System.Drawing.Point(660, 145);
            this.txtAgreementType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgreementType.Name = "txtAgreementType";
            this.txtAgreementType.Size = new System.Drawing.Size(188, 22);
            this.txtAgreementType.TabIndex = 128;
            // 
            // txtAgreementID
            // 
            this.txtAgreementID.Location = new System.Drawing.Point(660, 107);
            this.txtAgreementID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgreementID.Name = "txtAgreementID";
            this.txtAgreementID.Size = new System.Drawing.Size(188, 22);
            this.txtAgreementID.TabIndex = 127;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTerms.Location = new System.Drawing.Point(402, 345);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(200, 24);
            this.lblTerms.TabIndex = 126;
            this.lblTerms.Text = "Terms and Condition";
            // 
            // lblAgreementType
            // 
            this.lblAgreementType.AutoSize = true;
            this.lblAgreementType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreementType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgreementType.Location = new System.Drawing.Point(402, 145);
            this.lblAgreementType.Name = "lblAgreementType";
            this.lblAgreementType.Size = new System.Drawing.Size(161, 24);
            this.lblAgreementType.TabIndex = 125;
            this.lblAgreementType.Text = "Agreement Type";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreateDate.Location = new System.Drawing.Point(402, 188);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(125, 24);
            this.lblCreateDate.TabIndex = 124;
            this.lblCreateDate.Text = "Create Date";
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.AutoSize = true;
            this.lblEffectiveDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEffectiveDate.Location = new System.Drawing.Point(402, 233);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(144, 24);
            this.lblEffectiveDate.TabIndex = 123;
            this.lblEffectiveDate.Text = "Effective Date";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblState.Location = new System.Drawing.Point(402, 280);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 24);
            this.lblState.TabIndex = 122;
            this.lblState.Text = "State";
            // 
            // lblAgreementID
            // 
            this.lblAgreementID.AutoSize = true;
            this.lblAgreementID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreementID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgreementID.Location = new System.Drawing.Point(402, 107);
            this.lblAgreementID.Name = "lblAgreementID";
            this.lblAgreementID.Size = new System.Drawing.Size(137, 24);
            this.lblAgreementID.TabIndex = 121;
            this.lblAgreementID.Text = "Agreement ID";
            // 
            // FrmEditAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtAgreementID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAgreementID);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.lblEffectiveDate);
            this.Controls.Add(this.txtAgreementType);
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.lblAgreementType);
            this.Controls.Add(this.lblTerms);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEditAgreement";
            this.Text = "Edit Agreement";
            this.Load += new System.EventHandler(this.FrmEditAgreement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnOM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.TextBox txtAgreementType;
        private System.Windows.Forms.TextBox txtAgreementID;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Label lblAgreementType;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAgreementID;
    }
}