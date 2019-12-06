using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            lbluser.Visible = false;
            lblpass.Visible = false;
            lbluserpass.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == Properties.Settings.Default.username && txtpass.Text == Properties.Settings.Default.password)
            {
                this.Visible=false;
            }

            else if(txtuser.Text != Properties.Settings.Default.username && txtpass.Text != Properties.Settings.Default.password)
            {
                lbluserpass.Visible = true;
                lbluser.Visible = true;
                lblpass.Visible = true;

            }
            else if(txtuser.Text == Properties.Settings.Default.username && txtpass.Text != Properties.Settings.Default.password)
            {
                lblpass.Visible = true;
            }
            else if(txtuser.Text != Properties.Settings.Default.username && txtpass.Text == Properties.Settings.Default.password)
            {
                lbluser.Visible = true;
            }










        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
