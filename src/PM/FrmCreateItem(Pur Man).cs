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
    public partial class FrmCreateAgreementItem : Form
    {

        public bool logout = false;

        public FrmCreateAgreementItem()
        {
            InitializeComponent();
            DataTable itemData = SQLHandler.GetAllItemDetail();
            dataGridView1.DataSource = itemData;
            dataGridView2.DataSource = itemData;
            dataGridView3.DataSource = itemData;
            dateTimePicker1.Value = DateTime.Now;
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

        private void FrmCreateAgreement_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCreate_CPA_Click(object sender, EventArgs e)
        {
            if (SQLHandler.CreateCPAITem(txtCPAID.Text, txtItemID_CPA.Text))
            {
                MessageBox.Show("New record have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error occurred.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCreate_PPO_Click(object sender, EventArgs e)
        {
            if (SQLHandler.CreatePPOItem(txtPPOID.Text, txtLocalID_PPO.Text, txtQuantity_PPO.Text, txtUnitPrice_PPO.Text))
            {
                MessageBox.Show("New record have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error occurred.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCreate_BPA_Click(object sender, EventArgs e)
        {
            string[] stringData = new string[9];
            stringData[0] = txtBPAID.Text;
            stringData[1] = txtItemID_BPA.Text;
            stringData[2] = txtAmountAgreed_BPA.Text;
            stringData[3] = txtAmountDelivered_BPA.Text;
            stringData[4] = txtUnitPrice_BPA.Text;
            stringData[5] = txtlCurrency_BPA.Text;
            stringData[6] = txtPriceBAmount_BPA.Text;
            stringData[7] = txtDiscount_BPA.Text;
            stringData[8] = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (SQLHandler.CreateBPAItem(stringData))
            {
                MessageBox.Show("New record have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error occurred.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancel_CPA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_BPA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_PPO_Click(object sender, EventArgs e)
        {
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
