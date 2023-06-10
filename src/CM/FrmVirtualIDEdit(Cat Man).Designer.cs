namespace YummyRestaurantSystem
{
    partial class FrmVirtualIDEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVirtualIDEdit));
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblVname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.txtVIName = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtVID = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnVID = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(559, 35);
            this.lblRestaurant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(475, 32);
            this.lblRestaurant.TabIndex = 6;
            this.lblRestaurant.Text = "The Yummy Restaurant Virtual ID Edit";
            // 
            // lblVname
            // 
            this.lblVname.AutoSize = true;
            this.lblVname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVname.Location = new System.Drawing.Point(603, 387);
            this.lblVname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVname.Name = "lblVname";
            this.lblVname.Size = new System.Drawing.Size(230, 32);
            this.lblVname.TabIndex = 51;
            this.lblVname.Text = "Virtual Item Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(603, 315);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 32);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Item Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(919, 524);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItem.Location = new System.Drawing.Point(603, 240);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(103, 32);
            this.lblItem.TabIndex = 47;
            this.lblItem.Text = "Item ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(415, 633);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 44);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(1155, 633);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 44);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblType.Location = new System.Drawing.Point(603, 175);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(73, 32);
            this.lblType.TabIndex = 44;
            this.lblType.Text = "Type";
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVID.Location = new System.Drawing.Point(603, 453);
            this.lblVID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(126, 32);
            this.lblVID.TabIndex = 43;
            this.lblVID.Text = "Virtual ID";
            // 
            // txtVIName
            // 
            this.txtVIName.Location = new System.Drawing.Point(843, 387);
            this.txtVIName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVIName.Name = "txtVIName";
            this.txtVIName.Size = new System.Drawing.Size(160, 25);
            this.txtVIName.TabIndex = 109;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(843, 315);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(160, 25);
            this.txtItemName.TabIndex = 108;
            // 
            // txtVID
            // 
            this.txtVID.Location = new System.Drawing.Point(843, 453);
            this.txtVID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVID.Name = "txtVID";
            this.txtVID.Size = new System.Drawing.Size(160, 25);
            this.txtVID.TabIndex = 107;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(843, 240);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(160, 25);
            this.txtItemID.TabIndex = 106;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(843, 175);
            this.cboType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(160, 23);
            this.cboType.TabIndex = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnVID);
            this.panel1.Controls.Add(this.btnCM);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 110;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 702);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 111;
            this.lblTime.Text = "Time";
            // 
            // btnVID
            // 
            this.btnVID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVID.ForeColor = System.Drawing.Color.Black;
            this.btnVID.Location = new System.Drawing.Point(16, 407);
            this.btnVID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVID.Name = "btnVID";
            this.btnVID.Size = new System.Drawing.Size(271, 44);
            this.btnVID.TabIndex = 95;
            this.btnVID.Text = "Vitural ID Mapping";
            this.btnVID.UseVisualStyleBackColor = false;
            // 
            // btnCM
            // 
            this.btnCM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCM.ForeColor = System.Drawing.Color.Black;
            this.btnCM.Location = new System.Drawing.Point(16, 335);
            this.btnCM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(271, 44);
            this.btnCM.TabIndex = 94;
            this.btnCM.Text = "Category Manage";
            this.btnCM.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(204, 685);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 44);
            this.btnLogout.TabIndex = 93;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            // FrmVirtualIDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVIName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtVID);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblVname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.lblRestaurant);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmVirtualIDEdit";
            this.Text = "Virtual ID Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblVname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.TextBox txtVIName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtVID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVID;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}