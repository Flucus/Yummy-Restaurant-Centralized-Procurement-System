
namespace YummyRestaurantSystem.src.PM
{
    partial class FrmEditAgreeItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditAgreeItem));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControlCPA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNewItemID_CPA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel_CPA = new System.Windows.Forms.Button();
            this.txtItemID_CPA = new System.Windows.Forms.TextBox();
            this.cpaItemTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit_CPA = new System.Windows.Forms.Button();
            this.lblItemID_CPA = new System.Windows.Forms.Label();
            this.txtCPAID = new System.Windows.Forms.TextBox();
            this.lblCPAID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNewItemID_BPA = new System.Windows.Forms.TextBox();
            this.txtAmountAgreed_BPA = new System.Windows.Forms.TextBox();
            this.txtItemID_BPA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBPA = new System.Windows.Forms.DateTimePicker();
            this.txtDiscount_BPA = new System.Windows.Forms.TextBox();
            this.bpaItemTable = new System.Windows.Forms.DataGridView();
            this.lblPriceBEffectiveDate_BPA = new System.Windows.Forms.Label();
            this.lblDiscount_BPA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit_BPA = new System.Windows.Forms.Button();
            this.btnCancel_BPA = new System.Windows.Forms.Button();
            this.txtPriceBAmount_BPA = new System.Windows.Forms.TextBox();
            this.txtlCurrency_BPA = new System.Windows.Forms.TextBox();
            this.txtUnitPrice_BPA = new System.Windows.Forms.TextBox();
            this.txtAmountDelivered_BPA = new System.Windows.Forms.TextBox();
            this.lblCurrency_BPA = new System.Windows.Forms.Label();
            this.lblPriceBAmount_BPA = new System.Windows.Forms.Label();
            this.lblItemID_BPA = new System.Windows.Forms.Label();
            this.lblAmountAgreed_BPA = new System.Windows.Forms.Label();
            this.lblAmountDelivered_BPA = new System.Windows.Forms.Label();
            this.lblUnitPrice_BPA = new System.Windows.Forms.Label();
            this.txtBPAID = new System.Windows.Forms.TextBox();
            this.lblBPAID = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNewItemID_PPO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice_PPO = new System.Windows.Forms.TextBox();
            this.txtQuantity_PPO = new System.Windows.Forms.TextBox();
            this.lblUnitPrice_PPO = new System.Windows.Forms.Label();
            this.lblQuantity_PPO = new System.Windows.Forms.Label();
            this.txtItemID_PPO = new System.Windows.Forms.TextBox();
            this.ppoItemTable = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEdit_PPO = new System.Windows.Forms.Button();
            this.btnCancel_PPO = new System.Windows.Forms.Button();
            this.lblItemID_PPO = new System.Windows.Forms.Label();
            this.txtPPOID = new System.Windows.Forms.TextBox();
            this.lblPPOID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCA = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCAI = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlCPA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpaItemTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpaItemTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppoItemTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(236, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 24);
            this.lblTitle.TabIndex = 104;
            this.lblTitle.Text = "The Yummy Restaurant Edit Agreement Item";
            // 
            // tabControlCPA
            // 
            this.tabControlCPA.Controls.Add(this.tabPage1);
            this.tabControlCPA.Controls.Add(this.tabPage2);
            this.tabControlCPA.Controls.Add(this.tabPage3);
            this.tabControlCPA.Location = new System.Drawing.Point(240, 82);
            this.tabControlCPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlCPA.Name = "tabControlCPA";
            this.tabControlCPA.SelectedIndex = 0;
            this.tabControlCPA.Size = new System.Drawing.Size(806, 560);
            this.tabControlCPA.TabIndex = 103;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNewItemID_CPA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnCancel_CPA);
            this.tabPage1.Controls.Add(this.txtItemID_CPA);
            this.tabPage1.Controls.Add(this.cpaItemTable);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnEdit_CPA);
            this.tabPage1.Controls.Add(this.lblItemID_CPA);
            this.tabPage1.Controls.Add(this.txtCPAID);
            this.tabPage1.Controls.Add(this.lblCPAID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(798, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contract Purchase Agreement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNewItemID_CPA
            // 
            this.txtNewItemID_CPA.Location = new System.Drawing.Point(177, 272);
            this.txtNewItemID_CPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewItemID_CPA.Name = "txtNewItemID_CPA";
            this.txtNewItemID_CPA.Size = new System.Drawing.Size(188, 20);
            this.txtNewItemID_CPA.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 104;
            this.label3.Text = "New Item ID";
            // 
            // btnCancel_CPA
            // 
            this.btnCancel_CPA.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel_CPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_CPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_CPA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel_CPA.Location = new System.Drawing.Point(441, 465);
            this.btnCancel_CPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel_CPA.Name = "btnCancel_CPA";
            this.btnCancel_CPA.Size = new System.Drawing.Size(134, 38);
            this.btnCancel_CPA.TabIndex = 103;
            this.btnCancel_CPA.Text = "Cancel";
            this.btnCancel_CPA.UseVisualStyleBackColor = false;
            this.btnCancel_CPA.Click += new System.EventHandler(this.btnCancel_CPA_Click);
            // 
            // txtItemID_CPA
            // 
            this.txtItemID_CPA.Location = new System.Drawing.Point(177, 202);
            this.txtItemID_CPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemID_CPA.Name = "txtItemID_CPA";
            this.txtItemID_CPA.ReadOnly = true;
            this.txtItemID_CPA.Size = new System.Drawing.Size(188, 20);
            this.txtItemID_CPA.TabIndex = 102;
            // 
            // cpaItemTable
            // 
            this.cpaItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cpaItemTable.Location = new System.Drawing.Point(441, 39);
            this.cpaItemTable.Name = "cpaItemTable";
            this.cpaItemTable.RowHeadersWidth = 51;
            this.cpaItemTable.RowTemplate.Height = 24;
            this.cpaItemTable.Size = new System.Drawing.Size(339, 384);
            this.cpaItemTable.TabIndex = 99;
            this.cpaItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cpaItemTable_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 96;
            this.label4.Text = "Purchase Order Revision:";
            // 
            // btnEdit_CPA
            // 
            this.btnEdit_CPA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit_CPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_CPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_CPA.ForeColor = System.Drawing.Color.Black;
            this.btnEdit_CPA.Location = new System.Drawing.Point(646, 465);
            this.btnEdit_CPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_CPA.Name = "btnEdit_CPA";
            this.btnEdit_CPA.Size = new System.Drawing.Size(134, 38);
            this.btnEdit_CPA.TabIndex = 95;
            this.btnEdit_CPA.Text = "Edit";
            this.btnEdit_CPA.UseVisualStyleBackColor = false;
            this.btnEdit_CPA.Click += new System.EventHandler(this.btnEdit_CPA_Click);
            // 
            // lblItemID_CPA
            // 
            this.lblItemID_CPA.AutoSize = true;
            this.lblItemID_CPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID_CPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemID_CPA.Location = new System.Drawing.Point(22, 203);
            this.lblItemID_CPA.Name = "lblItemID_CPA";
            this.lblItemID_CPA.Size = new System.Drawing.Size(77, 24);
            this.lblItemID_CPA.TabIndex = 87;
            this.lblItemID_CPA.Text = "Item ID";
            // 
            // txtCPAID
            // 
            this.txtCPAID.Location = new System.Drawing.Point(177, 124);
            this.txtCPAID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPAID.Name = "txtCPAID";
            this.txtCPAID.ReadOnly = true;
            this.txtCPAID.Size = new System.Drawing.Size(188, 20);
            this.txtCPAID.TabIndex = 83;
            this.txtCPAID.TextChanged += new System.EventHandler(this.txtCPAID_TextChanged);
            // 
            // lblCPAID
            // 
            this.lblCPAID.AutoSize = true;
            this.lblCPAID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPAID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCPAID.Location = new System.Drawing.Point(22, 124);
            this.lblCPAID.Name = "lblCPAID";
            this.lblCPAID.Size = new System.Drawing.Size(76, 24);
            this.lblCPAID.TabIndex = 82;
            this.lblCPAID.Text = "CPA ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtNewItemID_BPA);
            this.tabPage2.Controls.Add(this.txtAmountAgreed_BPA);
            this.tabPage2.Controls.Add(this.txtItemID_BPA);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dateTimePickerBPA);
            this.tabPage2.Controls.Add(this.txtDiscount_BPA);
            this.tabPage2.Controls.Add(this.bpaItemTable);
            this.tabPage2.Controls.Add(this.lblPriceBEffectiveDate_BPA);
            this.tabPage2.Controls.Add(this.lblDiscount_BPA);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnEdit_BPA);
            this.tabPage2.Controls.Add(this.btnCancel_BPA);
            this.tabPage2.Controls.Add(this.txtPriceBAmount_BPA);
            this.tabPage2.Controls.Add(this.txtlCurrency_BPA);
            this.tabPage2.Controls.Add(this.txtUnitPrice_BPA);
            this.tabPage2.Controls.Add(this.txtAmountDelivered_BPA);
            this.tabPage2.Controls.Add(this.lblCurrency_BPA);
            this.tabPage2.Controls.Add(this.lblPriceBAmount_BPA);
            this.tabPage2.Controls.Add(this.lblItemID_BPA);
            this.tabPage2.Controls.Add(this.lblAmountAgreed_BPA);
            this.tabPage2.Controls.Add(this.lblAmountDelivered_BPA);
            this.tabPage2.Controls.Add(this.lblUnitPrice_BPA);
            this.tabPage2.Controls.Add(this.txtBPAID);
            this.tabPage2.Controls.Add(this.lblBPAID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(798, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blanket Purchase Agreement";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNewItemID_BPA
            // 
            this.txtNewItemID_BPA.Location = new System.Drawing.Point(234, 154);
            this.txtNewItemID_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewItemID_BPA.Name = "txtNewItemID_BPA";
            this.txtNewItemID_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtNewItemID_BPA.TabIndex = 83;
            // 
            // txtAmountAgreed_BPA
            // 
            this.txtAmountAgreed_BPA.Location = new System.Drawing.Point(234, 191);
            this.txtAmountAgreed_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmountAgreed_BPA.Name = "txtAmountAgreed_BPA";
            this.txtAmountAgreed_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtAmountAgreed_BPA.TabIndex = 81;
            // 
            // txtItemID_BPA
            // 
            this.txtItemID_BPA.Location = new System.Drawing.Point(234, 111);
            this.txtItemID_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemID_BPA.Name = "txtItemID_BPA";
            this.txtItemID_BPA.ReadOnly = true;
            this.txtItemID_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtItemID_BPA.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "New Item ID";
            // 
            // dateTimePickerBPA
            // 
            this.dateTimePickerBPA.Location = new System.Drawing.Point(23, 469);
            this.dateTimePickerBPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBPA.Name = "dateTimePickerBPA";
            this.dateTimePickerBPA.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerBPA.TabIndex = 79;
            // 
            // txtDiscount_BPA
            // 
            this.txtDiscount_BPA.Location = new System.Drawing.Point(234, 388);
            this.txtDiscount_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount_BPA.Name = "txtDiscount_BPA";
            this.txtDiscount_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtDiscount_BPA.TabIndex = 78;
            // 
            // bpaItemTable
            // 
            this.bpaItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bpaItemTable.Location = new System.Drawing.Point(441, 39);
            this.bpaItemTable.Name = "bpaItemTable";
            this.bpaItemTable.RowHeadersWidth = 51;
            this.bpaItemTable.RowTemplate.Height = 24;
            this.bpaItemTable.Size = new System.Drawing.Size(339, 384);
            this.bpaItemTable.TabIndex = 77;
            this.bpaItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bpdItemTable_CellContentClick);
            // 
            // lblPriceBEffectiveDate_BPA
            // 
            this.lblPriceBEffectiveDate_BPA.AutoSize = true;
            this.lblPriceBEffectiveDate_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceBEffectiveDate_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPriceBEffectiveDate_BPA.Location = new System.Drawing.Point(19, 431);
            this.lblPriceBEffectiveDate_BPA.Name = "lblPriceBEffectiveDate_BPA";
            this.lblPriceBEffectiveDate_BPA.Size = new System.Drawing.Size(254, 24);
            this.lblPriceBEffectiveDate_BPA.TabIndex = 76;
            this.lblPriceBEffectiveDate_BPA.Text = "Price Break EffectiveDate";
            // 
            // lblDiscount_BPA
            // 
            this.lblDiscount_BPA.AutoSize = true;
            this.lblDiscount_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiscount_BPA.Location = new System.Drawing.Point(19, 387);
            this.lblDiscount_BPA.Name = "lblDiscount_BPA";
            this.lblDiscount_BPA.Size = new System.Drawing.Size(92, 24);
            this.lblDiscount_BPA.TabIndex = 75;
            this.lblDiscount_BPA.Text = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = "Purchase Order Revision:";
            // 
            // btnEdit_BPA
            // 
            this.btnEdit_BPA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit_BPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_BPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_BPA.ForeColor = System.Drawing.Color.Black;
            this.btnEdit_BPA.Location = new System.Drawing.Point(646, 465);
            this.btnEdit_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_BPA.Name = "btnEdit_BPA";
            this.btnEdit_BPA.Size = new System.Drawing.Size(134, 38);
            this.btnEdit_BPA.TabIndex = 73;
            this.btnEdit_BPA.Text = "Edit";
            this.btnEdit_BPA.UseVisualStyleBackColor = false;
            this.btnEdit_BPA.Click += new System.EventHandler(this.btnEdit_BPA_Click);
            // 
            // btnCancel_BPA
            // 
            this.btnCancel_BPA.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel_BPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_BPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_BPA.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel_BPA.Location = new System.Drawing.Point(441, 465);
            this.btnCancel_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel_BPA.Name = "btnCancel_BPA";
            this.btnCancel_BPA.Size = new System.Drawing.Size(134, 38);
            this.btnCancel_BPA.TabIndex = 72;
            this.btnCancel_BPA.Text = "Cancel";
            this.btnCancel_BPA.UseVisualStyleBackColor = false;
            this.btnCancel_BPA.Click += new System.EventHandler(this.btnCancel_BPA_Click);
            // 
            // txtPriceBAmount_BPA
            // 
            this.txtPriceBAmount_BPA.Location = new System.Drawing.Point(234, 340);
            this.txtPriceBAmount_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceBAmount_BPA.Name = "txtPriceBAmount_BPA";
            this.txtPriceBAmount_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtPriceBAmount_BPA.TabIndex = 71;
            // 
            // txtlCurrency_BPA
            // 
            this.txtlCurrency_BPA.Location = new System.Drawing.Point(234, 301);
            this.txtlCurrency_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlCurrency_BPA.Name = "txtlCurrency_BPA";
            this.txtlCurrency_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtlCurrency_BPA.TabIndex = 70;
            // 
            // txtUnitPrice_BPA
            // 
            this.txtUnitPrice_BPA.Location = new System.Drawing.Point(234, 265);
            this.txtUnitPrice_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice_BPA.Name = "txtUnitPrice_BPA";
            this.txtUnitPrice_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtUnitPrice_BPA.TabIndex = 69;
            // 
            // txtAmountDelivered_BPA
            // 
            this.txtAmountDelivered_BPA.Location = new System.Drawing.Point(234, 231);
            this.txtAmountDelivered_BPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmountDelivered_BPA.Name = "txtAmountDelivered_BPA";
            this.txtAmountDelivered_BPA.Size = new System.Drawing.Size(188, 20);
            this.txtAmountDelivered_BPA.TabIndex = 68;
            // 
            // lblCurrency_BPA
            // 
            this.lblCurrency_BPA.AutoSize = true;
            this.lblCurrency_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrency_BPA.Location = new System.Drawing.Point(22, 298);
            this.lblCurrency_BPA.Name = "lblCurrency_BPA";
            this.lblCurrency_BPA.Size = new System.Drawing.Size(95, 24);
            this.lblCurrency_BPA.TabIndex = 67;
            this.lblCurrency_BPA.Text = "Currency";
            // 
            // lblPriceBAmount_BPA
            // 
            this.lblPriceBAmount_BPA.AutoSize = true;
            this.lblPriceBAmount_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceBAmount_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPriceBAmount_BPA.Location = new System.Drawing.Point(19, 340);
            this.lblPriceBAmount_BPA.Name = "lblPriceBAmount_BPA";
            this.lblPriceBAmount_BPA.Size = new System.Drawing.Size(200, 24);
            this.lblPriceBAmount_BPA.TabIndex = 66;
            this.lblPriceBAmount_BPA.Text = "Price Break Amount ";
            // 
            // lblItemID_BPA
            // 
            this.lblItemID_BPA.AutoSize = true;
            this.lblItemID_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemID_BPA.Location = new System.Drawing.Point(22, 108);
            this.lblItemID_BPA.Name = "lblItemID_BPA";
            this.lblItemID_BPA.Size = new System.Drawing.Size(77, 24);
            this.lblItemID_BPA.TabIndex = 65;
            this.lblItemID_BPA.Text = "Item ID";
            // 
            // lblAmountAgreed_BPA
            // 
            this.lblAmountAgreed_BPA.AutoSize = true;
            this.lblAmountAgreed_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountAgreed_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmountAgreed_BPA.Location = new System.Drawing.Point(22, 191);
            this.lblAmountAgreed_BPA.Name = "lblAmountAgreed_BPA";
            this.lblAmountAgreed_BPA.Size = new System.Drawing.Size(150, 24);
            this.lblAmountAgreed_BPA.TabIndex = 64;
            this.lblAmountAgreed_BPA.Text = "Amount Agreed";
            // 
            // lblAmountDelivered_BPA
            // 
            this.lblAmountDelivered_BPA.AutoSize = true;
            this.lblAmountDelivered_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDelivered_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmountDelivered_BPA.Location = new System.Drawing.Point(22, 228);
            this.lblAmountDelivered_BPA.Name = "lblAmountDelivered_BPA";
            this.lblAmountDelivered_BPA.Size = new System.Drawing.Size(174, 24);
            this.lblAmountDelivered_BPA.TabIndex = 63;
            this.lblAmountDelivered_BPA.Text = "Amount Delivered";
            // 
            // lblUnitPrice_BPA
            // 
            this.lblUnitPrice_BPA.AutoSize = true;
            this.lblUnitPrice_BPA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice_BPA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitPrice_BPA.Location = new System.Drawing.Point(22, 260);
            this.lblUnitPrice_BPA.Name = "lblUnitPrice_BPA";
            this.lblUnitPrice_BPA.Size = new System.Drawing.Size(101, 24);
            this.lblUnitPrice_BPA.TabIndex = 62;
            this.lblUnitPrice_BPA.Text = "Unit Price";
            // 
            // txtBPAID
            // 
            this.txtBPAID.Location = new System.Drawing.Point(234, 67);
            this.txtBPAID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBPAID.Name = "txtBPAID";
            this.txtBPAID.ReadOnly = true;
            this.txtBPAID.Size = new System.Drawing.Size(188, 20);
            this.txtBPAID.TabIndex = 61;
            this.txtBPAID.TextChanged += new System.EventHandler(this.txtBPAID_TextChanged);
            // 
            // lblBPAID
            // 
            this.lblBPAID.AutoSize = true;
            this.lblBPAID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPAID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBPAID.Location = new System.Drawing.Point(22, 63);
            this.lblBPAID.Name = "lblBPAID";
            this.lblBPAID.Size = new System.Drawing.Size(75, 24);
            this.lblBPAID.TabIndex = 60;
            this.lblBPAID.Text = "BPA ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNewItemID_PPO);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtUnitPrice_PPO);
            this.tabPage3.Controls.Add(this.txtQuantity_PPO);
            this.tabPage3.Controls.Add(this.lblUnitPrice_PPO);
            this.tabPage3.Controls.Add(this.lblQuantity_PPO);
            this.tabPage3.Controls.Add(this.txtItemID_PPO);
            this.tabPage3.Controls.Add(this.ppoItemTable);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btnEdit_PPO);
            this.tabPage3.Controls.Add(this.btnCancel_PPO);
            this.tabPage3.Controls.Add(this.lblItemID_PPO);
            this.tabPage3.Controls.Add(this.txtPPOID);
            this.tabPage3.Controls.Add(this.lblPPOID);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(798, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Planned Purchase Order";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNewItemID_PPO
            // 
            this.txtNewItemID_PPO.Location = new System.Drawing.Point(236, 236);
            this.txtNewItemID_PPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewItemID_PPO.Name = "txtNewItemID_PPO";
            this.txtNewItemID_PPO.Size = new System.Drawing.Size(188, 20);
            this.txtNewItemID_PPO.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "New Item ID";
            // 
            // txtUnitPrice_PPO
            // 
            this.txtUnitPrice_PPO.Location = new System.Drawing.Point(234, 423);
            this.txtUnitPrice_PPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice_PPO.Name = "txtUnitPrice_PPO";
            this.txtUnitPrice_PPO.Size = new System.Drawing.Size(188, 20);
            this.txtUnitPrice_PPO.TabIndex = 106;
            // 
            // txtQuantity_PPO
            // 
            this.txtQuantity_PPO.Location = new System.Drawing.Point(234, 332);
            this.txtQuantity_PPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity_PPO.Name = "txtQuantity_PPO";
            this.txtQuantity_PPO.Size = new System.Drawing.Size(188, 20);
            this.txtQuantity_PPO.TabIndex = 105;
            // 
            // lblUnitPrice_PPO
            // 
            this.lblUnitPrice_PPO.AutoSize = true;
            this.lblUnitPrice_PPO.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice_PPO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitPrice_PPO.Location = new System.Drawing.Point(22, 417);
            this.lblUnitPrice_PPO.Name = "lblUnitPrice_PPO";
            this.lblUnitPrice_PPO.Size = new System.Drawing.Size(101, 24);
            this.lblUnitPrice_PPO.TabIndex = 104;
            this.lblUnitPrice_PPO.Text = "Unit Price";
            // 
            // lblQuantity_PPO
            // 
            this.lblQuantity_PPO.AutoSize = true;
            this.lblQuantity_PPO.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity_PPO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity_PPO.Location = new System.Drawing.Point(22, 324);
            this.lblQuantity_PPO.Name = "lblQuantity_PPO";
            this.lblQuantity_PPO.Size = new System.Drawing.Size(88, 24);
            this.lblQuantity_PPO.TabIndex = 103;
            this.lblQuantity_PPO.Text = "Quantity";
            // 
            // txtItemID_PPO
            // 
            this.txtItemID_PPO.Location = new System.Drawing.Point(234, 158);
            this.txtItemID_PPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemID_PPO.Name = "txtItemID_PPO";
            this.txtItemID_PPO.ReadOnly = true;
            this.txtItemID_PPO.Size = new System.Drawing.Size(188, 20);
            this.txtItemID_PPO.TabIndex = 102;
            // 
            // ppoItemTable
            // 
            this.ppoItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ppoItemTable.Location = new System.Drawing.Point(441, 39);
            this.ppoItemTable.Name = "ppoItemTable";
            this.ppoItemTable.RowHeadersWidth = 51;
            this.ppoItemTable.RowTemplate.Height = 24;
            this.ppoItemTable.Size = new System.Drawing.Size(339, 384);
            this.ppoItemTable.TabIndex = 99;
            this.ppoItemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ppoItemTable_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(22, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(252, 24);
            this.label14.TabIndex = 96;
            this.label14.Text = "Purchase Order Revision:";
            // 
            // btnEdit_PPO
            // 
            this.btnEdit_PPO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit_PPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_PPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_PPO.ForeColor = System.Drawing.Color.Black;
            this.btnEdit_PPO.Location = new System.Drawing.Point(646, 465);
            this.btnEdit_PPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit_PPO.Name = "btnEdit_PPO";
            this.btnEdit_PPO.Size = new System.Drawing.Size(134, 38);
            this.btnEdit_PPO.TabIndex = 95;
            this.btnEdit_PPO.Text = "Edit";
            this.btnEdit_PPO.UseVisualStyleBackColor = false;
            this.btnEdit_PPO.Click += new System.EventHandler(this.btnEdit_PPO_Click);
            // 
            // btnCancel_PPO
            // 
            this.btnCancel_PPO.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel_PPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_PPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_PPO.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel_PPO.Location = new System.Drawing.Point(441, 465);
            this.btnCancel_PPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel_PPO.Name = "btnCancel_PPO";
            this.btnCancel_PPO.Size = new System.Drawing.Size(134, 38);
            this.btnCancel_PPO.TabIndex = 94;
            this.btnCancel_PPO.Text = "Cancel";
            this.btnCancel_PPO.UseVisualStyleBackColor = false;
            this.btnCancel_PPO.Click += new System.EventHandler(this.btnCancel_PPO_Click);
            // 
            // lblItemID_PPO
            // 
            this.lblItemID_PPO.AutoSize = true;
            this.lblItemID_PPO.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID_PPO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemID_PPO.Location = new System.Drawing.Point(22, 158);
            this.lblItemID_PPO.Name = "lblItemID_PPO";
            this.lblItemID_PPO.Size = new System.Drawing.Size(77, 24);
            this.lblItemID_PPO.TabIndex = 87;
            this.lblItemID_PPO.Text = "Item ID";
            // 
            // txtPPOID
            // 
            this.txtPPOID.Location = new System.Drawing.Point(234, 84);
            this.txtPPOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPPOID.Name = "txtPPOID";
            this.txtPPOID.ReadOnly = true;
            this.txtPPOID.Size = new System.Drawing.Size(188, 20);
            this.txtPPOID.TabIndex = 83;
            this.txtPPOID.TextChanged += new System.EventHandler(this.txtPPOID_TextChanged);
            // 
            // lblPPOID
            // 
            this.lblPPOID.AutoSize = true;
            this.lblPPOID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPOID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPPOID.Location = new System.Drawing.Point(22, 84);
            this.lblPPOID.Name = "lblPPOID";
            this.lblPPOID.Size = new System.Drawing.Size(81, 24);
            this.lblPPOID.TabIndex = 82;
            this.lblPPOID.Text = "PPO ID";
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
            this.panel1.TabIndex = 105;
            // 
            // btnCA
            // 
            this.btnCA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCA.ForeColor = System.Drawing.Color.Black;
            this.btnCA.Location = new System.Drawing.Point(12, 426);
            this.btnCA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(203, 38);
            this.btnCA.TabIndex = 106;
            this.btnCA.Text = "Create Agreement";
            this.btnCA.UseVisualStyleBackColor = false;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click_1);
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
            // FrmEditAgreeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControlCPA);
            this.Name = "FrmEditAgreeItem";
            this.Text = "Edit Agreement Item";
            this.Load += new System.EventHandler(this.FrmEditAgreement_Load);
            this.tabControlCPA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpaItemTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpaItemTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppoItemTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControlCPA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtItemID_CPA;
        private System.Windows.Forms.DataGridView cpaItemTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit_CPA;
        private System.Windows.Forms.Label lblItemID_CPA;
        private System.Windows.Forms.TextBox txtCPAID;
        private System.Windows.Forms.Label lblCPAID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAmountAgreed_BPA;
        private System.Windows.Forms.TextBox txtItemID_BPA;
        private System.Windows.Forms.DateTimePicker dateTimePickerBPA;
        private System.Windows.Forms.TextBox txtDiscount_BPA;
        private System.Windows.Forms.DataGridView bpaItemTable;
        private System.Windows.Forms.Label lblPriceBEffectiveDate_BPA;
        private System.Windows.Forms.Label lblDiscount_BPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit_BPA;
        private System.Windows.Forms.Button btnCancel_BPA;
        private System.Windows.Forms.TextBox txtPriceBAmount_BPA;
        private System.Windows.Forms.TextBox txtlCurrency_BPA;
        private System.Windows.Forms.TextBox txtUnitPrice_BPA;
        private System.Windows.Forms.TextBox txtAmountDelivered_BPA;
        private System.Windows.Forms.Label lblCurrency_BPA;
        private System.Windows.Forms.Label lblPriceBAmount_BPA;
        private System.Windows.Forms.Label lblItemID_BPA;
        private System.Windows.Forms.Label lblAmountAgreed_BPA;
        private System.Windows.Forms.Label lblAmountDelivered_BPA;
        private System.Windows.Forms.Label lblUnitPrice_BPA;
        private System.Windows.Forms.TextBox txtBPAID;
        private System.Windows.Forms.Label lblBPAID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtUnitPrice_PPO;
        private System.Windows.Forms.TextBox txtQuantity_PPO;
        private System.Windows.Forms.Label lblUnitPrice_PPO;
        private System.Windows.Forms.Label lblQuantity_PPO;
        private System.Windows.Forms.TextBox txtItemID_PPO;
        private System.Windows.Forms.DataGridView ppoItemTable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEdit_PPO;
        private System.Windows.Forms.Button btnCancel_PPO;
        private System.Windows.Forms.Label lblItemID_PPO;
        private System.Windows.Forms.TextBox txtPPOID;
        private System.Windows.Forms.Label lblPPOID;
        private System.Windows.Forms.Button btnCancel_CPA;
        private System.Windows.Forms.TextBox txtNewItemID_BPA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewItemID_CPA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewItemID_PPO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCAI;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCA;
    }
}