using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COE114L_Projectv3
{
    public partial class ViewReportForm : Form
    {
        Reports R = new Reports();
        Account A = new Account();

        public ViewReportForm()
        {
            InitializeComponent();
            R.ReadCurrentloginTXT();
            R.TransferIdentifierDBData();
            A.ReadCurrentloginTXT();
            A.TransferIdentifierDBData();
            A.ReadAccountsTXT();
            A.TransferAccountsDBData();
            if(A.prop_PermissionLevelDB >= 2)
            {
                buttonResolve.Visible = true;
            }
            LoadListView();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = false;
            LoadListView();
        }
        
        private void LoadListView()
        {
            listViewReports.Clear();
            gmap.Visible = false;
            groupBoxDetails.Visible = false;
            listViewReports.View = View.Details;
            listViewReports.GridLines = true;
            listViewReports.FullRowSelect = true;
            R.prop_Index = 0;
            R.prop_Flag = true;
            listViewReports.Columns.Add("Points", 50);
            listViewReports.Columns.Add("Report#", 60);
            listViewReports.Columns.Add("Title", 150);
            listViewReports.Columns.Add("City/Municipality", 100);
            listViewReports.Columns.Add("Province", 100);
            listViewReports.Columns.Add("Country", 100);
            listViewReports.Columns.Add("Reported by", 100);
            string[] arr = new string[7];
            while (R.prop_Flag)
            {
                R.ReadReportsListTXT();
                if(R.prop_SolvedDB == "false")
                {
                    arr[0] = R.prop_PointsDB.ToString();
                    arr[1] = R.prop_ReportNumDB.ToString();
                    arr[2] = R.prop_TitleDB;
                    arr[3] = R.prop_CityMunicipalityDB;
                    arr[4] = R.prop_ProvinceDB;
                    arr[5] = R.prop_CountryDB;
                    arr[6] = R.prop_UsernameDB;
                    ListViewItem item = new ListViewItem(arr);
                    listViewReports.Items.Add(item);
                }
                R.prop_Index++;
            }
            if(R.prop_SolvedDB == "false")
            listViewReports.Items[listViewReports.Items.Count-1].Remove();
        }

        private void listViewReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            int index = listViewReports.FocusedItem.Index;
            R.prop_Index = int.Parse(listViewReports.Items[index].SubItems[1].Text);
            R.ReadReportsListTXTbyIndex();
            labelTitle.Text = listViewReports.Items[index].SubItems[2].Text;
            labelReportNum.Text = listViewReports.Items[index].SubItems[1].Text;
            labelPoints.Text = "Points: " + listViewReports.Items[index].SubItems[0].Text;
            labelAdress.Text = listViewReports.Items[index].SubItems[3].Text + ", " + listViewReports.Items[index].SubItems[4].Text + ", " + listViewReports.Items[index].SubItems[5].Text;
            labelLat.Text = "Latitude: " + R.prop_LatDB.ToString();
            labelLng.Text = "Longitude: " + R.prop_LngDB.ToString();
            labelDesc.Text = R.prop_DescDB;
            labelReportedBy.Text = "Reported By: " + R.prop_UsernameDB;
            gmap.Visible = true;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(R.prop_LatDB, R.prop_LngDB);
            gmap.Zoom = 17;
        }


        private void buttonResolve_Click(object sender, EventArgs e)
        {
            R.prop_ReportNum = int.Parse(labelReportNum.Text);
            R.SolvedReportsListTXT();
            LoadListView();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm HF = new HomeForm();
            HF.Closed += (s, args) => this.Close();
            HF.Show();
        }

        private void buttonUpDownVote_Click(object sender, EventArgs e)
        {
            A.ReadCurrentloginTXT();
            R.ReadReportsListTXTbyIndex();
            R.prop_ReportNum = int.Parse(labelReportNum.Text);
            R.prop_AddPoint = 1;
            R.prop_addVoteName = A.prop_UsernameDB;
            bool x;
            x = R.prop_UpDownVoteDB.Contains(A.prop_UsernameDB);
            if(x)
            {
                MessageBox.Show("You have already voted for this report", "Vote Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                R.PointsReportsListTXT();
            }
            LoadListView();
        }

        private void buttonDownVote_Click(object sender, EventArgs e)
        {
            A.ReadCurrentloginTXT();
            R.ReadReportsListTXTbyIndex();
            R.prop_ReportNum = int.Parse(labelReportNum.Text);
            R.prop_AddPoint = -1;
            R.prop_addVoteName = A.prop_UsernameDB;
            bool x;
            x = R.prop_UpDownVoteDB.Contains(A.prop_UsernameDB);
            if (x)
            {
                MessageBox.Show("You have already voted for this report", "Vote Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                R.PointsReportsListTXT();
            }
            LoadListView();
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string helpfileloc = "ARS_Help.txt";
            TextWriter TW = new StreamWriter(helpfileloc, false);
            TW.WriteLine("View Report Help");
            TW.WriteLine();
            TW.WriteLine("Click on the report in the list view to view all the details of the report");
            TW.WriteLine();
            TW.WriteLine("A user can only upvote and downvote a report once");
            TW.WriteLine();
            TW.WriteLine("Only a user with a permission level greater than 2 can resolve a report");
            TW.WriteLine("Resolved reports will no longer be actively displayed in the list view)");
            TW.WriteLine("Resolved reports will remain saved in the data files");
            TW.Close();
            System.Diagnostics.Process.Start(helpfileloc);
        }

        
    }
}
