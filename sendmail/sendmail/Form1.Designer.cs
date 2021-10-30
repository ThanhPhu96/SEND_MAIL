
namespace sendmail
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
            this.lblfile = new System.Windows.Forms.Label();
            this.txbAttack = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSent = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(29, 32);
            this.lblfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(38, 17);
            this.lblfile.TabIndex = 11;
            this.lblfile.Text = "File :";
            // 
            // txbAttack
            // 
            this.txbAttack.Location = new System.Drawing.Point(150, 32);
            this.txbAttack.Margin = new System.Windows.Forms.Padding(4);
            this.txbAttack.Name = "txbAttack";
            this.txbAttack.ReadOnly = true;
            this.txbAttack.Size = new System.Drawing.Size(405, 22);
            this.txbAttack.TabIndex = 12;
            this.txbAttack.TabStop = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(621, 32);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(111, 28);
            this.btnAttack.TabIndex = 13;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(34, 97);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(33, 17);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "To :";
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(152, 92);
            this.txbTo.Margin = new System.Windows.Forms.Padding(4);
            this.txbTo.Name = "txbTo";
            this.txbTo.ReadOnly = true;
            this.txbTo.Size = new System.Drawing.Size(405, 22);
            this.txbTo.TabIndex = 15;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(621, 92);
            this.btnDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(115, 28);
            this.btnDanhSach.TabIndex = 16;
            this.btnDanhSach.Text = "Mail List";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(29, 170);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(63, 17);
            this.lblSubject.TabIndex = 17;
            this.lblSubject.Text = "Subject :";
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(150, 170);
            this.txbSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(407, 22);
            this.txbSubject.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(29, 236);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(113, 17);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Tên đăng nhập :";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(150, 236);
            this.txbId.Margin = new System.Windows.Forms.Padding(4);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(407, 22);
            this.txbId.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(34, 293);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 17);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Mật khẩu :";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(148, 290);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(407, 22);
            this.txbPassword.TabIndex = 22;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(34, 354);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 17);
            this.lblMessage.TabIndex = 23;
            this.lblMessage.Text = "Message";
            // 
            // btnSent
            // 
            this.btnSent.Location = new System.Drawing.Point(152, 348);
            this.btnSent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(100, 28);
            this.btnSent.TabIndex = 24;
            this.btnSent.Text = "Sent";
            this.btnSent.UseVisualStyleBackColor = true;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(32, 408);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(759, 151);
            this.txbMessage.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(37, 621);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(419, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "https://www.google.com/settings/u/1/security/lesssecureapps";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(493, 626);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "cho phép để sử dụng theo dường link";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txbSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txbAttack);
            this.Controls.Add(this.lblfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.TextBox txbAttack;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

