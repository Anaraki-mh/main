using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace SendEmail
{

    public partial class Form1 : Form
    {
        public static string email = "";
        public static string password = "";

        public static string attchstring = "";
        public Form1()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';





        }

        public void login(out string email, out string password)
        {
            email = tb_email.Text;
            password = tb_password.Text;


        }

        public void sendemail(string email, string password)
        {
            var smtpclient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(email, password),
                EnableSsl = true,
            };

            if ((email != "") && (password != "") && (tb_body.Text != "") && (tb_subject.Text != ""))
            {
                var mailmessage = new MailMessage
                {
                    From = new MailAddress(email),
                    Subject = tb_subject.Text,
                    Body = tb_body.Text,
                    IsBodyHtml = false,
                };
                mailmessage.To.Add(tb_reciever.Text);
                if (attchstring != "")
                {
                    var attachment = new Attachment(attchstring);
                    mailmessage.Attachments.Add(attachment);
                }
                smtpclient.Send(mailmessage);
            }
            else
            {
                MessageBox.Show("Subjet, body, Email addresses and password can not be empty");
            }

        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            login(out email, out password);
            if (email != "" && password != "")
                lbl_emailpasswordset.Text = "Email and Password set! \n Ready to send your Email!";
        }

        public void btn_send_Click(object sender, EventArgs e)
        {
            sendemail(email, password);
            MessageBox.Show("Email sent!");
        }

        private void hideunhidepass_MouseDown(object sender, MouseEventArgs e)
        {
            tb_password.PasswordChar = '\0';
        }

        private void hideunhidepass_MouseUp(object sender, MouseEventArgs e)
        {
            tb_password.PasswordChar = '*';
        }

        private void btn_attch_Click(object sender, EventArgs e)
        {
            var openfile = new OpenFileDialog();
            openfile.Filter = "All Files (*.*)|*.*";
            openfile.FilterIndex = 1;
            openfile.Multiselect = false;
            openfile.Title = "select the attachments";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                attchstring = openfile.FileName;
            }

        }
    }

}
