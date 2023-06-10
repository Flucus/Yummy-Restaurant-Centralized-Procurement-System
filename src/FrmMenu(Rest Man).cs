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
    public partial class FrmMenuRestMan : Form
    {
        private DataRow staffData;

        public FrmMenuRestMan(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;
            lblHelloMsg.Text = $"Hello {staffData["Name"]}!";
        }

        private void btnInvMan_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmInvManage form = new FrmInvManage(staffData);
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnOrderPlacement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmItemRequest form = new FrmItemRequest(staffData);
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnCheckReq_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCheckReq form = new FrmCheckReq(staffData);
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuRestMan_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }
    }
}
