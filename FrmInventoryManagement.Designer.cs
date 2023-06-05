namespace YummyRestaurantSystem
{
    partial class FrmInventoryManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnItemRequest = new System.Windows.Forms.Button();
            this.btnMapping = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRestaurant.Location = new System.Drawing.Point(12, 9);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(385, 24);
            this.lblRestaurant.TabIndex = 3;
            this.lblRestaurant.Text = "[restaurant] Restaurant Item List Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 153);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategory.Location = new System.Drawing.Point(12, 45);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 24);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(147, 45);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(12, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Item Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(12, 113);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 24);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Item ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(147, 113);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(69, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 38);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnItemRequest
            // 
            this.btnItemRequest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItemRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemRequest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemRequest.ForeColor = System.Drawing.Color.Black;
            this.btnItemRequest.Location = new System.Drawing.Point(414, 204);
            this.btnItemRequest.Name = "btnItemRequest";
            this.btnItemRequest.Size = new System.Drawing.Size(134, 38);
            this.btnItemRequest.TabIndex = 13;
            this.btnItemRequest.Text = "Item Request";
            this.btnItemRequest.UseVisualStyleBackColor = false;
            // 
            // btnMapping
            // 
            this.btnMapping.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMapping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapping.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapping.ForeColor = System.Drawing.Color.Black;
            this.btnMapping.Location = new System.Drawing.Point(274, 204);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(134, 38);
            this.btnMapping.TabIndex = 14;
            this.btnMapping.Text = "Request Mapping";
            this.btnMapping.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(69, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 38);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMapping);
            this.Controls.Add(this.btnItemRequest);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRestaurant);
            this.Name = "FrmInventoryManagement";
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnItemRequest;
        private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Button btnCancel;
    }
}