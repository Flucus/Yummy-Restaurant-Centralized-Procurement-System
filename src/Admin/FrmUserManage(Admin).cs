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
    public partial class FrmUserManage : Form
    {
        private int lastIndex = -1;
        
        public bool logout = false;

        public FrmUserManage()
        {
            InitializeComponent();
            dgvUserList.DataSource = SQLHandler.GetStaffRecord();
            if (dgvUserList.RowCount > 1)
            {
                lastIndex = 0;
            }
        }

        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void btnLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in prototype version.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCreateAccount form = new FrmCreateAccount();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
            if (form.created)
            {
                dgvUserList.DataSource = SQLHandler.GetStaffRecord();
                if (dgvUserList.RowCount > 1)
                {
                    lastIndex = 0;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dgvUserList.Rows.Count) return;

            Visible = false;
            DataGridViewRow data = dgvUserList.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            FrmModifyAccount form = new FrmModifyAccount(record);
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
            if (form.modified)
            {
                dgvUserList.DataSource = SQLHandler.GetStaffRecord();
                if (dgvUserList.RowCount > 1)
                {
                    lastIndex = 0;
                }
            }
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dgvUserList.Rows.Count) return;

            DataGridViewRow data = dgvUserList.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            string staffID = (string)record["StaffID"];
            SQLHandler.DeleteStaff(staffID);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            dgvUserList.DataSource = SQLHandler.GetStaffRecord(txtID.Text, txtName.Text);
            if (dgvUserList.RowCount > 1)
            {
                lastIndex = 0;
            }
        }
    }
}
