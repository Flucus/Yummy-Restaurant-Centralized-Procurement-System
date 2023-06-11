using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem.src.PM
{
    public partial class FrmPPO_Pur_Man_ : Form
    {
        public FrmPPO_Pur_Man_()
        {
            InitializeComponent();
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
    }
}
