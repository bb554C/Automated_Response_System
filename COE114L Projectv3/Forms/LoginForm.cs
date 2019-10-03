using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COE114L_Projectv3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Automated Reporting System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            AccountForm AF = new AccountForm();
            this.Hide();
            AF.Closed += (s, args) => this.Close();
            AF.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Account A = new Account();
            A.prop_Username = textBoxUsername.Text;
            A.ReadAccountsTXT();
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("No username or password entry", "Login ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUsername.Text != A.prop_UsernameDB)
            {
                if (MessageBox.Show("Account does not exist\nDo you want to create an account?", "Login ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    buttonCreateAccount_Click(sender, e);
                }
                else
                {
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
            }
            else if (textBoxPassword.Text != A.prop_PasswordDB)
            {
                MessageBox.Show("Password is incorrect\nPlease make sure you are using the correct username and password", "Login ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
            }
            else if (textBoxUsername.Text == A.prop_UsernameDB && textBoxPassword.Text == A.prop_PasswordDB)
            {
                A.TransferAccountsDBData();
                A.WriteCurrentLoginTXT();
                this.Hide();
                HomeForm ARSHF = new HomeForm();
                ARSHF.Closed += (s, args) => this.Close();
                ARSHF.Show();
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string helpfileloc = "ARS_Help.txt";
            TextWriter TW = new StreamWriter(helpfileloc,false);
            TW.WriteLine("Login Form Help");
            TW.WriteLine();
            TW.WriteLine("You must enter a valid username and password");
            TW.WriteLine("If you forgot your username and/or password");
            TW.WriteLine("Please contact ARS admins at");
            TW.WriteLine("0998 XXX XXXX or ARSadminHelp@xxxx.com");
            TW.WriteLine();
            TW.WriteLine("If you do not have a valid account");
            TW.WriteLine("You must create an account using the 'CREATE ACCOUNT' button");
            TW.WriteLine();
            TW.WriteLine("If you have an existing account");
            TW.WriteLine("Fill up the username and password");
            TW.WriteLine("then click the 'LOGIN' button");
            TW.Close();
            System.Diagnostics.Process.Start(helpfileloc);
        }
    }
}