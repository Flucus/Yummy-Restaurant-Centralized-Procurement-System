namespace YummyRestaurantSystem
{
    partial class FrmMenuCatMan
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
            this.btnVIDMap = new System.Windows.Forms.Button();
            this.btnCategoryManage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHelloMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVIDMap
            // 
            this.btnVIDMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVIDMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVIDMap.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIDMap.ForeColor = System.Drawing.Color.Black;
            this.btnVIDMap.Location = new System.Drawing.Point(91, 111);
            this.btnVIDMap.Name = "btnVIDMap";
            this.btnVIDMap.Size = new System.Drawing.Size(140, 35);
            this.btnVIDMap.TabIndex = 19;
            this.btnVIDMap.Text = "Vitural ID Mapping";
            this.btnVIDMap.UseVisualStyleBackColor = false;
            // 
            // btnCategoryManage
            // 
            this.btnCategoryManage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategoryManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryManage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryManage.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryManage.Location = new System.Drawing.Point(91, 58);
            this.btnCategoryManage.Name = "btnCategoryManage";
            this.btnCategoryManage.Size = new System.Drawing.Size(140, 35);
            this.btnCategoryManage.TabIndex = 18;
            this.btnCategoryManage.Text = "Category Manage";
            this.btnCategoryManage.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(195, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 31);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(11, 12);
            this.lblHelloMsg.Name = "lblHelloMsg";
            this.lblHelloMsg.Size = new System.Drawing.Size(178, 24);
            this.lblHelloMsg.TabIndex = 16;
            this.lblHelloMsg.Text = "Hello [UserName]!";
            // 
            // FrmMenuCatMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 171);
            this.Controls.Add(this.btnVIDMap);
            this.Controls.Add(this.btnCategoryManage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Name = "FrmMenuCatMan";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVIDMap;
        private System.Windows.Forms.Button btnCategoryManage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHelloMsg;
    }
}