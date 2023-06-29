using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YummyRestaurantSystem.src.RM;

namespace YummyRestaurantSystem
{
    public partial class FrmDetailsRequestRestMan : Form
    {
        private DataRow requestData;
        private DataRow staffData;

        public bool logout = false;

        public FrmDetailsRequestRestMan(string restname, DataRow data)
        {
            InitializeComponent();
            lblRestaurant.Text = $"{restname} Request Details";
            requestData = data;
            txtRequestID.Text = (string)requestData["RequestID"];
            txtManagerID.Text = (string)requestData["ManagerID"];
            txtRestID.Text = (string)requestData["RequestID"];
            dateCreate.Value = (DateTime)requestData["CreatedDate"];
            dateExpect.Value = (DateTime)requestData["ExpectedDeliveryDate"];
            txtRemark.Text = requestData["Remark"] as string;
            string state = (string)requestData["State"];
            switch (state)
            {
                case "P":
                    txtState.Text = "Pending";
                    break;
                case "F":
                    txtState.Text = "Failed";
                    break;
                case "D":
                    txtState.Text = "Delivering";
                    break;
                case "C":
                    txtState.Text = "Completed";
                    break;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmDetailsRequestRestMan_Load(object sender, EventArgs e)
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
            Close();
        }

        private void btnCDN_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCheckDeliveryNoteStatus_Rest_Man_ form = new FrmCheckDeliveryNoteStatus_Rest_Man_(staffData);
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
