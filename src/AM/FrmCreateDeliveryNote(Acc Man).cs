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
    public partial class FrmDeliveryNoteCreate : Form
    {
        public bool logout = false;

        public FrmDeliveryNoteCreate()
        {
            InitializeComponent();
        }

        private void FrmDeliveryNoteCreate_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (SQLHandler.CreateDeliveryNotePO(txtOrderID.Text, txtLocID.Text, dateTimePicker1.Value))
            {
                MessageBox.Show("New purchase order delivery note have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Constraint violation.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAPO_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmApprovePurchaseOrder form = new FrmApprovePurchaseOrder();
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
            
        }
    }
}
