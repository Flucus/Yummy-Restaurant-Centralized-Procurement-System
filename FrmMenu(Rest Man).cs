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
    public partial class FrmMenuRestMan : Form
    {
        private DataRow data;
        public FrmMenuRestMan(DataRow data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void btnInvMan_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmInvManage form = new FrmInvManage(data);
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnOrderPlacement_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmItemRequest form = new FrmItemRequest(data);
            form.ShowDialog();
            this.Visible = true;
        }

        private void btnCheckReq_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCheckReq form = new FrmCheckReq(data);
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
