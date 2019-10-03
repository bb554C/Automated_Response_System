using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COE114L_Projectv3
{
    public partial class ARSHomeForm : Form
    {
        Account A = new Account();
        public ARSHomeForm()
        {
            InitializeComponent();
            A.ReadCurrentloginTXT();
            A.TransferIdentifierDBData();
            A.ReadAccountsTXT();
            A.TransferAccountsDBData();
            label1.Text = "Welcome " + A.prop_Username;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            TextWriter TW = new StreamWriter("ARS_CurrentLogin.txt", false);
            TW.WriteLine("");
            TW.Close();
            this.Hide();
            LoginForm LF = new LoginForm();
            LF.Closed += (s, args) => this.Close();
            LF.Show();
        }
    }
}
