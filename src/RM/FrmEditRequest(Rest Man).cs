using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Ocsp;
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
using YummyRestaurantSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YummyRestaurantSystem
{
    public partial class FrmEditRequest : Form
    {
        private Debouncer de = new Debouncer(1000);
        private delegate void DelegateWorker();

        private DataRow restData;
        private DataRow requestData;
        private bool vaildRequestVID = false;
        private bool vaildVID = false;

        public bool logout = false;

        public FrmEditRequest(DataRow restData, DataRow requestData)
        {
            InitializeComponent();
            this.restData = restData;
            this.requestData = requestData;
            string restname = (string)restData["Name"];
            lblRestaurant.Text = $"{restname} Edit Request";

            string requestID = (string)requestData["RequestID"];
            txtRequestID.Text = requestID;
            txtRemark.Text = requestData["Remark"] as string;
            UpdateItemTable();
        }

        public void UpdateItemTable()
        {
            DataTable dt = SQLHandler.GetRequestItem(txtRequestID.Text);
            itemTable.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                txtItemID.Text = (string)dt.Rows[0]["VirtualID"];
                txtItemName.Text = (string)dt.Rows[0]["Name"];
                txtQuantity.Text = ((int)dt.Rows[0]["Quantity"]).ToString();
            }
        }

        public void CheckeItemID()
        {
            if (InvokeRequired)
            {
                DelegateWorker worker = new DelegateWorker(CheckeItemID);
                Invoke(worker);
                return;
            }

            vaildRequestVID = false;
            vaildVID = false;

            DataRow row = SQLHandler.GetItemByRequestIDAndVID(restData, txtRequestID.Text, txtItemID.Text);
            if (row != null)
            {
                vaildRequestVID = true;
                string name = (string)row["Name"];
                string quantity = ((int)row["Quantity"]).ToString();
                txtItemName.Text = name;
                txtQuantity.Text = quantity;
                return;
            }

            row = SQLHandler.GetItemByVID(txtItemID.Text);
            if (row != null)
            {
                vaildVID = true;
                string name = (string)row["Name"];
                txtItemName.Text = name;
                txtQuantity.Text = "";
                return;
            }
            vaildRequestVID = false;
            txtItemName.Text = "";
            txtQuantity.Text = "";
        }


        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            de.Debounce(() => CheckeItemID());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!vaildVID)
            {
                MessageBox.Show("Item ID already exist.", "Fail to insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string input = txtQuantity.Text.Trim();
            int quantity = string.IsNullOrEmpty(input) ? 0 : Int32.Parse(input);
            if (quantity <= 0)
            {
                MessageBox.Show("Invaild quantity.", "Fail to insert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SQLHandler.InsertItemToRequest(restData, txtRequestID.Text, txtItemID.Text, quantity);
            UpdateItemTable();
        }

        private void itemTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastIndex = e.RowIndex;
            DataTable table = (DataTable)itemTable.DataSource;
            if (lastIndex >= table.Rows.Count || lastIndex < 0)
            {
                return;
            }

            DataRow data = table.Rows[lastIndex];
            string name = (string)data["Name"];
            string VID = (string)data["VirtualID"];
            string quantity = ((int)data["Quantity"]).ToString();
            txtItemName.Text = name;
            txtItemID.Text = VID;
            txtQuantity.Text = quantity;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool success = SQLHandler.RemoveItemFromRequest(restData, txtRequestID.Text, txtItemID.Text);
            if (!success)
            {
                MessageBox.Show("Something went wrong.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateItemTable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FrmEditRequest_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }
        
        private void logutBtn_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
