using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YummyRestaurantSystem.src.WC;

namespace YummyRestaurantSystem
{
    public partial class FrmMenuWhClerk : Form
    {
        public FrmMenuWhClerk()
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
            Close();
        }

        private void FrmMenuWhClerk_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnInvMan_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckUpdate form = new FrmCheckUpdate();
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

        private void btnOrderArrangement_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmOrderArrange_Wh_Clerk_ form = new FrmOrderArrange_Wh_Clerk_();
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

        private void btnGN_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmGenerateDeliveryNote form = new FrmGenerateDeliveryNote();
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

        private void btnRD_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmReceiveDispatchInstruction form = new FrmReceiveDispatchInstruction();
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
