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
    public partial class FrmEditPPO_Pur_Man_ : Form
    {
        public bool logout = false;

        public FrmEditPPO_Pur_Man_()
        {
            InitializeComponent();
            dataGridView3.DataSource = SQLHandler.GetPPOTable();
        }

        private void FrmEditPPO_Pur_Man__Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
