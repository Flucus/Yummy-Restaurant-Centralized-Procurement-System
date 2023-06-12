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

namespace YummyRestaurantSystem.src.PM
{
    public partial class FrmPPO_Pur_Man_ : Form
    {
        public bool logout = false;
        public FrmPPO_Pur_Man_()
        {
            InitializeComponent();
            PPOTable.DataSource = SQLHandler.GetPPOTable();
        }

        private void FrmPPO_Pur_Man__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(SQLHandler.CreatePPO(txtPPOID.Text, txtLocalID.Text, txtDeliverySchedule.Text, txtCurrency.Text))
            {
                MessageBox.Show("Record have been inserted to database.", "Success to create PPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PPOTable.DataSource = SQLHandler.GetPPOTable(txtPPOID.Text);
                return;
            }
            MessageBox.Show("Invalid data or data format.", "Fail to create PPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
