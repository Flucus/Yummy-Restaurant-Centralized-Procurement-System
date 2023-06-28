using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem.src.WC
{
    public partial class FrmCheckUpdate : Form
    {
        private int lastIndex = -1;

        public bool logout = false;

        public FrmCheckUpdate()
        {
            InitializeComponent();
            dataGridView1.DataSource = SQLHandler.GetInventory();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmCheckUpdate_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            DataGridViewRow data = dataGridView1.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            txtLocID.Text = (string)record["LocID"];
            txtItemID.Text = (string)record["ItemID"];
            txtCount.Text = ((int)record["Count"]).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lastIndex < 0 || lastIndex >= dataGridView1.Rows.Count) return;

            int count;
            if (!int.TryParse(txtCount.Text, out count)) return;

            SQLHandler.UpdateInventory(txtLocID.Text, txtItemID.Text, count);
            dataGridView1.DataSource = SQLHandler.GetInventory();
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

        private void btnIM_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckUpdate form = new FrmCheckUpdate();
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
            Visible = false;
            FrmReceiveDespatchInstruction form = new FrmReceiveDespatchInstruction(staffData);
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
