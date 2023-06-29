using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastIndex = e.RowIndex;
            if (lastIndex < 0 || lastIndex >= dataGridView3.Rows.Count) return;

            DataGridViewRow data = dataGridView3.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;

            txtPPOID.Text = (string)record["PPO_ID"];
            txtLocalID.Text = (string)record["LocID"];
            txtDeliverySchedule.Text = (string)record["DeliverySchedule"];
            txtCurrency.Text = (string)record["Currency"];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SQLHandler.UpdatePPO(txtPPOID.Text, txtLocalID.Text, txtDeliverySchedule.Text, txtCurrency.Text))
            {
                MessageBox.Show("PPO record have been updated.", "Success to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Constraint violation.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
