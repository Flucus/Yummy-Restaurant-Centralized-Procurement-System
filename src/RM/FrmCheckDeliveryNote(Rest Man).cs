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

namespace YummyRestaurantSystem.src.RM
{
    public partial class FrmCheckDeliveryNoteStatus_Rest_Man_ : Form
    {
        private DataRow staffData;
        private DataRow restData;
        private string locID;
        private string restName;
        private int lastIndex = -1;

        public bool logout = false;

        public FrmCheckDeliveryNoteStatus_Rest_Man_(DataRow staffData)
        {
            InitializeComponent();
            this.staffData = staffData;

            locID = (string)staffData["LocID"];
            restData = SQLHandler.GetRestaurantData(locID);
            restName = (string)restData["Name"];
            lblRestaurant.Text = $"{restName} Check Delivery Note";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmUpdateDeliveryNoteStatus_Rest_Man__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void txtNoteID_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQLHandler.GetDeliveryNoteDetails(txtNoteID.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
