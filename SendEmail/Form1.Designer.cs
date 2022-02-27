namespace SendEmail
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_body = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_emailpasswordset = new System.Windows.Forms.Label();
            this.hideunhidepass = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.MaskedTextBox();
            this.tb_reciever = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_attch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_body
            // 
            this.tb_body.Location = new System.Drawing.Point(97, 80);
            this.tb_body.Name = "tb_body";
            this.tb_body.Size = new System.Drawing.Size(404, 140);
            this.tb_body.TabIndex = 0;
            this.tb_body.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_emailpasswordset);
            this.groupBox1.Controls.Add(this.hideunhidepass);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(519, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email - log in";
            // 
            // lbl_emailpasswordset
            // 
            this.lbl_emailpasswordset.BackColor = System.Drawing.Color.Transparent;
            this.lbl_emailpasswordset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_emailpasswordset.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_emailpasswordset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_emailpasswordset.Location = new System.Drawing.Point(0, 209);
            this.lbl_emailpasswordset.Name = "lbl_emailpasswordset";
            this.lbl_emailpasswordset.Size = new System.Drawing.Size(200, 38);
            this.lbl_emailpasswordset.TabIndex = 4;
            this.lbl_emailpasswordset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hideunhidepass
            // 
            this.hideunhidepass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hideunhidepass.BackColor = System.Drawing.Color.Transparent;
            this.hideunhidepass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hideunhidepass.BackgroundImage")));
            this.hideunhidepass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideunhidepass.ForeColor = System.Drawing.Color.Transparent;
            this.hideunhidepass.Location = new System.Drawing.Point(166, 123);
            this.hideunhidepass.Name = "hideunhidepass";
            this.hideunhidepass.Size = new System.Drawing.Size(26, 28);
            this.hideunhidepass.TabIndex = 3;
            this.hideunhidepass.UseVisualStyleBackColor = false;
            this.hideunhidepass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hideunhidepass_MouseDown);
            this.hideunhidepass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hideunhidepass_MouseUp);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(18, 167);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(80, 28);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "log-in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(18, 126);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(149, 22);
            this.tb_password.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(18, 84);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(172, 22);
            this.tb_email.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 52);
            this.label4.TabIndex = 5;
            this.label4.Text = "Make sure to enter a valid Email and enter your password correctly.";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(97, 39);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(360, 22);
            this.tb_subject.TabIndex = 3;
            // 
            // tb_reciever
            // 
            this.tb_reciever.Location = new System.Drawing.Point(97, 255);
            this.tb_reciever.Name = "tb_reciever";
            this.tb_reciever.Size = new System.Drawing.Size(307, 22);
            this.tb_reciever.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(426, 255);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_attch
            // 
            this.btn_attch.Location = new System.Drawing.Point(97, 226);
            this.btn_attch.Name = "btn_attch";
            this.btn_attch.Size = new System.Drawing.Size(404, 23);
            this.btn_attch.TabIndex = 9;
            this.btn_attch.Text = "Attach files";
            this.btn_attch.UseVisualStyleBackColor = true;
            this.btn_attch.Click += new System.EventHandler(this.btn_attch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 291);
            this.Controls.Add(this.btn_attch);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_reciever);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_body);
            this.Name = "Form1";
            this.Text = "Email app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tb_body;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tb_subject;
        private System.Windows.Forms.MaskedTextBox tb_reciever;
        private System.Windows.Forms.MaskedTextBox tb_password;
        private System.Windows.Forms.MaskedTextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button hideunhidepass;
        private System.Windows.Forms.Label lbl_emailpasswordset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_attch;
    }
}

