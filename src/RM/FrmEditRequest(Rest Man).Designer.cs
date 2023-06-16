
namespace YummyRestaurantSystem
{
    partial class FrmEditRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditRequest));
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.itemTable = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnOP = new System.Windows.Forms.Button();
            this.btnIM = new System.Windows.Forms.Button();
            this.logutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(356, 35);
            this.lblRestaurant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(318, 32);
            this.lblRestaurant.TabIndex = 61;
            this.lblRestaurant.Text = "[restaurant] Edit Request";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(573, 325);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(228, 25);
            this.txtQuantity.TabIndex = 79;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.Location = new System.Drawing.Point(356, 325);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(116, 32);
            this.lblQuantity.TabIndex = 78;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(573, 263);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(228, 25);
            this.txtItemID.TabIndex = 77;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemID.Location = new System.Drawing.Point(356, 263);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(103, 32);
            this.lblItemID.TabIndex = 76;
            this.lblItemID.Text = "Item ID";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(573, 194);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(228, 25);
            this.txtItemName.TabIndex = 75;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemName.Location = new System.Drawing.Point(356, 194);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(146, 32);
            this.lblItemName.TabIndex = 74;
            this.lblItemName.Text = "Item Name";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemark.Location = new System.Drawing.Point(356, 402);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(109, 32);
            this.lblRemark.TabIndex = 80;
            this.lblRemark.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(573, 402);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(228, 25);
            this.txtRemark.TabIndex = 81;
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRequestID.Location = new System.Drawing.Point(356, 128);
            this.lblRequestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(152, 32);
            this.lblRequestID.TabIndex = 82;
            this.lblRequestID.Text = "Request ID";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(573, 128);
            this.txtRequestID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.ReadOnly = true;
            this.txtRequestID.Size = new System.Drawing.Size(228, 25);
            this.txtRequestID.TabIndex = 83;
            // 
            // itemTable
            // 
            this.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTable.Location = new System.Drawing.Point(848, 128);
            this.itemTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemTable.Name = "itemTable";
            this.itemTable.RowHeadersWidth = 51;
            this.itemTable.Size = new System.Drawing.Size(564, 410);
            this.itemTable.TabIndex = 84;
            this.itemTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemTable_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(700, 500);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 37);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemove.Location = new System.Drawing.Point(563, 500);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 37);
            this.btnRemove.TabIndex = 85;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(1204, 662);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 44);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCR);
            this.panel1.Controls.Add(this.btnOP);
            this.panel1.Controls.Add(this.btnIM);
            this.panel1.Controls.Add(this.logutBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 101;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 702);
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
            this.btnCR.Location = new System.Drawing.Point(16, 477);
            this.btnCR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btnOP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btnIM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(271, 44);
            this.btnIM.TabIndex = 94;
            this.btnIM.Text = "Inventory Manage";
            this.btnIM.UseVisualStyleBackColor = false;
            this.btnIM.Click += new System.EventHandler(this.btnIM_Click);
            // 
            // logutBtn
            // 
            this.logutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.logutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logutBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logutBtn.Location = new System.Drawing.Point(169, 685);
            this.logutBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logutBtn.Name = "logutBtn";
            this.logutBtn.Size = new System.Drawing.Size(117, 44);
            this.logutBtn.TabIndex = 93;
            this.logutBtn.Text = "Logout";
            this.logutBtn.UseVisualStyleBackColor = false;
            this.logutBtn.Click += new System.EventHandler(this.logutBtn_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmEditRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.itemTable);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEditRequest";
            this.Text = "Edit Request";
            this.Load += new System.EventHandler(this.FrmEditRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.DataGridView itemTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCR;
        private System.Windows.Forms.Button btnOP;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button logutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}