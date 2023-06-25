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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace YummyRestaurantSystem
{
    public partial class FrmMenuCatMan : Form
    {
        private DataRow staffData;

        public FrmMenuCatMan(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;
            lblHelloMsg.Text = $"Hello {(string)staffData["Name"]}!";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCategoryManage_Click(object sender, EventArgs e)
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

        private void btnVIDMap_Click(object sender, EventArgs e)
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

        private void FrmMenuCatMan_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
