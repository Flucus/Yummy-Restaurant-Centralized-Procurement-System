using Org.BouncyCastle.Utilities.Collections;
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
    public partial class FrmModifyAccount : Form
    {

        private DataRow record;
        private static readonly IReadOnlyCollection<string> JobTitleSet = new HashSet<string> { "Restaurant Manager", "Restaurant Staff", "Category Manager", "Buyer", "Administrator", "Purchase Manager", "Warehouse Clerk", "Accounting Manager" };

        public bool logout = false;
        public bool modified = false;

        public FrmModifyAccount(DataRow record)
        {
            InitializeComponent();
            this.record = record;

            string[] LocIDArray = SQLHandler.GetAllLocID();
            cboLoc.Items.AddRange(LocIDArray);

            txtStaffID.Text = (string)record["StaffID"];
            txtName.Text = (string)record["Name"];
            txtEmail.Text = (string)record["Email"];
            txtPhone.Text = (string)record["Phone"];
            txtSal.Text = ((int)record["Salary"]).ToString();
            txtState.Text = (string)record["State"];
            txtJobTitle.Text = (string)record["JobTitle"];

            dtpDoB.Value = (DateTime)record["Dob"];
            dtpHd.Value = (DateTime)record["HireDate"];
            cboLoc.SelectedIndex = cboLoc.FindString((string)record["LocID"]);
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

        private void btnEdit_Click(object sender, EventArgs e)
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

            if (cboLoc.SelectedItem == null)
            {
                MessageBox.Show("Invalid location.", "Fail to edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string[] stringData = new string[] {
                txtStaffID.Text,
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

            if (SQLHandler.ModifyStaffRecord(stringData))
            {
                modified = true;
                MessageBox.Show("Record have been updated.", "Success to modify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Error occurred.", "Fail to modify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void FrmModifyAccount_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
