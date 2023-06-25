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
    public partial class FrmItemManage : Form
    {
        private int lastIndex = -1;

        public bool logout = false;

        public FrmItemManage()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLHandler.GetItem();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void FrmItemManage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Length > 0 ? txtItemName.Text : null;
            string itemID = txtItemID.Text.Length > 0 ? txtItemID.Text : null;
            dataGridView1.DataSource = SQLHandler.GetItem(itemName, itemID);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            string itemID = (string)record["ItemID"];
            if (SQLHandler.DeleteItem(itemID))
            {
                MessageBox.Show($"Item with ID: {itemID} have been deleted.", "Success to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Constraint violation.", "Fail to delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;

            Visible = false;
            FrmEditItem form = new FrmEditItem(record);
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
                dataGridView1.DataSource = SQLHandler.GetItem();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCreateItem form = new FrmCreateItem();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
                dataGridView1.DataSource = SQLHandler.GetItem();
            }
        }
    }
}
