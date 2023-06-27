
namespace YummyRestaurantSystem.src.WC
{
    partial class FrmCheckUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblUoM = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.txtLocID = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.btnRDI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRDI);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnIM);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 595);
            this.panel1.TabIndex = 104;
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
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(443, 300);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(188, 22);
            this.txtCount.TabIndex = 136;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(257, 452);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 35);
            this.btnCancel.TabIndex = 135;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(509, 452);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 35);
            this.btnUpdate.TabIndex = 134;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOrderID.Location = new System.Drawing.Point(253, 142);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(72, 24);
            this.lblOrderID.TabIndex = 132;
            this.lblOrderID.Text = "Loc ID";
            // 
            // lblUoM
            // 
            this.lblUoM.AutoSize = true;
            this.lblUoM.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUoM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUoM.Location = new System.Drawing.Point(253, 298);
            this.lblUoM.Name = "lblUoM";
            this.lblUoM.Size = new System.Drawing.Size(65, 24);
            this.lblUoM.TabIndex = 131;
            this.lblUoM.Text = "Count";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemID.Location = new System.Drawing.Point(253, 217);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(77, 24);
            this.lblItemID.TabIndex = 130;
            this.lblItemID.Text = "Item ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(710, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 393);
            this.dataGridView1.TabIndex = 127;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(253, 28);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(305, 24);
            this.lblRestaurant.TabIndex = 126;
            this.lblRestaurant.Text = "Check / Update Inventory Stock";
            // 
            // txtLocID
            // 
            this.txtLocID.Location = new System.Drawing.Point(443, 144);
            this.txtLocID.Name = "txtLocID";
            this.txtLocID.ReadOnly = true;
            this.txtLocID.Size = new System.Drawing.Size(188, 22);
            this.txtLocID.TabIndex = 138;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(443, 217);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(188, 22);
            this.txtItemID.TabIndex = 139;
            // 
            // btnRDI
            // 
            this.btnRDI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRDI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDI.ForeColor = System.Drawing.Color.Black;
            this.btnRDI.Location = new System.Drawing.Point(12, 348);
            this.btnRDI.Name = "btnRDI";
            this.btnRDI.Size = new System.Drawing.Size(203, 52);
            this.btnRDI.TabIndex = 100;
            this.btnRDI.Text = "Receive Despatch Instruction";
            this.btnRDI.UseVisualStyleBackColor = false;
            // 
            // FrmCheckUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtLocID);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblUoM);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCheckUpdate";
            this.Text = "Check / Update Inventory Stock";
            this.Load += new System.EventHandler(this.FrmCheckUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblUoM;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.TextBox txtLocID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Button btnRDI;
    }
}