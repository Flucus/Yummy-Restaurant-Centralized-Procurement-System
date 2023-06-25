using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem
{
    public partial class FrmCreateItem : Form
    {

        public bool logout = false;


        public FrmCreateItem()
        {
            InitializeComponent();
            DataTable categoryTable = SQLHandler.GetAllCategoryName();
            foreach (DataRow row in categoryTable.Rows)
            {
                string typeID = (string)row["CategoryName"];
                cboCat.Items.Add(typeID);
            }
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

        private void FrmCreateItem_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cboCat.SelectedItem == null)
            {
                MessageBox.Show("Invalid category.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SQLHandler.CreateItem(txtSupplierID.Text, txtSupplierItemID.Text, txtName.Text, cboCat.SelectedItem.ToString(), txtDescription.Text))
            {
                MessageBox.Show("New item have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Constraint violation.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
