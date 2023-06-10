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
    public partial class FrmInvModify : Form
    {
        private DataRow restData;
        private DataRow record;

        public bool logout = false;
        public bool modified = false;

        public FrmInvModify(DataRow restData, DataRow record)
        {
            InitializeComponent();
            this.restData = restData;
            this.record = record;
            string restName = restData["Name"].ToString();
            lblRestaurant.Text = $"{restName} Inventory Modify";
            txtSearch.Text = record["Name"].ToString();
            txtAmount.Text = record["Count"].ToString();
        }

        private void FrmInvModify_Load(object sender, EventArgs e)
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            int count;
            if (int.TryParse(txtAmount.Text, out count))
            {
                if (count < 0) return;
                string locID = (string)restData["LocID"];
                string VID = (string)record["VirtualID"];
                string typeID = (string)restData["TypeID"];
                DataRow itemData = SQLHandler.GetItemByVIDTypeID(VID, typeID);
                string itemID = (string)itemData["ItemID"];
                SQLHandler.UpdateInvCount(locID, itemID, count);
                MessageBox.Show("Amount have been updated.", "Success to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                modified = true;
                return;
            }
            MessageBox.Show("Invalid amount.", "Fail to update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
