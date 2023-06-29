using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem.src.WC
{
    public partial class FrmReceiveDespatchInstruction : Form
    {
        private DataRow staffData;
        private int lastIndex = -1;

        public bool logout = false;

        public FrmReceiveDespatchInstruction(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;
            dataGridView1.DataSource = SQLHandler.GetDispatchInstruction((string)staffData["LocID"]);
        }

        private void FrmLogisticManagement_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
            txtItemID.Text = "";
            txtRestaurantID.Text = "";
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            txtItemID.Text = (string)record["REquestID"];
            txtRestaurantID.Text = (string)record["RestaurantID"];

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text.Length == 0 || txtRestaurantID.Text.Length == 0) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            SQLHandler.CreateDeliveryNoteRR(txtItemID.Text, txtRestaurantID.Text, dateTimePicker1.Value);

            dataGridView1.DataSource = SQLHandler.GetDispatchInstruction((string)staffData["LocID"]);
            txtItemID.Text = "";
            txtRestaurantID.Text = "";
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckUpdate form = new FrmCheckUpdate(staffData);
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

        private void btnRDI_Click(object sender, EventArgs e)
        {

        }
    }
}
