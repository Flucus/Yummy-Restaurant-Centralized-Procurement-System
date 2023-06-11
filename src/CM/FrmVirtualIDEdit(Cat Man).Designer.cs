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
            this.lblName = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtVID = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnVID = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(419, 30);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(360, 24);
            this.lblRestaurant.TabIndex = 6;
            this.lblRestaurant.Text = "The Yummy Restaurant Virtual ID Edit";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(459, 374);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 24);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Item Name";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItem.Location = new System.Drawing.Point(459, 309);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(77, 24);
            this.lblItem.TabIndex = 47;
            this.lblItem.Text = "Item ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(311, 549);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 38);
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
            this.btnEdit.Location = new System.Drawing.Point(866, 549);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 38);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblType.Location = new System.Drawing.Point(459, 189);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(115, 24);
            this.lblType.TabIndex = 44;
            this.lblType.Text = "Type Name";
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVID.Location = new System.Drawing.Point(459, 248);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(95, 24);
            this.lblVID.TabIndex = 43;
            this.lblVID.Text = "Virtual ID";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(639, 374);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(121, 20);
            this.txtItemName.TabIndex = 108;
            // 
            // txtVID
            // 
            this.txtVID.Location = new System.Drawing.Point(639, 248);
            this.txtVID.Name = "txtVID";
            this.txtVID.ReadOnly = true;
            this.txtVID.Size = new System.Drawing.Size(121, 20);
            this.txtVID.TabIndex = 107;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(639, 309);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 20);
            this.txtItemID.TabIndex = 106;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 645);
            this.panel1.TabIndex = 110;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 608);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 111;
            this.lblTime.Text = "Time";
            // 
            // btnVID
            // 
            this.btnVID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVID.ForeColor = System.Drawing.Color.Black;
            this.btnVID.Location = new System.Drawing.Point(12, 353);
            this.btnVID.Name = "btnVID";
            this.btnVID.Size = new System.Drawing.Size(203, 38);
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
            this.btnCM.Location = new System.Drawing.Point(12, 290);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(203, 38);
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
            this.btnLogout.Location = new System.Drawing.Point(146, 594);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(69, 38);
            this.btnLogout.TabIndex = 93;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 188);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(639, 195);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.ReadOnly = true;
            this.txtTypeName.Size = new System.Drawing.Size(121, 20);
            this.txtTypeName.TabIndex = 111;
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(639, 133);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.ReadOnly = true;
            this.txtTypeID.Size = new System.Drawing.Size(121, 20);
            this.txtTypeID.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(459, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 112;
            this.label1.Text = "Type ID";
            // 
            // FrmVirtualIDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtVID);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.lblRestaurant);
            this.Name = "FrmVirtualIDEdit";
            this.Text = "Virtual ID Edit";
            this.Load += new System.EventHandler(this.FrmVirtualIDEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtVID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVID;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label label1;
    }
}