using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;


using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace sendmail
{
    public partial class Form1 : Form
    {
        Attachment attack = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txbAttack.Text = dialog.FileName;
            }
        }
        void Sentmail(string from, string to, string subject, string message, Attachment file = null)
        {
            try
            {
                MailMessage Message = new MailMessage(from, to, subject, message);

                if (file != null)
                {
                    Message.Attachments.Add(file);
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;


                client.Credentials = new NetworkCredential(txbId.Text, txbPassword.Text);

                client.Send(Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn nhập sai ID hoặc password!, vui lòng kiểm tra lại!");
            }
        }

    }
}

