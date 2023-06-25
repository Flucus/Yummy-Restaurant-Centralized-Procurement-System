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
    public partial class FrmCategoryEdit_Cat_Man_ : Form
    {
        private DataRow catRecord;

        public bool logout = false;

        public FrmCategoryEdit_Cat_Man_(DataRow catRecord)
        {
            InitializeComponent();
            this.catRecord = catRecord;

            txtCategoryID.Text = (string)catRecord["CategoryID"];
            txtCategoryName.Text = (string)catRecord["CategoryName"];
            txtDescription.Text = (string)catRecord["Description"];
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void FrmCategoryEdit_Cat_Man__Load(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SQLHandler.UpdateCategory(txtCategoryID.Text, txtCategoryName.Text, txtDescription.Text))
            {
                MessageBox.Show("Category record have been updated.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Constraint violation.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
