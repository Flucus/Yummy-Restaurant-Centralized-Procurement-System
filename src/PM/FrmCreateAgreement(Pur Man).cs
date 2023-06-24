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
    public partial class FrmCreateAgreement : Form
    {
        public bool logout = false;

        public FrmCreateAgreement()
        {
            InitializeComponent();
        }

        private void FrmCreateAgreement_Load(object sender, EventArgs e)
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string[] stringData = new string[7];
            stringData[0] = txtAgreementID.Text;
            stringData[1] = txtBuyerID.Text;
            stringData[2] = txtAgreementType.Text;
            stringData[3] = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            stringData[4] = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            stringData[5] = cboState.SelectedItem.ToString();
            stringData[6] = txtTerms.Text;

            if (SQLHandler.CreateAgreement(stringData))
            {
                MessageBox.Show("Record have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("Invalid data or data format.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCreatePPO_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmPPO_Pur_Man_ form = new FrmPPO_Pur_Man_();
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
