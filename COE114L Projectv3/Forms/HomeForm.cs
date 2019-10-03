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
    public partial class HomeForm : Form
    {
        Account A = new Account();
        public HomeForm()
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

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form is connecting to the internet\nPlease make sure you are connected to the internet\nThe form may take some time to load depending on the speed of your internet connection", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CreateReportForm CR = new CreateReportForm();
            CR.Closed += (s, args) => this.Close();
            CR.Show();
            this.Hide();
        }

        private void buttonViewReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReportForm VR = new ViewReportForm();
            VR.Closed += (s, args) => this.Close();
            VR.Show();
        }
    }
}
