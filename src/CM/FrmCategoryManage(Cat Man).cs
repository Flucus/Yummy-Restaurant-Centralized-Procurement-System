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

        public bool logout = false;

        public FrmCategoryManage()
        {
            InitializeComponent();
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
    }
}
