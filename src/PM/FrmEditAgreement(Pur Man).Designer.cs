
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.createDatePicker = new System.Windows.Forms.DateTimePicker();
            this.effectDatePicker = new System.Windows.Forms.DateTimePicker();
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
            this.editItemBtn = new System.Windows.Forms.Button();
            this.txtBuyer = new System.Windows.Forms.TextBox();
            this.buyerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCA = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCAI = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(402, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(374, 24);
            this.lblTitle.TabIndex = 93;
            this.lblTitle.Text = "The Yummy Restaurant Edit Agreement";
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
            this.btnEdit.Location = new System.Drawing.Point(712, 507);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 38);
            this.btnEdit.TabIndex = 134;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(504, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 38);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // createDatePicker
            // 
            this.createDatePicker.Location = new System.Drawing.Point(660, 243);
            this.createDatePicker.Name = "createDatePicker";
            this.createDatePicker.Size = new System.Drawing.Size(188, 20);
            this.createDatePicker.TabIndex = 132;
            // 
            // effectDatePicker
            // 
            this.effectDatePicker.Location = new System.Drawing.Point(660, 294);
            this.effectDatePicker.Name = "effectDatePicker";
            this.effectDatePicker.Size = new System.Drawing.Size(188, 20);
            this.effectDatePicker.TabIndex = 131;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(660, 347);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(188, 21);
            this.cboState.TabIndex = 130;
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(660, 419);
            this.txtTerms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(188, 20);
            this.txtTerms.TabIndex = 129;
            // 
            // txtAgreementType
            // 
            this.txtAgreementType.Location = new System.Drawing.Point(660, 157);
            this.txtAgreementType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgreementType.Name = "txtAgreementType";
            this.txtAgreementType.Size = new System.Drawing.Size(188, 20);
            this.txtAgreementType.TabIndex = 128;
            // 
            // txtAgreementID
            // 
            this.txtAgreementID.Location = new System.Drawing.Point(660, 116);
            this.txtAgreementID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgreementID.Name = "txtAgreementID";
            this.txtAgreementID.ReadOnly = true;
            this.txtAgreementID.Size = new System.Drawing.Size(188, 20);
            this.txtAgreementID.TabIndex = 127;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTerms.Location = new System.Drawing.Point(402, 413);
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
            this.lblAgreementType.Location = new System.Drawing.Point(402, 157);
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
            this.lblCreateDate.Location = new System.Drawing.Point(402, 243);
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
            this.lblEffectiveDate.Location = new System.Drawing.Point(402, 291);
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
            this.lblState.Location = new System.Drawing.Point(402, 342);
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
            this.lblAgreementID.Location = new System.Drawing.Point(402, 116);
            this.lblAgreementID.Name = "lblAgreementID";
            this.lblAgreementID.Size = new System.Drawing.Size(137, 24);
            this.lblAgreementID.TabIndex = 121;
            this.lblAgreementID.Text = "Agreement ID";
            // 
            // editItemBtn
            // 
            this.editItemBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemBtn.ForeColor = System.Drawing.Color.Black;
            this.editItemBtn.Location = new System.Drawing.Point(908, 507);
            this.editItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editItemBtn.Name = "editItemBtn";
            this.editItemBtn.Size = new System.Drawing.Size(134, 38);
            this.editItemBtn.TabIndex = 135;
            this.editItemBtn.Text = "Edit Item";
            this.editItemBtn.UseVisualStyleBackColor = false;
            this.editItemBtn.Click += new System.EventHandler(this.editItemBtn_Click);
            // 
            // txtBuyer
            // 
            this.txtBuyer.Location = new System.Drawing.Point(660, 202);
            this.txtBuyer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuyer.Name = "txtBuyer";
            this.txtBuyer.Size = new System.Drawing.Size(188, 20);
            this.txtBuyer.TabIndex = 137;
            // 
            // buyerLabel
            // 
            this.buyerLabel.AutoSize = true;
            this.buyerLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyerLabel.Location = new System.Drawing.Point(402, 202);
            this.buyerLabel.Name = "buyerLabel";
            this.buyerLabel.Size = new System.Drawing.Size(92, 24);
            this.buyerLabel.TabIndex = 136;
            this.buyerLabel.Text = "Buyer ID";
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
            this.btnCA.Location = new System.Drawing.Point(12, 419);
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
            this.btnCAI.Size = new System.Drawing.Size(203, 50);
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
            // FrmEditAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuyer);
            this.Controls.Add(this.buyerLabel);
            this.Controls.Add(this.editItemBtn);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.createDatePicker);
            this.Controls.Add(this.txtAgreementID);
            this.Controls.Add(this.effectDatePicker);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker createDatePicker;
        private System.Windows.Forms.DateTimePicker effectDatePicker;
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
        private System.Windows.Forms.Button editItemBtn;
        private System.Windows.Forms.TextBox txtBuyer;
        private System.Windows.Forms.Label buyerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCAI;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCA;
    }
}