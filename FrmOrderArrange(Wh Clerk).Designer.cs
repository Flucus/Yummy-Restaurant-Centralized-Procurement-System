
namespace YummyRestaurantSystem
{
    partial class FrmOrderArrange_Wh_Clerk_
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.btndetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnaccept = new System.Windows.Forms.Button();
            this.btnship = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 313);
            this.dataGridView1.TabIndex = 28;
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(8, 9);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(364, 24);
            this.lblRestaurant.TabIndex = 29;
            this.lblRestaurant.Text = "The Yummy Restaurant Order Arrange\r\n";
            // 
            // btndetail
            // 
            this.btndetail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetail.ForeColor = System.Drawing.Color.Black;
            this.btndetail.Location = new System.Drawing.Point(497, 355);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(134, 35);
            this.btndetail.TabIndex = 31;
            this.btndetail.Text = "Detail";
            this.btndetail.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(12, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 35);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnaccept
            // 
            this.btnaccept.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccept.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccept.ForeColor = System.Drawing.Color.Black;
            this.btnaccept.Location = new System.Drawing.Point(311, 355);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(134, 35);
            this.btnaccept.TabIndex = 33;
            this.btnaccept.Text = "Accept ";
            this.btnaccept.UseVisualStyleBackColor = false;
            // 
            // btnship
            // 
            this.btnship.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnship.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnship.ForeColor = System.Drawing.Color.Black;
            this.btnship.Location = new System.Drawing.Point(650, 355);
            this.btnship.Name = "btnship";
            this.btnship.Size = new System.Drawing.Size(134, 35);
            this.btnship.TabIndex = 34;
            this.btnship.Text = "Ship";
            this.btnship.UseVisualStyleBackColor = false;
            // 
            // FrmOrderArrange_Wh_Clerk_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.btnship);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOrderArrange_Wh_Clerk_";
            this.Text = "FrmOrderArrange_Wh_Clerk_";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.Button btnship;
    }
}