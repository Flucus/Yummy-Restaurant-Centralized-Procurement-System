using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YummyRestaurantSystem.src.PM;

namespace YummyRestaurantSystem
{
    public partial class FrmEditAgreement : Form
    {
        private DataRow record;

        public bool logout = false;

        public FrmEditAgreement(DataRow record)
        {
            InitializeComponent();
            this.record = record;
            txtAgreementID.Text = (string)record["AgreementID"];
            txtBuyer.Text = (string)record["BuyerID"];
            string typeCode = (string)record["AgreementType"];
            switch (typeCode)
            {
                case "B":
                    txtAgreementType.Text = "BPA";
                    break;
                case "C":
                    txtAgreementType.Text = "CPA";
                    break;
                case "P":
                    txtAgreementType.Text = "PPO";
                    break;
            }
            createDatePicker.Value = (DateTime)record["CreatedDate"];
            effectDatePicker.Value = (DateTime)record["EffectiveDate"];
            string stateCode = (string)record["State"];
            cboState.Items.AddRange(new string[] { "Pending", "Fulfilled" });
            cboState.SelectedIndex = stateCode.Equals("P") ? 0 : 1;
            txtTerms.Text = (string)record["TermAndCondition"];
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

        private void FrmEditAgreement_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmEditAgreeItem form = new FrmEditAgreeItem();
            form.ShowDialog();
            if (form.logout)
            {
                logout = true;
                Close();
            }
            else
            {
                Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] stringData = new string[7];
            stringData[0] = txtAgreementID.Text;
            stringData[1] = txtBuyer.Text;
            string typeText = txtAgreementType.Text;
            switch (typeText)
            {
                case "BPA":
                    stringData[2] = "B";
                    break;
                case "CPA":
                    stringData[2] = "C";
                    break;
                case "PPO":
                    stringData[2] = "P";
                    break;
                default:
                    MessageBox.Show("Agreement type must be 'BPA', 'CPA' or 'PPO'.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            stringData[3] = createDatePicker.Value.ToString("yyyy-MM-dd");
            stringData[4] = effectDatePicker.Value.ToString("yyyy-MM-dd");
            string stateText = cboState.SelectedItem.ToString();
            stringData[5] = stateText.Equals("Pending") ? "P" : "F";
            stringData[6] = txtTerms.Text;


            if (SQLHandler.UpdateAgreement(stringData, (string)record["AgreementType"]))
            {
                MessageBox.Show("The record have been updated.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (stringData[2].Equals("P"))
                {
                    Visible = false;
                    FrmEditPPO_Pur_Man_ form = new FrmEditPPO_Pur_Man_();
                    form.ShowDialog();
                    if (form.logout)
                    {
                        logout = true;
                        Close();
                    }
                    else
                    {
                        Visible = true;
                    }
                }
                return;
            }
            MessageBox.Show("Constraint violation, inconsistent in agreement item table .", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnCA_Click_1(object sender, EventArgs e)
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
    }
}
