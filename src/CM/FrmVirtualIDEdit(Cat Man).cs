using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem
{
    public partial class FrmVirtualIDEdit : Form
    {
        private DataRow record;

        public bool logout = false;
        public bool edited = false;

        public FrmVirtualIDEdit(DataRow record)
        {
            InitializeComponent();
            this.record = record;
            txtTypeID.Text = (string)record["TypeID"];
            txtTypeName.Text = (string)record["TypeName"];
            txtVID.Text = (string)record["VirtualID"];
            txtItemID.Text = (string)record["ItemID"];
            txtItemName.Text = (string)record["Name"];
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            string itemName = SQLHandler.GetItemNameByItemID(txtItemID.Text);
            if (itemName != null)
            {
                txtItemName.Text = itemName;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text.Length > 0)
            {
                bool success = SQLHandler.UpdateVIDMapping(txtVID.Text, txtTypeID.Text, txtItemID.Text);
                if (!success)
                {
                    MessageBox.Show("Error occurred.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MessageBox.Show("Record updated.", "Edit complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Invalid item ID.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmVirtualIDEdit_Load(object sender, EventArgs e)
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
