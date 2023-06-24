using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem
{
    public partial class FrmVirtualIDMapping : Form
    {
        private Debouncer de = new Debouncer(1000);
        private delegate void DelegateWorker(string itemNameMatch, string typeNameMatch);

        private int lastIndex = -1;

        public bool logout = false;

        public FrmVirtualIDMapping()
        {
            InitializeComponent();
            UpdateVIDMappingTable();
        }

        public void UpdateVIDMappingTable(string itemNameMatch = "", string typeNameMatch = "")
        {
            if (InvokeRequired)
            {
                DelegateWorker worker = new DelegateWorker(UpdateVIDMappingTable);
                Invoke(worker, itemNameMatch, typeNameMatch);
                return;
            }

            DataTable table = SQLHandler.GetVIDMapping(itemNameMatch, typeNameMatch);
            VIDMappingTable.DataSource = table;

            foreach (DataRow row in table.Rows)
            {
                string typeName = (string)row["TypeName"];
                if (!cboType.Items.Contains(typeName))
                {
                    cboType.Items.Add(typeName);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeName = (string)cboType.SelectedItem;
            UpdateVIDMappingTable(typeNameMatch: typeName);
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            de.Debounce(() =>
            {
                string itemName = txtItem.Text;
                UpdateVIDMappingTable(itemNameMatch: itemName);
            });
        }

        private void VIDMappingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= VIDMappingTable.Rows.Count) return;

            DataGridViewRow data = VIDMappingTable.Rows[lastIndex];
            string temp = string.Join("\t", data.Cells.Cast<DataGridViewCell>().Select(c => c.Value.ToString()).ToArray());
            DialogResult dialogResult = MessageBox.Show(temp, "Confirm delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string VID = (string)data.Cells[0].Value;
                string typeID = (string)data.Cells[1].Value;
                bool success = SQLHandler.DeleteVIDMapping(VID, typeID);
                if (!success)
                {
                    MessageBox.Show("Error occurred.", "Fail to delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                UpdateVIDMappingTable();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmVirtualIDCreate form = new FrmVirtualIDCreate();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
            if (form.created) UpdateVIDMappingTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastIndex == -1) return;

            this.Visible = false;
            DataGridViewRow data = VIDMappingTable.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            FrmVirtualIDEdit form = new FrmVirtualIDEdit(record);
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
            if (form.edited) UpdateVIDMappingTable();
        }

        private void FrmVirtualIDMapping_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
    }
}
