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
    public partial class FrmContractMange : Form
    {

        public bool logout = false;

        public FrmContractMange()
        {
            InitializeComponent();
        }

        private void FrmContractMange_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Visible = false;
            DataRow record = null;
            FrmCheckofStatus form = new FrmCheckofStatus(record);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Visible = false;
            DataRow record = null;
            FrmEditAgreement form = new FrmEditAgreement(record);
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
    }
}
