using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem.src.Admin
{
    public partial class FrmActivityLog_Admin_ : Form
    {
        public bool logout = false;

        public FrmActivityLog_Admin_()
        {
            InitializeComponent();
            AutoUpdateTable();
        }

        public async Task AutoUpdateTable()
        {
            while (true)
            {
                dgvUserList.DataSource = SQLHandler.GetActivityLog();
                lastUpdateLbl.Text = "Last update: " + DateTime.Now.ToString("hh:mm:ss tt");
                await Task.Delay(TimeSpan.FromSeconds(30));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void FrmActivityLog_Admin__Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }
    }
}
