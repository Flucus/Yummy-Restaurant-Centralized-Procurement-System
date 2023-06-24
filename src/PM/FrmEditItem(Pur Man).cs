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
    public partial class FrmEditAgreeItem : Form
    {
        public bool logout = false;

        public FrmEditAgreeItem()
        {
            InitializeComponent();
            cpaItemTable.DataSource = SQLHandler.GetCPAItemTable();
            bpaItemTable.DataSource = SQLHandler.GetBPAItemTable();
            ppoItemTable.DataSource = SQLHandler.GetPPOItemTable();
        }

        private void FrmEditAgreement_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void txtCPAID_TextChanged(object sender, EventArgs e)
        {
            if (txtCPAID.Text.Length > 0)
            {
                cpaItemTable.DataSource = SQLHandler.GetCPAItemTable(txtCPAID.Text);
            }
            cpaItemTable.DataSource = SQLHandler.GetCPAItemTable();
        }

        private void txtBPAID_TextChanged(object sender, EventArgs e)
        {
            if (txtBPAID.Text.Length > 0)
            {
                bpaItemTable.DataSource = SQLHandler.GetBPAItemTable(txtBPAID.Text);
            }
            bpaItemTable.DataSource = SQLHandler.GetBPAItemTable();
        }

        private void txtPPOID_TextChanged(object sender, EventArgs e)
        {
            if (txtPPOID.Text.Length > 0)
            {
                ppoItemTable.DataSource = SQLHandler.GetPPOItemTable(txtPPOID.Text);
            }
            ppoItemTable.DataSource = SQLHandler.GetPPOItemTable();
        }

        private void cpaItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastIndex = e.RowIndex;
            if (lastIndex >= 0 && lastIndex < cpaItemTable.Rows.Count - 1)
            {
                DataGridViewRow data = cpaItemTable.Rows[lastIndex];
                DataRow record = ((DataRowView)data.DataBoundItem).Row;
                txtCPAID.Text = (string)record["CPA_ID"];
                txtItemID_CPA.Text = (string)record["ItemID"];
            }
        }

        private void btnEdit_CPA_Click(object sender, EventArgs e)
        {
            if (SQLHandler.UpdateCPAItem(txtCPAID.Text, txtNewItemID_CPA.Text, txtItemID_CPA.Text))
            {
                MessageBox.Show("The change have updated to database.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtCPAID.Text.Length > 0)
                {
                    cpaItemTable.DataSource = SQLHandler.GetCPAItemTable(txtCPAID.Text);
                }
                cpaItemTable.DataSource = SQLHandler.GetCPAItemTable();
                return;
            }
            MessageBox.Show("Invalid item ID.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bpdItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastIndex = e.RowIndex;
            if (lastIndex >= 0 && lastIndex < bpaItemTable.Rows.Count - 1)
            {
                DataGridViewRow data = bpaItemTable.Rows[lastIndex];
                DataRow record = ((DataRowView)data.DataBoundItem).Row;
                txtBPAID.Text = (string)record["BPA_ID"];
                txtItemID_BPA.Text = (string)record["ItemID"];
                txtAmountAgreed_BPA.Text = ((int)record["AmountAgreed"]).ToString();
                txtAmountDelivered_BPA.Text = ((int)record["AmountDelivered"]).ToString();
                txtUnitPrice_BPA.Text = record["UnitPrice"].ToString();
                txtlCurrency_BPA.Text = (string)record["Currency"];
                txtPriceBAmount_BPA.Text = record.IsNull("PriceBreakAmount") ? "0" : record["PriceBreakAmount"].ToString();
                txtDiscount_BPA.Text = record.IsNull("Discount") ? "0" : record["Discount"].ToString();
                dateTimePickerBPA.Value = record.IsNull("PriceBreakEffectiveDate") ? DateTime.Now : (DateTime)record["PriceBreakEffectiveDate"];
            }
        }

        private void btnEdit_BPA_Click(object sender, EventArgs e)
        {
            string[] stringData = new string[9];
            try
            {
                stringData[0] = txtBPAID.Text;
                stringData[1] = txtNewItemID_BPA.Text;
                stringData[2] = int.Parse(txtAmountAgreed_BPA.Text).ToString();
                stringData[3] = int.Parse(txtAmountDelivered_BPA.Text).ToString();
                stringData[4] = float.Parse(txtUnitPrice_BPA.Text).ToString();
                stringData[5] = txtlCurrency_BPA.Text;
                stringData[6] = int.Parse(txtPriceBAmount_BPA.Text).ToString();
                stringData[7] = float.Parse(txtDiscount_BPA.Text).ToString();
                stringData[8] = dateTimePickerBPA.Value.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Invalid data or data format.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SQLHandler.UpdateBPAItem(stringData, txtItemID_BPA.Text))
            {
                MessageBox.Show("The change have updated to database.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtBPAID.Text.Length > 0)
                {
                    bpaItemTable.DataSource = SQLHandler.GetBPAItemTable(txtBPAID.Text);
                }
                bpaItemTable.DataSource = SQLHandler.GetBPAItemTable();
                return;
            }
            MessageBox.Show("Invalid data or data format.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ppoItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastIndex = e.RowIndex;
            if (lastIndex >= 0 && lastIndex < ppoItemTable.Rows.Count - 1)
            {
                DataGridViewRow data = ppoItemTable.Rows[lastIndex];
                DataRow record = ((DataRowView)data.DataBoundItem).Row;
                txtPPOID.Text = (string)record["PPO_ID"];
                txtItemID_PPO.Text = (string)record["ItemID"];
                txtQuantity_PPO.Text = ((int)record["Quantity"]).ToString();
                txtUnitPrice_PPO.Text = record["UnitPrice"].ToString();
            }
        }

        private void btnEdit_PPO_Click(object sender, EventArgs e)
        {
            int tempQty;
            float tempUP;
            if (!int.TryParse(txtQuantity_PPO.Text, out tempQty) || !float.TryParse(txtUnitPrice_PPO.Text, out tempUP))
            {
                MessageBox.Show("Invalid data or data format.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string quantity = tempQty.ToString();
            string unitPrice = tempUP.ToString();
            if (SQLHandler.UpdatePPOItem(txtPPOID.Text, txtNewItemID_PPO.Text, quantity, unitPrice, txtItemID_PPO.Text))
            {
                MessageBox.Show("The change have updated to database.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtCPAID.Text.Length > 0)
                {
                    cpaItemTable.DataSource = SQLHandler.GetPPOItemTable(txtCPAID.Text);
                }
                cpaItemTable.DataSource = SQLHandler.GetPPOItemTable();
                return;
            }
            MessageBox.Show("Invalid data or data format.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancel_PPO_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_BPA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_CPA_Click(object sender, EventArgs e)
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
