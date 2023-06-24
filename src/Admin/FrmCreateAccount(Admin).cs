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
    public partial class FrmCreateAccount : Form
    {

        private static readonly IReadOnlyCollection<string> JobTitleSet = new HashSet<string> { "Restaurant Manager", "Restaurant Staff", "Category Manager", "Buyer", "Administrator", "Purchase Manager", "Warehouse Clerk", "Accounting Manager" };

        public bool logout = false;
        public bool created = false;

        public FrmCreateAccount()
        {
            InitializeComponent();
            string[] LocIDArray = SQLHandler.GetAllLocID();
            cboLoc.Items.AddRange(LocIDArray);
            dtpDoB.Value = DateTime.Now;
            dtpHd.Value = DateTime.Now;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int salary;
            if (!int.TryParse(txtSal.Text, out salary) || salary < 0)
            {
                MessageBox.Show("Invalid salary.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!JobTitleSet.Contains(txtJobTitle.Text))
            {
                MessageBox.Show("Invalid job title.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboLoc.SelectedItem==null)
            {
                MessageBox.Show("Invalid location.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string[] stringData = new string[] {
                null,
                cboLoc.SelectedItem.ToString(),
                txtJobTitle.Text,
                txtName.Text,
                txtEmail.Text,
                txtPhone.Text,
                dtpDoB.Value.ToString("yyyy-MM-dd"),
                dtpHd.Value.ToString("yyyy-MM-dd"),
                txtSal.Text,
                txtState.Text
            };

            if (SQLHandler.CreateStaffRecord(stringData))
            {
                created = true;
                MessageBox.Show("New staff record have inserted to database.", "Success to create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error occurred.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
