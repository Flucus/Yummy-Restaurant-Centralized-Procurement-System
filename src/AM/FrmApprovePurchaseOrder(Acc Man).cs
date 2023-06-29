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
    public partial class FrmApprovePurchaseOrder : Form
    {
        private int lastIndex = -1;

        public bool logout = false;

        public FrmApprovePurchaseOrder()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLHandler.GetPendingPO();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmUpdatePurchaseOrder_Acc_Man__Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            txtOrderID.Text = (string)record["OrderID"];
        }

        private void btnConifrm_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text.Length == 0) return;

            SQLHandler.UpdatePurchaseOrderState(txtOrderID.Text, "D");
            txtOrderID.Text = "";
            dataGridView1.DataSource = SQLHandler.GetPendingPO();
        }

        private void btnAPO_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVDN_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmDeliveryNoteView form = new FrmDeliveryNoteView();
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

        private void btnCDN_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmDeliveryNoteCreate form = new FrmDeliveryNoteCreate();
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
