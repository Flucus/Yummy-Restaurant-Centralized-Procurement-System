using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace YummyRestaurantSystem
{
    public partial class FrmMenuCatMan : Form
    {
        private DataRow data;

        public FrmMenuCatMan(DataRow data)
        {
            InitializeComponent();
            this.data = data;
            lblHelloMsg.Text = $"Hello {(string)data["Name"]}!";
        }

        private void FrmMenuCatMan_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void btnCategoryManage_Click(object sender, EventArgs e)
        {

        }
    }
}
