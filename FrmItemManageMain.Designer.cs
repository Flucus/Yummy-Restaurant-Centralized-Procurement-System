namespace YummyRestaurantSystem
{
    partial class FrmItemManagementMain
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
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.btnItemManage = new System.Windows.Forms.Button();
            this.btnCategoryManage = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(12, 9);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(353, 24);
            this.lblRestaurant.TabIndex = 29;
            this.lblRestaurant.Text = "The Yummy Restaurant Management";
            // 
            // btnItemManage
            // 
            this.btnItemManage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemManage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManage.ForeColor = System.Drawing.Color.Black;
            this.btnItemManage.Location = new System.Drawing.Point(113, 63);
            this.btnItemManage.Name = "btnItemManage";
            this.btnItemManage.Size = new System.Drawing.Size(134, 38);
            this.btnItemManage.TabIndex = 33;
            this.btnItemManage.Text = "Item Manage";
            this.btnItemManage.UseVisualStyleBackColor = false;
            // 
            // btnCategoryManage
            // 
            this.btnCategoryManage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategoryManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManage.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryManage.Location = new System.Drawing.Point(113, 117);
            this.btnCategoryManage.Name = "btnCategoryManage";
            this.btnCategoryManage.Size = new System.Drawing.Size(134, 38);
            this.btnCategoryManage.TabIndex = 34;
            this.btnCategoryManage.Text = "Category Manage";
            this.btnCategoryManage.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Black;
            this.btnStock.Location = new System.Drawing.Point(113, 170);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(134, 38);
            this.btnStock.TabIndex = 35;
            this.btnStock.Text = "Stock Manage";
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.ForeColor = System.Drawing.Color.Black;
            this.btnMap.Location = new System.Drawing.Point(113, 224);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(134, 38);
            this.btnMap.TabIndex = 36;
            this.btnMap.Text = "Virtual ID";
            this.btnMap.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(113, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FrmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 340);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnCategoryManage);
            this.Controls.Add(this.btnItemManage);
            this.Controls.Add(this.lblRestaurant);
            this.Name = "FrmManagement";
            this.Text = "Item Management Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Button btnItemManage;
        private System.Windows.Forms.Button btnCategoryManage;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnClose;
    }
}