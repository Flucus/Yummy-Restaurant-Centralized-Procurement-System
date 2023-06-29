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
    public partial class FrmDeliveryNoteView : Form
    {
        public bool logout = false;

        public FrmDeliveryNoteView()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLHandler.GetDeliveryNotePO();
            dateTimePicker1.Value = DateTime.Now.AddDays(2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmDeliveryNoteView_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void txtNoteID_TextChanged(object sender, EventArgs e)
        {
            string noteMatch = txtNoteID.Text;
            string locMatch = txtLocID.Text;
            DateTime createDate = dateTimePicker1.Value;
            string dateString = createDate > DateTime.Now ? "" : createDate.ToString("yyyy-MM-dd");

            dataGridView1.DataSource = SQLHandler.GetDeliveryNotePO(noteMatch, locMatch, dateString);
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
