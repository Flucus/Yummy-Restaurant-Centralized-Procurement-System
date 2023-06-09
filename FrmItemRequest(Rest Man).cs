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
    public partial class FrmItemRequest : Form
    {
        private DataRow data;
        public FrmItemRequest(DataRow data)
        {
            InitializeComponent();
            this.data = data;
        }
    }
}
