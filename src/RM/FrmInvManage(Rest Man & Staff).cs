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

namespace YummyRestaurantSystem
{
    public partial class FrmInvManage : Form
    {
        private DataRow staffData;
        private DataRow restData;

        private int lastIndex = -1;

        public bool logout = false;

        public FrmInvManage(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;
            string title = (string)staffData["JobTitle"];
            if (title.Equals("Restaurant Staff"))
            {
                btnModify.Visible = false;
            }

            string locID = (string)staffData["LocID"];
            this.restData = SQLHandler.GetRestaurantData(locID);
            string restName = (string)restData["Name"];
            lblRestaurant.Text = $"{restName} Inventory Management";

            invTable.DataSource = SQLHandler.GetInventoryByLocID(locID);

            if (invTable.RowCount > 1)
            {
                lastIndex = 0;
            }
        }

        private void FrmInvManage_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void invTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= invTable.RowCount) return;

            DataGridViewRow data = invTable.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;

            Visible = false;
            FrmInvModify form = new FrmInvModify(restData, record);
            form.ShowDialog();
            if (form.logout)
            {
                logout = true;
                Close();
            }
            else
            {
                Visible = true;
            }
            if (form.modified)
            {
                string locID = (string)staffData["LocID"];
                invTable.DataSource = SQLHandler.GetInventoryByLocID(locID);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string locID = (string)staffData["LocID"];
            invTable.DataSource = SQLHandler.GetInventoryByLocID(locID, txtSearch.Text);
            if (invTable.RowCount > 1)
            {
                lastIndex = 0;
            }
        }
    }
}
