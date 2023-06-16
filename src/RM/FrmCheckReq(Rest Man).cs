using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Ocsp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace YummyRestaurantSystem
{
    public partial class FrmCheckReq : Form
    {
        private Debouncer de = new Debouncer(1000);
        private delegate void DelegateWorker();

        private DataRow staffData;
        private DataRow restData;
        private string locID;
        private string restName;
        private int lastIndex = -1;

        public bool logout = false;

        public FrmCheckReq(DataRow data)
        {
            InitializeComponent();
            staffData = data;
            locID = (string)staffData["LocID"];

            restData = SQLHandler.GetRestaurantData(locID);
            restName = (string)restData["Name"];
            lblRestaurant.Text = $"{restName} Check Request";
            UpdateRequestTable();
        }

        public void UpdateRequestTable()
        {
            if (InvokeRequired)
            {
                DelegateWorker worker = new DelegateWorker(UpdateRequestTable);
                Invoke(worker);
                return;
            }

            string requestMatch = txtSearch.Text;
            DataTable dt = SQLHandler.GetRequest(locID, requestMatch);
            requestTable.Columns.Clear();
            requestTable.DataSource = dt;
            lastIndex = 0;


            if (lastIndex >= dt.Rows.Count)
            {
                lastIndex = -1;
                btnEdit.BackColor = Color.Gray;
                btnDetails.BackColor = Color.Gray;
                return;
            }

            DataRow data = dt.Rows[lastIndex];
            string state = (string)data["State"];
            if (state == "P")
            {
                btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            else
            {
                btnEdit.BackColor = Color.Gray;
            }
            btnDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            de.Debounce(() => UpdateRequestTable());
        }

        private void requestTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastIndex = e.RowIndex;
            DataTable table = (DataTable)requestTable.DataSource;
            if (lastIndex < 0 || lastIndex >= table.Rows.Count)
            {
                return;
            }

            DataRow data = table.Rows[lastIndex];
            string state = (string)data["State"];
            if (state == "P")
            {
                btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
            btnDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastIndex == -1)
                return;

            DataTable table = (DataTable)requestTable.DataSource;
            DataRow requestData = table.Rows[lastIndex];
            Visible = false;
            FrmEditRequest form = new FrmEditRequest(restData, requestData);
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lastIndex == -1)
                return;

            DataTable table = (DataTable)requestTable.DataSource;
            DataRow data = table.Rows[lastIndex];
            Visible = false;
            FrmDetailsRequestRestMan form = new FrmDetailsRequestRestMan(restName, data);
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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmCheckReq_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmInvManage form = new FrmInvManage(staffData);
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

        private void btnOP_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmItemRequest form = new FrmItemRequest(staffData);
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

        private void btnCR_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckReq form = new FrmCheckReq(staffData);
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
