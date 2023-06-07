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
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.txtVIName = new System.Windows.Forms.TextBox();
            this.lblVname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblVID = new System.Windows.Forms.Label();
            this.txtVID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cblType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(12, 9);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(360, 24);
            this.lblRestaurant.TabIndex = 6;
            this.lblRestaurant.Text = "The Yummy Restaurant Virtual ID Edit";
            // 
            // txtVIName
            // 
            this.txtVIName.Location = new System.Drawing.Point(198, 146);
            this.txtVIName.Name = "txtVIName";
            this.txtVIName.Size = new System.Drawing.Size(121, 20);
            this.txtVIName.TabIndex = 52;
            // 
            // lblVname
            // 
            this.lblVname.AutoSize = true;
            this.lblVname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVname.Location = new System.Drawing.Point(18, 142);
            this.lblVname.Name = "lblVname";
            this.lblVname.Size = new System.Drawing.Size(174, 24);
            this.lblVname.TabIndex = 51;
            this.lblVname.Text = "Virtual Item Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(198, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 50;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(18, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 24);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Item Name";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(334, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 30);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItem.Location = new System.Drawing.Point(18, 74);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(77, 24);
            this.lblItem.TabIndex = 47;
            this.lblItem.Text = "Item ID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(18, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 38);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(264, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 38);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblType.Location = new System.Drawing.Point(18, 41);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 24);
            this.lblType.TabIndex = 44;
            this.lblType.Text = "Type";
            // 
            // lblVID
            // 
            this.lblVID.AutoSize = true;
            this.lblVID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVID.Location = new System.Drawing.Point(18, 172);
            this.lblVID.Name = "lblVID";
            this.lblVID.Size = new System.Drawing.Size(95, 24);
            this.lblVID.TabIndex = 43;
            this.lblVID.Text = "Virtual ID";
            // 
            // txtVID
            // 
            this.txtVID.Location = new System.Drawing.Point(198, 172);
            this.txtVID.Name = "txtVID";
            this.txtVID.Size = new System.Drawing.Size(121, 20);
            this.txtVID.TabIndex = 42;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(198, 79);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 41;
            // 
            // cblType
            // 
            this.cblType.FormattingEnabled = true;
            this.cblType.Location = new System.Drawing.Point(198, 44);
            this.cblType.Name = "cblType";
            this.cblType.Size = new System.Drawing.Size(121, 21);
            this.cblType.TabIndex = 40;
            // 
            // FrmVirtualIDEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 290);
            this.Controls.Add(this.txtVIName);
            this.Controls.Add(this.lblVname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblVID);
            this.Controls.Add(this.txtVID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cblType);
            this.Controls.Add(this.lblRestaurant);
            this.Name = "FrmVirtualIDEdit";
            this.Text = "Virtual ID Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.TextBox txtVIName;
        private System.Windows.Forms.Label lblVname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVID;
        private System.Windows.Forms.TextBox txtVID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cblType;
    }
}