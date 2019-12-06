namespace SchoolManagement
{
    partial class changesetting
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
            this.lblmsgerror2 = new System.Windows.Forms.Label();
            this.lblmsgerror = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newtxtpass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newtxtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblmsgerror2);
            this.groupBox1.Controls.Add(this.lblmsgerror);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newtxtpass2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newtxtpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ادخل البيانات الجديده";
            // 
            // lblmsgerror2
            // 
            this.lblmsgerror2.AutoSize = true;
            this.lblmsgerror2.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerror2.Location = new System.Drawing.Point(179, 334);
            this.lblmsgerror2.Name = "lblmsgerror2";
            this.lblmsgerror2.Size = new System.Drawing.Size(173, 19);
            this.lblmsgerror2.TabIndex = 11;
            this.lblmsgerror2.Text = "كلمه المرور غير متطابقه!";
            // 
            // lblmsgerror
            // 
            this.lblmsgerror.AutoSize = true;
            this.lblmsgerror.ForeColor = System.Drawing.Color.Red;
            this.lblmsgerror.Location = new System.Drawing.Point(151, 175);
            this.lblmsgerror.Name = "lblmsgerror";
            this.lblmsgerror.Size = new System.Drawing.Size(225, 19);
            this.lblmsgerror.TabIndex = 10;
            this.lblmsgerror.Text = "كلمه المرور القديمه غير صحيحه!";
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::SchoolManagement.Properties.Resources.delete_icon__1_2;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.Location = new System.Drawing.Point(102, 372);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(82, 38);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "اغلاق";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnok
            // 
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Image = global::SchoolManagement.Properties.Resources.red_ok_icon;
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnok.Location = new System.Drawing.Point(235, 372);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(82, 38);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "تم";
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "اعاده كلمه المرور الجديده:";
            // 
            // newtxtpass2
            // 
            this.newtxtpass2.Location = new System.Drawing.Point(129, 298);
            this.newtxtpass2.Multiline = true;
            this.newtxtpass2.Name = "newtxtpass2";
            this.newtxtpass2.PasswordChar = '*';
            this.newtxtpass2.Size = new System.Drawing.Size(251, 33);
            this.newtxtpass2.TabIndex = 6;
            this.newtxtpass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newtxtpass2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمه المرورالجديده:";
            // 
            // newtxtpass
            // 
            this.newtxtpass.Location = new System.Drawing.Point(129, 231);
            this.newtxtpass.Multiline = true;
            this.newtxtpass.Name = "newtxtpass";
            this.newtxtpass.PasswordChar = '*';
            this.newtxtpass.Size = new System.Drawing.Size(251, 33);
            this.newtxtpass.TabIndex = 4;
            this.newtxtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newtxtpass_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "كلمه المرور القديمه:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(133, 139);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(251, 33);
            this.txtpass.TabIndex = 2;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المستخدم:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(9, 67);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(251, 34);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // changesetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(405, 436);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "changesetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير الحساب";
            this.Load += new System.EventHandler(this.changesetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newtxtpass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newtxtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblmsgerror2;
        private System.Windows.Forms.Label lblmsgerror;
    }
}