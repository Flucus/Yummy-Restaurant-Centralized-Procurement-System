using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YummyRestaurantSystem.src.AM;

namespace YummyRestaurantSystem.src
{
    public partial class FrmMenu_Acc_Man_ : Form
    {
        public FrmMenu_Acc_Man_()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmMenu_Acc_Man__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCategoryManage_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmUpdatePurchaseOrder_Acc_Man_ form = new FrmUpdatePurchaseOrder_Acc_Man_();
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
