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
    public partial class changesetting : Form
    {
        public changesetting()
        {
            InitializeComponent();
            lblmsgerror.Visible = false;
            lblmsgerror2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtuser.Text = Properties.Settings.Default.username;
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.Text = Properties.Settings.Default.password;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == Properties.Settings.Default.password)
            {
               
                if (newtxtpass.Text == newtxtpass2.Text)
                {
                    Properties.Settings.Default.password = newtxtpass.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("تم تغيير كلمه السر بنجاح !");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    newtxtpass.Text = "";
                    newtxtpass2.Text = "";
                }
                else
                {
                    lblmsgerror2.Visible = true;
                 }
            }
            else
            {
                lblmsgerror.Visible = true;
            }
        }

        private void changesetting_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                newtxtpass.Focus();
            }
        }

        private void newtxtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newtxtpass2.Focus();
            }
        }

        private void newtxtpass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok.PerformClick();
            }
        }
    }
}
