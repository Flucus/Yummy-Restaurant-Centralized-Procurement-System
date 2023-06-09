using MySql.Data.MySqlClient;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtpw.BackColor = SystemColors.Control;
        }

        private void txtpw_Click(object sender, EventArgs e)
        {
            txtpw.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtuser.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txtpw.PasswordChar = '●';
            cbnShowPw.Checked = false;
        }

        private void cbnShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnShowPw.Checked)
            {
                txtpw.PasswordChar = '\0';
            }
            else
            {
                txtpw.PasswordChar = '●';
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = txtuser.Text;
            string pw = txtpw.Text;
            DataRow data = SQLHandler.CheckLogin(acc, pw);
            if (data == null)
            {
                MessageBox.Show("Wrong account name or password.", "Fail to login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };
            string userGroup = (string)data["UserGroup"];
            switch (userGroup)
            {
                case "Restaurant Manager":
                    {
                        this.Visible = false;
                        FrmMenuRestMan menu = new FrmMenuRestMan(data);
                        menu.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                case "Restaurant Staff":
                    {
                        this.Visible = false;
                        FrmInvManage menu = new FrmInvManage(data);
                        menu.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                case "Category Manager":
                    {
                        this.Visible = false;
                        FrmMenuCatMan menu = new FrmMenuCatMan(data);
                        menu.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                case "Administrator":
                    {
                        this.Visible = false;
                        FrmUserManage menu = new FrmUserManage(data);
                        menu.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                case "Purchase Manager":
                    {
                        this.Visible = false;
                        FrmMenuPurMan menu = new FrmMenuPurMan(data);
                        menu.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                case "Warehouse Clerk":
                    {
                        this.Visible = false;
                        FrmMenuWhClerk menu = new FrmMenuWhClerk(data);
                        menu.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                case "Buyer":
                    {
                        MessageBox.Show("This client is not for buyer.", "Fail to login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                default:
                    {
                        MessageBox.Show("Unknown user group.", "Fail to login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
            }
        }
    }
}
