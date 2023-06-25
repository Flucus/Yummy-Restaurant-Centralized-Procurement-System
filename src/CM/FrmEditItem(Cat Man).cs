using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace YummyRestaurantSystem
{
    public partial class FrmEditItem : Form
    {
        private DataRow itemRecord;

        public bool logout = false;

        public FrmEditItem(DataRow itemRecord)
        {
            InitializeComponent();
            this.itemRecord = itemRecord;

            DataTable categoryTable = SQLHandler.GetAllCategory();
            foreach (DataRow row in categoryTable.Rows)
            {
                string typeID = (string)row["CategoryName"];
                cboCategory.Items.Add(typeID);
            }

            txtSupplierID.Text = (string)itemRecord["SupplierID"];
            txtSupplierItemID.Text = (string)itemRecord["SupplierItemID"];
            txtName.Text = (string)itemRecord["Name"];
            cboCategory.SelectedIndex = cboCategory.FindString((string)itemRecord["CategoryName"]);
            txtDescription.Text = (string)itemRecord["Description"];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void FrmEditItem_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem == null)
            {
                MessageBox.Show("Invalid category.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SQLHandler.UpdateItem(txtSupplierID.Text, txtSupplierItemID.Text, txtName.Text, cboCategory.SelectedItem.ToString(), txtDescription.Text);
            MessageBox.Show("Item record have been updated to database.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCategoryManage form = new FrmCategoryManage();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
        }

        private void btnVID_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmVirtualIDMapping form = new FrmVirtualIDMapping();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmItemManage form = new FrmItemManage();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
        }
    }
}
