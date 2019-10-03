using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.MapProviders;
using GMap.NET.Properties;

namespace COE114L_Projectv3
{
    public partial class CreateReportForm : Form
    {
        string currentloc = "",
            newloc = "";

        Account A = new Account();
        Reports R = new Reports();

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        public CreateReportForm()
        {
            InitializeComponent();
        }

        private void CreateReport_Load(object sender, EventArgs e)
        {
            A.ReadCurrentloginTXT();
            A.TransferIdentifierDBData();
            A.ReadAccountsTXT();
            A.TransferAccountsDBData();
            currentloc = A.prop_BaranggayDistrict + "," + A.prop_CityMunicipality + "," + A.prop_Province + "," + A.prop_Country;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords(currentloc);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm HF = new HomeForm();
            HF.Closed += (s, args) => this.Close();
            HF.Show();
        }

        private void gmaps_Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                groupBoxEntry.Enabled = true;
                double lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
                textBoxLatitude.Text = lat.ToString();
                textBoxLongitude.Text = lng.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            gmap.Zoom = 13;
            R.prop_BaranggayDistrict = textBoxBaranggayDistrict.Text;
            R.prop_CityMunicipality = textBoxCityMunicipality.Text;
            R.prop_Province = textBoxProvince.Text;
            R.prop_Country = textBoxCountry.Text;
            R.FixFormat();
            textBoxBaranggayDistrict.Text = R.prop_BaranggayDistrict;
            textBoxCityMunicipality.Text = R.prop_CityMunicipality;
            textBoxProvince.Text = R.prop_Province;
            textBoxCountry.Text = R.prop_Country;
            
            newloc = textBoxBaranggayDistrict.Text + "," + textBoxCityMunicipality.Text + "," + textBoxProvince.Text + "," + textBoxCountry.Text;
            gmap.SetPositionByKeywords(newloc);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxEntry.Enabled = false;
            textBoxBaranggayDistrict.Clear();
            textBoxCityMunicipality.Clear();
            textBoxProvince.Clear();
            textBoxCountry.Clear();
            textBoxLatitude.Clear();
            textBoxLongitude.Clear();
            textBoxTitle.Clear();
            textBoxDesc.Clear();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            R.prop_Title = textBoxTitle.Text;
            R.prop_Desc = textBoxDesc.Text;
            R.prop_Lat = double.Parse(textBoxLatitude.Text);
            R.prop_Lng = double.Parse(textBoxLongitude.Text);
            R.FixFormat();
            textBoxTitle.Text = R.prop_Title;
            textBoxDesc.Text = R.prop_Desc;
            R.WriteReportsListTXT();
            MessageBox.Show("Report Created Sucessfully", "Create Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(MessageBox.Show("Do you want to create another report?","Create Report",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                buttonClear_Click(sender, e);
            }
            else
            {
                buttonBack_Click(sender, e);
            }
        }

        //-USER CONVENIENCE PROCESS-\\
        //-START-\\
        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            buttonCreateReport.Enabled = true;
        }

        private void textBoxBaranggayDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxCityMunicipality.Focus();
            }
        }

        private void textBoxCityMunicipality_KeyPress(object sender, KeyPressEventArgs e)
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
                buttonSearch_Click(sender, e);
            }
        }

        private void textBoxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                textBoxDesc.Focus();
            }
        }

        private void textBoxDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                buttonCreateReport_Click(sender,e);
            }
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string helpfileloc = "ARS_Help.txt";
            TextWriter TW = new StreamWriter(helpfileloc, false);
            TW.WriteLine("Create Report Help");
            TW.WriteLine();
            TW.WriteLine("Steps on creating a new report");
            TW.WriteLine("Step1: ");
            TW.WriteLine("Input the location baranggay/district, city/municipality, province, and country");
            TW.WriteLine("Click Search");
            TW.WriteLine("You can leave some of it blank but this may cause inaccuracies in location data");
            TW.WriteLine();
            TW.WriteLine("Step2:");
            TW.WriteLine("Using the right mouse button to move the map and scroll to zoom in and out");
            TW.WriteLine("Left click in the map the exact location where the incident or problem is located");
            TW.WriteLine();
            TW.WriteLine("Step3: ");
            TW.WriteLine("Fill up the title and description");
            TW.WriteLine("Note: Please make the title short");
            TW.WriteLine("\tMake sure to input full and complete detail");
            TW.WriteLine("\tA more detailed report may help officials act faster");
            TW.Close();
            System.Diagnostics.Process.Start(helpfileloc);
        }
        //-END-\\
    }
}
