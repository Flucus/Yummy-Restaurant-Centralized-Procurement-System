﻿
namespace YummyRestaurantSystem.src.WC
{
    partial class FrmGenerateDeliveryNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerateDeliveryNote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRDI = new System.Windows.Forms.Button();
            this.btnGDN = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnOA = new System.Windows.Forms.Button();
            this.btnIM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRDI);
            this.panel1.Controls.Add(this.btnGDN);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnOA);
            this.panel1.Controls.Add(this.btnIM);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 595);
            this.panel1.TabIndex = 103;
            // 
            // btnRDI
            // 
            this.btnRDI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRDI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDI.ForeColor = System.Drawing.Color.Black;
            this.btnRDI.Location = new System.Drawing.Point(12, 452);
            this.btnRDI.Name = "btnRDI";
            this.btnRDI.Size = new System.Drawing.Size(203, 35);
            this.btnRDI.TabIndex = 100;
            this.btnRDI.Text = "Receive Despatch";
            this.btnRDI.UseVisualStyleBackColor = false;
            // 
            // btnGDN
            // 
            this.btnGDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGDN.ForeColor = System.Drawing.Color.Black;
            this.btnGDN.Location = new System.Drawing.Point(12, 390);
            this.btnGDN.Name = "btnGDN";
            this.btnGDN.Size = new System.Drawing.Size(203, 35);
            this.btnGDN.TabIndex = 97;
            this.btnGDN.Text = "Generate Note";
            this.btnGDN.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 561);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // btnOA
            // 
            this.btnOA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOA.ForeColor = System.Drawing.Color.Black;
            this.btnOA.Location = new System.Drawing.Point(12, 326);
            this.btnOA.Name = "btnOA";
            this.btnOA.Size = new System.Drawing.Size(203, 35);
            this.btnOA.TabIndex = 95;
            this.btnOA.Text = "Order Arrange";
            this.btnOA.UseVisualStyleBackColor = false;
            // 
            // btnIM
            // 
            this.btnIM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIM.ForeColor = System.Drawing.Color.Black;
            this.btnIM.Location = new System.Drawing.Point(12, 268);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(203, 35);
            this.btnIM.TabIndex = 94;
            this.btnIM.Text = "Inventory Manage";
            this.btnIM.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(144, 548);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 35);
            this.button4.TabIndex = 93;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 174);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(269, 28);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(432, 24);
            this.lblRestaurant.TabIndex = 104;
            this.lblRestaurant.Text = "The Yummy Restaurant Logistic Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(269, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "Generate Delivery Note";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 326);
            this.dataGridView1.TabIndex = 106;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(273, 538);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 35);
            this.btnCancel.TabIndex = 107;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(897, 538);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(134, 35);
            this.btnGenerate.TabIndex = 108;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmGenerateDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGenerateDeliveryNote";
            this.Text = "Generate Delivery Note";
            this.Load += new System.EventHandler(this.FrmGenerateDeliveryNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGDN;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnOA;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnRDI;
        private System.Windows.Forms.Timer timer1;
    }
}