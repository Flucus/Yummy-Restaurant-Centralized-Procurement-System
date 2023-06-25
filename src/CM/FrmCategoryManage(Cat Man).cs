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
    public partial class FrmCategoryManage : Form
    {
        private int lastIndex = -1;

        public bool logout = false;

        public FrmCategoryManage()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLHandler.GetAllCategory();
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

        private void FrmCategoryManage_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            string CID = (string)record["CategoryID"];

            if (SQLHandler.DeleteCategory(CID))
            {
                MessageBox.Show("Category have been deleted.", "Success to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Constraint violation.", "Fail to delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;

            FrmCategoryEdit_Cat_Man_ form = new FrmCategoryEdit_Cat_Man_(record);
            form.ShowDialog();
            if (form.logout)
            {
                logout = true;
                Close();
            }
            else
            {
                Visible = true;
                dataGridView1.DataSource = SQLHandler.GetAllCategory();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCategoryCreate form = new FrmCategoryCreate();
            form.ShowDialog();
            if (form.logout)
            {
                logout = true;
                Close();
            }
            else
            {
                Visible = true;
                dataGridView1.DataSource = SQLHandler.GetAllCategory();
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
