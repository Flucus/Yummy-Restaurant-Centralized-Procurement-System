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
    public partial class FrmCheckofStatus : Form
    {
        private DataRow record;

        public bool logout = false;

        public FrmCheckofStatus(DataRow record)
        {
            InitializeComponent();
            this.record = record;
            DataTable[] agreeTables = SQLHandler.GetAgreementDetail();
            BPATabel.DataSource = agreeTables[0];
            CPATable.DataSource = agreeTables[1];
            PPOTable.DataSource = agreeTables[2];
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnCM_Click(object sender, EventArgs e)
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

        private void btnCA_Click(object sender, EventArgs e)
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

        private void FrmCheckofStatus_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
