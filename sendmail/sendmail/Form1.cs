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
    }
}

