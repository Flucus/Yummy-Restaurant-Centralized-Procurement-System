
namespace YummyRestaurantSystem.src.AM
{
    partial class FrmDeliveryNoteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryNoteView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTile = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNoteID = new System.Windows.Forms.Label();
            this.txtNoteID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocID = new System.Windows.Forms.TextBox();
            this.lblDeliveryNote = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCDN = new System.Windows.Forms.Button();
            this.btnVDN = new System.Windows.Forms.Button();
            this.btnAPO = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 595);
            this.panel1.TabIndex = 104;
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
            this.button4.TabIndex = 97;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
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
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTile.Location = new System.Drawing.Point(280, 28);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(188, 24);
            this.lblTile.TabIndex = 107;
            this.lblTile.Text = "View Delivery Note";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 352);
            this.dataGridView1.TabIndex = 108;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(898, 28);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 35);
            this.btnClose.TabIndex = 109;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblNoteID
            // 
            this.lblNoteID.AutoSize = true;
            this.lblNoteID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNoteID.Location = new System.Drawing.Point(280, 84);
            this.lblNoteID.Name = "lblNoteID";
            this.lblNoteID.Size = new System.Drawing.Size(81, 24);
            this.lblNoteID.TabIndex = 110;
            this.lblNoteID.Text = "Note ID";
            // 
            // txtNoteID
            // 
            this.txtNoteID.Location = new System.Drawing.Point(435, 84);
            this.txtNoteID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoteID.Name = "txtNoteID";
            this.txtNoteID.Size = new System.Drawing.Size(217, 22);
            this.txtNoteID.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(280, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Loc ID";
            // 
            // txtLocID
            // 
            this.txtLocID.Location = new System.Drawing.Point(435, 138);
            this.txtLocID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocID.Name = "txtLocID";
            this.txtLocID.Size = new System.Drawing.Size(217, 22);
            this.txtLocID.TabIndex = 114;
            // 
            // lblDeliveryNote
            // 
            this.lblDeliveryNote.AutoSize = true;
            this.lblDeliveryNote.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDeliveryNote.Location = new System.Drawing.Point(280, 188);
            this.lblDeliveryNote.Name = "lblDeliveryNote";
            this.lblDeliveryNote.Size = new System.Drawing.Size(137, 24);
            this.lblDeliveryNote.TabIndex = 115;
            this.lblDeliveryNote.Text = "Delivery Note";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(435, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker1.TabIndex = 116;
            // 
            // btnCDN
            // 
            this.btnCDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDN.ForeColor = System.Drawing.Color.Black;
            this.btnCDN.Location = new System.Drawing.Point(12, 418);
            this.btnCDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCDN.Name = "btnCDN";
            this.btnCDN.Size = new System.Drawing.Size(213, 35);
            this.btnCDN.TabIndex = 105;
            this.btnCDN.Text = "Create Delivery Note";
            this.btnCDN.UseVisualStyleBackColor = false;
            // 
            // btnVDN
            // 
            this.btnVDN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDN.ForeColor = System.Drawing.Color.Black;
            this.btnVDN.Location = new System.Drawing.Point(12, 350);
            this.btnVDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVDN.Name = "btnVDN";
            this.btnVDN.Size = new System.Drawing.Size(213, 35);
            this.btnVDN.TabIndex = 104;
            this.btnVDN.Text = "View Delivery Note";
            this.btnVDN.UseVisualStyleBackColor = false;
            // 
            // btnAPO
            // 
            this.btnAPO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPO.ForeColor = System.Drawing.Color.Black;
            this.btnAPO.Location = new System.Drawing.Point(12, 287);
            this.btnAPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAPO.Name = "btnAPO";
            this.btnAPO.Size = new System.Drawing.Size(213, 35);
            this.btnAPO.TabIndex = 103;
            this.btnAPO.Text = "Approve PurchaseOrder";
            this.btnAPO.UseVisualStyleBackColor = false;
            // 
            // FrmDeliveryNoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 595);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDeliveryNote);
            this.Controls.Add(this.txtLocID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoteID);
            this.Controls.Add(this.lblNoteID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDeliveryNoteView";
            this.Text = "FrmDeliveryNoteView";
            this.Load += new System.EventHandler(this.FrmDeliveryNoteView_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNoteID;
        private System.Windows.Forms.TextBox txtNoteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocID;
        private System.Windows.Forms.Label lblDeliveryNote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCDN;
        private System.Windows.Forms.Button btnVDN;
        private System.Windows.Forms.Button btnAPO;
    }
}