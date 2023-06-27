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
    public partial class FrmDeliveryNoteCreate : Form
    {
        public FrmDeliveryNoteCreate()
        {
            InitializeComponent();
        }

        private void FrmDeliveryNoteCreate_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
