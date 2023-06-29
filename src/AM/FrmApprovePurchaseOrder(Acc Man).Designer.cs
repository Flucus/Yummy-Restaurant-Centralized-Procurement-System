
namespace YummyRestaurantSystem.src.AM
{
    partial class FrmApprovePurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApprovePurchaseOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCDN = new System.Windows.Forms.Button();
            this.btnVDN = new System.Windows.Forms.Button();
            this.btnAPO = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTile = new System.Windows.Forms.Label();
            this.btnConifrm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCDN);
            this.panel1.Controls.Add(this.btnVDN);
            this.panel1.Controls.Add(this.btnAPO);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 102;
            // 
            // btnCDN
            // 
            this.btnCDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDN.ForeColor = System.Drawing.Color.Black;
            this.btnCDN.Location = new System.Drawing.Point(16, 524);
            this.btnCDN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCDN.Name = "btnCDN";
            this.btnCDN.Size = new System.Drawing.Size(284, 44);
            this.btnCDN.TabIndex = 105;
            this.btnCDN.Text = "Create Delivery Note";
            this.btnCDN.UseVisualStyleBackColor = false;
            this.btnCDN.Click += new System.EventHandler(this.btnCDN_Click);
            // 
            // btnVDN
            // 
            this.btnVDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDN.ForeColor = System.Drawing.Color.Black;
            this.btnVDN.Location = new System.Drawing.Point(16, 438);
            this.btnVDN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnVDN.Name = "btnVDN";
            this.btnVDN.Size = new System.Drawing.Size(284, 44);
            this.btnVDN.TabIndex = 104;
            this.btnVDN.Text = "View Delivery Note";
            this.btnVDN.UseVisualStyleBackColor = false;
            this.btnVDN.Click += new System.EventHandler(this.btnVDN_Click);
            // 
            // btnAPO
            // 
            this.btnAPO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPO.ForeColor = System.Drawing.Color.Black;
            this.btnAPO.Location = new System.Drawing.Point(16, 360);
            this.btnAPO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAPO.Name = "btnAPO";
            this.btnAPO.Size = new System.Drawing.Size(284, 44);
            this.btnAPO.TabIndex = 103;
            this.btnAPO.Text = "Approve PurchaseOrder";
            this.btnAPO.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(192, 685);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 44);
            this.button4.TabIndex = 97;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 702);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 218);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(333, 35);
            this.lblTile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(313, 32);
            this.lblTile.TabIndex = 105;
            this.lblTile.Text = "Approve Purchase Order";
            // 
            // btnConifrm
            // 
            this.btnConifrm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConifrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConifrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConifrm.ForeColor = System.Drawing.Color.Black;
            this.btnConifrm.Location = new System.Drawing.Point(1233, 645);
            this.btnConifrm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnConifrm.Name = "btnConifrm";
            this.btnConifrm.Size = new System.Drawing.Size(179, 44);
            this.btnConifrm.TabIndex = 135;
            this.btnConifrm.Text = "Conifrm";
            this.btnConifrm.UseVisualStyleBackColor = false;
            this.btnConifrm.Click += new System.EventHandler(this.btnConifrm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(832, 645);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 44);
            this.btnCancel.TabIndex = 136;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 404);
            this.dataGridView1.TabIndex = 137;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(540, 112);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(249, 25);
            this.txtOrderID.TabIndex = 139;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderID.Location = new System.Drawing.Point(333, 112);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(119, 32);
            this.lblOrderID.TabIndex = 138;
            this.lblOrderID.Text = "Order ID";
            // 
            // FrmApprovePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConifrm);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmApprovePurchaseOrder";
            this.Text = "Approve Purchase Order";
            this.Load += new System.EventHandler(this.FrmUpdatePurchaseOrder_Acc_Man__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Button btnConifrm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnCDN;
        private System.Windows.Forms.Button btnVDN;
        private System.Windows.Forms.Button btnAPO;
    }
}