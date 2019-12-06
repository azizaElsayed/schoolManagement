namespace SchoolManagement
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbluserpass = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbluserpass);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ادخل البيانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbluserpass
            // 
            this.lbluserpass.AutoSize = true;
            this.lbluserpass.ForeColor = System.Drawing.Color.Red;
            this.lbluserpass.Location = new System.Drawing.Point(64, 37);
            this.lbluserpass.Name = "lbluserpass";
            this.lbluserpass.Size = new System.Drawing.Size(369, 19);
            this.lbluserpass.TabIndex = 8;
            this.lbluserpass.Text = "من فضلك ادخل اسم المستخدم وكلمه السر الصحيحه";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ForeColor = System.Drawing.Color.Red;
            this.lblpass.Location = new System.Drawing.Point(83, 173);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(46, 19);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "* * *";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.ForeColor = System.Drawing.Color.Red;
            this.lbluser.Location = new System.Drawing.Point(83, 96);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(46, 19);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "* * *";
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::SchoolManagement.Properties.Resources.delete_icon__1_1;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.Location = new System.Drawing.Point(133, 243);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(93, 35);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "اغلاق";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Image = global::SchoolManagement.Properties.Resources.add_icon1;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.Location = new System.Drawing.Point(296, 243);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(93, 35);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "دخول\r\n";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمه السر:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(213, 173);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(263, 34);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المستخدم:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(213, 93);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(263, 34);
            this.txtuser.TabIndex = 0;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(511, 323);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbluserpass;
    }
}