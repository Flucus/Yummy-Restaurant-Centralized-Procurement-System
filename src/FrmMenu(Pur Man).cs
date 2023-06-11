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
    public partial class FrmMenuPurMan : Form
    {
        private DataRow staffData;

        public FrmMenuPurMan(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;

            string name = (string)staffData["Name"];
            lblHelloMsg.Text = $"Hello {name}!";
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

        private void btnOrderMan_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmContractMange form = new FrmContractMange();
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

        private void btnCreOrder_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCreateAgreement form = new FrmCreateAgreement();
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

        private void FrmMenuPurMan_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
