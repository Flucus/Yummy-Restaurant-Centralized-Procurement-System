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
    public partial class Form2 : Form
    {
        public Form2()
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
        }

        private void cbnShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnShowPw.Checked)
            {
                txtpw.PasswordChar = '\0';
            }else
            {
                txtpw.PasswordChar = '●';
            }
        }
    }
}
