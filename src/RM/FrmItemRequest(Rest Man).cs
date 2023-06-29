using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YummyRestaurantSystem.src.RM;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace YummyRestaurantSystem
{
    public partial class FrmItemRequest : Form
    {
        private DataRow staffData;
        private DataRow restData;

        private int lastIndex = -1;

        public bool logout = false;

        public FrmItemRequest(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;
            string locID = (string)staffData["LocID"];
            this.restData = SQLHandler.GetRestaurantData(locID);
            string restName = (string)restData["Name"];
            lblRestaurant.Text = $"{restName} Item Request";
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

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            string typeID = (string)restData["TypeID"];
            DataRow row = SQLHandler.GetItemByVIDTypeID(txtItemID.Text, typeID);
            if (row != null)
            {
                string itemName = (string)row["Name"];
                txtItemName.Text = itemName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity;
            if (txtItemName.Text.Length == 0 || !int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0) return;

            foreach (DataGridViewRow data in tempItemTable.Rows)
            {
                string itemID = (string)data.Cells["ItemID"].Value;
                if (itemID != null && itemID.Equals(txtItemID.Text))
                {
                    MessageBox.Show("Already exist in request.", "Fail to add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            tempItemTable.Rows.Add(txtItemID.Text, txtItemName.Text, quantity);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= tempItemTable.Rows.Count) return;
            tempItemTable.Rows.RemoveAt(lastIndex);
        }

        private void tempItemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = (int)e.RowIndex;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            DataTable item = new DataTable();
            foreach (DataGridViewColumn col in tempItemTable.Columns)
            {
                item.Columns.Add(col.Name, col.CellTemplate.ValueType);
            }
            foreach (DataGridViewRow row in tempItemTable.Rows)
            {
                DataRow dRow = item.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                item.Rows.Add(dRow);
            }
            item.Rows.RemoveAt(item.Rows.Count - 1);

            bool scuccss = SQLHandler.CreateRestaurantRequest(staffData, restData, item, txtRemark.Text);
            if (!scuccss)
            {
                MessageBox.Show("Constraint violation.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("New request have uploaded to database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tempItemTable.Rows.Clear();
        }

        private void FrmItemRequest_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmInvManage form = new FrmInvManage(staffData);
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

        private void btnOP_Click(object sender, EventArgs e)
        {

        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckReq form = new FrmCheckReq(staffData);
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

        private void btnCDN_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckDeliveryNoteStatus_Rest_Man_ form = new FrmCheckDeliveryNoteStatus_Rest_Man_(staffData);
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
