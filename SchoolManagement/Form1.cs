using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=NOURINNET-PC\SQLEXPRESS;Database=SchoolDB;Integrated Security=true");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        string tableName="class1_s1";
            
        public Form1()
        {
            InitializeComponent();
            txtcountstd.Text = "";
            //txtcountstd.Enabled = false;
            //groupBox2.Enabled = false;
            //groupBox1.Enabled = false;


        }

        private void FillData()
        {
            string select = "Select * from" + "  " + tableName;
            da =new SqlDataAdapter(select, cn);
            dt.Rows.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
             txtcountstd.Text = (dataGridView1.Rows.Count-1).ToString();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.username != "" && Properties.Settings.Default.password != "")
            {
                login frmlogin = new login();
                frmlogin.ShowDialog();
            }

            comboBox1.SelectedIndex = 1;
          

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frmlogin = new login();
            frmlogin.ShowDialog();
        }

        private void تغييرالحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changesetting frmchange = new changesetting();
            frmchange.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void الشعبهالاوليToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // tableName = "class1_s1";
            FillData();
            

        }

        private void الشعبهالتانيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableName = "class1_s2";
            FillData();
        }

        private void الشعبهالاوليToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tableName = "class2_s1";
            FillData();
        }

        private void الشعبهالتانيهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tableName = "class2_s2";
            FillData();
        }

        private void الشعبهالاوليToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tableName = "class3_s1";
            FillData();
        }

        private void الشعبهالتانيهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tableName = "class3_s2";
            FillData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string select = "Select * from "+" "+tableName+"  where " + comboBox1.Text + " like '%" + txtsearch.Text +"%'" ;

            SqlDataAdapter da2 = new SqlDataAdapter(select, cn);
                
                //("Select * from "+tableName+"where"+comboBox1.Text+" = '"+txtsearch.Text+"'  ",cn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tableName != "")
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                 }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حذف هذا الطالب؟","رساله حذف", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string select = "Delete  from " + "   " + tableName+"  " +"Where ID="+ dataGridView1.CurrentRow.Cells[0].Value;
                
                cmd = new SqlCommand(select, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("تم حذف الطالب بنجاح !", "رساله حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FillData();
            }



        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("Update"+ " " + tableName +"  "+  "set std_FName='"+txtfname2.Text+"',std_LName='"+txtlname2.Text+"',std_Address='"+txtaddress2.Text+"',std_Phone='"+txtphone2.Text+"'   where  ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'", cn);
            //dataGridView1.CurrentRow.Cells[1].Value = txtfname2.Text;
            //dataGridView1.CurrentRow.Cells[2].Value = txtlname2.Text;
            //dataGridView1.CurrentRow.Cells[3].Value = txtaddress2.Text;
            //dataGridView1.CurrentRow.Cells[4].Value = txtphone2.Text;
            //dataGridView1.CurrentRow.Cells[5].Value = pic.Image;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            FillData();
            MessageBox.Show("تم تحديث البيانات بنجاح !", " رساله تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture Name |*.png;*.jpg;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(txtfname.Text == "" && txtlname.Text == "" && txtaddress.Text == "" && txtphone.Text == "" && picimage.Image == null))
            {
                // store image
                byte[] pic = null;
                FileStream fs = new FileStream(ofd.FileName,FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                pic = br.ReadBytes((int)fs.Length);

                cmd = new SqlCommand("Insert  into " + "  " + tableName + "  " + "(std_FName,std_LName,std_Address,std_Phone,std_Photo) values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtaddress.Text + "','" + int.Parse(txtphone.Text) + "',@img);", cn);
                cmd.Parameters.Add(new SqlParameter("@img",pic));
                
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("تم اضافه الطالب بنجاح !", "اضافه طالب", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtfname.Text = "";
                txtlname.Clear();
                txtaddress.Clear();
                txtphone.Clear();
                picimage.Image = null;
                FillData();

            }
            else
            {
                MessageBox.Show("من فضلك قم بادخال البيانات !", "رساله خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            txtfname.Focus();

        }

        private void txtfname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlname.Focus();
            }
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtaddress.Focus();
            }
        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtphone.Focus();
            }
        }

        private void txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbladd.Focus();
            }
        }

        private void lbladd_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks==(char)Keys.Enter)
            {
                btnok2.PerformClick();
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            //lbladdimg.Visible = false;
            timer4.Enabled = true;
            SqlDataAdapter da = new SqlDataAdapter ("Select * from" + "  " + tableName + "  " + "Where ID='"+dataGridView1.CurrentRow.Cells[0].Value+"' ", cn);
           // cn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtfname2.Text = dt.Rows[0]["std_FName"].ToString();
            txtlname2.Text= dt.Rows[0]["std_LName"].ToString();
            txtaddress2.Text= dt.Rows[0]["std_Address"].ToString();
            txtphone2.Text= dt.Rows[0]["std_Phone"].ToString();
            byte[] b = (byte[])(dt.Rows[0]["std_Photo"]);
            MemoryStream ms = new MemoryStream(b);
            pic.Image = Image.FromStream(ms);
           // cmd.ExecuteReader();
           // cn.Close();



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            groupBox3.Left = groupBox3.Left + 15;
            if (groupBox3.Left >= 60)
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            groupBox3.Left = groupBox3.Left - 15;
            if(groupBox3.Left<= -320)
            {
                timer3.Enabled = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            groupBox4.Top = groupBox4.Top -20;
            if (groupBox4.Top <= 60)
            {
                timer4.Enabled = false;
            }
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            groupBox4.Top = groupBox4.Top + 20;
            if (groupBox4.Top >= 727)
            {

                timer4.Enabled = false;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
 