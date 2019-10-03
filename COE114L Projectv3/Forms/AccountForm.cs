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
    public partial class AccountForm : Form
    {
        private bool check = false;

        Account A = new Account();

        //-CONSTRUCTOR-\\
        //-START-\\
        public AccountForm()
        {
            InitializeComponent();
        }
        //-END-\\

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LF = new LoginForm();
            LF.Closed += (s, args) => this.Close();
            LF.Show();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            buttonCheck_Click(sender, e);
            A.prop_Password = textBoxPassword.Text;
            if (radioButtonMale.Checked)
            {
                A.prop_Gender = radioButtonMale.Text;
            }
            else
            {
                A.prop_Gender = radioButtonFemale.Text;
            }
            A.prop_Line1 = textBoxLine1.Text;
            A.prop_Line2 = textBoxLine2.Text;
            A.prop_BaranggayDistrict = textBoxBaranggay_District.Text;
            A.prop_CityMunicipality = textBoxCity_Municipality.Text;
            A.prop_Province = textBoxProvince.Text;
            A.prop_Country = textBoxCountry.Text;
            A.FixFormat();
            if (A.prop_Gender == "")
            {
                MessageBox.Show("Missing Gender", "Input ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxPassword.Text != textBoxConfirmPassword.Text || textBoxPassword.Text.Length <= 4)
            {
                MessageBox.Show("Please verify your password\nPasswords must be\nFour (4) or more characters long", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxBaranggay_District.Text == "" || textBoxBaranggay_District.Text.Length <= 3)
            {
                MessageBox.Show("Missing Baranggay/District", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxProvince.Text == "" || textBoxProvince.Text.Length <= 3)
            {
                MessageBox.Show("Missing Province", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxCountry.Text == "" || textBoxCountry.Text.Length <= 3)
            {
                MessageBox.Show("Missing Country", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (check == true)
            {
                if ((MessageBox.Show("Do you want to create an account?\nName: " + A.prop_FirstName + " " + A.prop_LastName + "\nUsername: " + A.prop_Username, "Confirm Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    A.WriteAccountsTXT();
                    MessageBox.Show("Your account has been created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonBack_Click(sender, e);
                }
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            check = true;
            A.prop_FirstName = textBoxFirstName.Text;
            A.prop_LastName = textBoxLastName.Text;
            A.prop_Email = textBoxEmail.Text;
            A.prop_ConfirmEmail = textBoxConfirmEmail.Text;
            A.prop_Username = textBoxUsername.Text;
            A.FixFormat();
            this.textBoxFirstName.Text = A.prop_FirstName;
            this.textBoxLastName.Text = A.prop_LastName;
            this.textBoxEmail.Text = A.prop_Email;
            this.textBoxConfirmEmail.Text = A.prop_ConfirmEmail;
            this.textBoxUsername.Text = A.prop_Username;
            if (textBoxFirstName.Text == "" || textBoxFirstName.Text.Length < 2)
            {
                MessageBox.Show("Missing First Name", "Input ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxLastName.Text == "" || textBoxLastName.Text.Length < 2)
            {
                MessageBox.Show("Missing Last Name", "Input ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxEmail.Text == "" || textBoxConfirmEmail.Text == "")
            {
                MessageBox.Show("Missing Email", "Input ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxEmail.Text != textBoxConfirmEmail.Text || !textBoxEmail.Text.Contains('@'))
            {
                MessageBox.Show("Please input a valid email", "Incorrect email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Missing Username", "Input ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            A.ReadAccountsTXT();
            if (textBoxUsername.Text == A.prop_UsernameDB)
            {
                MessageBox.Show("Please choose another username", "Username Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            else if (A.prop_Username != "")
            {
                MessageBox.Show("Username is available", "Username Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPassword.Focus();
            }
        }

        

        //-USER CONVENIENCE PROCESS-\\
        //-START-\\
        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstName.Focus();
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFirstName.Focus();
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxLastName.Focus();
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxConfirmEmail.Focus();
            }
        }

        private void textBoxConfirmEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxUsername.Focus();
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                buttonCheck_Click(sender, e);
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxConfirmPassword.Focus();
            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxLine1.Focus();
            }
        }

        private void textBoxLine1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxLine2.Focus();
            }
        }

        private void textBoxLine2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxBaranggay_District.Focus();
            }
        }

        private void textBoxBaranggay_District_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxCity_Municipality.Focus();
            }
        }

        private void textBoxCity_Municipality_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxProvince.Focus();
            }
        }

        private void textBoxProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxCountry.Focus();
            }
        }

        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                buttonCreateAccount_Click(sender, e);
            }
        }
        //-END-\\
    }
}