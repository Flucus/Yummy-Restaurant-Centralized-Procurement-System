using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
