using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem.src.AM
{
    public partial class FrmApprovePurchaseOrder : Form
    {
        public bool logout = false;

        public FrmApprovePurchaseOrder()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmUpdatePurchaseOrder_Acc_Man__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
