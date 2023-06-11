using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace YummyRestaurantSystem
{
    public partial class FrmContractMange : Form
    {
        private Debouncer de = new Debouncer(1000);
        private delegate void DelegateWorker();

        private static readonly string[] agreeTypeArray = { "", "BPA", "CPA", "PPO" };
        private int lastIndex = -1;

        public bool logout = false;

        public FrmContractMange()
        {
            InitializeComponent();
            contractTable.DataSource = SQLHandler.GetAllAgreementRecord();
            if (contractTable.Rows.Count > 0)
            {
                lastIndex = 0;
            }
            cboAgreement.Items.AddRange(agreeTypeArray);
            cboAgreement.SelectedIndex = cboAgreement.FindString("");
            createDatePicker.Value = DateTime.Now.AddDays(2);
        }

        private void FrmContractMange_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Visible = false;
            DataGridViewRow data = contractTable.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            FrmCheckofStatus form = new FrmCheckofStatus(record);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Visible = false;
            DataGridViewRow data = contractTable.Rows[lastIndex];
            DataRow record = ((DataRowView)data.DataBoundItem).Row;
            FrmEditAgreement form = new FrmEditAgreement(record);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
        }

        public void UpdateAgreementTable()
        {
            if (InvokeRequired)
            {
                DelegateWorker worker = new DelegateWorker(UpdateAgreementTable);
                Invoke(worker);
                return;
            }

            string agreeID = txtContactNumber.Text;
            string suppName = txtSupplierName.Text;
            string agreeType = cboAgreement.SelectedItem.ToString();
            string agreeCode = !agreeType.Equals("") ? agreeType.Substring(0, 1) : "";
            DateTime createDate = createDatePicker.Value;
            string dateString = createDate > DateTime.Now ? "" : createDate.ToString("yyyy-MM-dd");
            contractTable.DataSource = SQLHandler.GetAllAgreementRecord(agreeID, suppName, agreeCode, dateString);
            if (contractTable.Rows.Count > 0)
            {
                lastIndex = 0;
            }
        }

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

            de.Debounce(() => UpdateAgreementTable());
        }
    }
}
