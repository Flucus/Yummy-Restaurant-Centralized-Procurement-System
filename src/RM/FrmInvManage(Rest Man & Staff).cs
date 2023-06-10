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
    public partial class FrmInvManage : Form
    {
        private DataRow data;

        public bool logout = false;

        public FrmInvManage(DataRow data)
        {
            InitializeComponent();
            this.data = data;
        }
    }
}
