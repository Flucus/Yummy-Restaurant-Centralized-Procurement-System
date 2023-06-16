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
            MessageBox.Show("Not required in prototype version.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void btnOrderArrangement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not required in prototype version.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not required in prototype version.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        private void btnOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not required in prototype version.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
    }
}
