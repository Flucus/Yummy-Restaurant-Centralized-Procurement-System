﻿namespace YummyRestaurantSystem
{
    partial class FrmCreateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateItem));
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVID = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSupplierItemID = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSupplierItemID = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(412, 30);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(343, 24);
            this.lblRestaurant.TabIndex = 6;
            this.lblRestaurant.Text = "The Yummy Restaurant Create Item";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(603, 270);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 32;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(412, 263);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 24);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Item Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategory.Location = new System.Drawing.Point(412, 317);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 24);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "Category";
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(603, 324);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(277, 21);
            this.cboCat.TabIndex = 34;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(603, 382);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 20);
            this.txtDescription.TabIndex = 36;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescription.Location = new System.Drawing.Point(412, 376);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 24);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(729, 502);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(134, 38);
            this.btnCreate.TabIndex = 37;
            this.btnCreate.Text = "Create Item";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(416, 502);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 38);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnVID);
            this.panel1.Controls.Add(this.btnCM);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 645);
            this.panel1.TabIndex = 101;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 421);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 38);
            this.button1.TabIndex = 105;
            this.button1.Text = "Item Manage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVID
            // 
            this.btnVID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVID.ForeColor = System.Drawing.Color.Black;
            this.btnVID.Location = new System.Drawing.Point(12, 357);
            this.btnVID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVID.Name = "btnVID";
            this.btnVID.Size = new System.Drawing.Size(203, 38);
            this.btnVID.TabIndex = 104;
            this.btnVID.Text = "Vitural ID Mapping";
            this.btnVID.UseVisualStyleBackColor = false;
            this.btnVID.Click += new System.EventHandler(this.btnVID_Click);
            // 
            // btnCM
            // 
            this.btnCM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCM.ForeColor = System.Drawing.Color.Black;
            this.btnCM.Location = new System.Drawing.Point(12, 295);
            this.btnCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(203, 38);
            this.btnCM.TabIndex = 103;
            this.btnCM.Text = "Category Manage";
            this.btnCM.UseVisualStyleBackColor = false;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 608);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 102;
            this.lblTime.Text = "Time";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(144, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 38);
            this.button4.TabIndex = 93;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSupplierItemID
            // 
            this.lblSupplierItemID.AutoSize = true;
            this.lblSupplierItemID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierItemID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierItemID.Location = new System.Drawing.Point(412, 199);
            this.lblSupplierItemID.Name = "lblSupplierItemID";
            this.lblSupplierItemID.Size = new System.Drawing.Size(158, 24);
            this.lblSupplierItemID.TabIndex = 102;
            this.lblSupplierItemID.Text = "Supplier Item ID";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSupplierID.Location = new System.Drawing.Point(412, 138);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(112, 24);
            this.lblSupplierID.TabIndex = 103;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // txtSupplierItemID
            // 
            this.txtSupplierItemID.Location = new System.Drawing.Point(603, 199);
            this.txtSupplierItemID.Name = "txtSupplierItemID";
            this.txtSupplierItemID.Size = new System.Drawing.Size(277, 20);
            this.txtSupplierItemID.TabIndex = 104;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(603, 138);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(277, 20);
            this.txtSupplierID.TabIndex = 105;
            // 
            // FrmCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 645);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.txtSupplierItemID);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblSupplierItemID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRestaurant);
            this.Name = "FrmCreateItem";
            this.Text = "Create Item";
            this.Load += new System.EventHandler(this.FrmCreateItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVID;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.Label lblSupplierItemID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtSupplierItemID;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button button1;
    }
}