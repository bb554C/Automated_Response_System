using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COE114L_Projectv3
{
    class Reports : Identifiers
    {

        private string fileloc = "ARS_ReportsList.txt";
        private int
            index = 0, 
            reportNum = 0, reportNumDB = 0,
            points, pointsDB,
            addPoints;
        private double
            lat = 0, latDB,
            lng = 0, lngDB;
        private string 
            title = "", titleDB,
            desc = "", descDB,
            baranggay_district = "", baranggay_districtDB,
            city_municipality = "", city_municipalityDB,
            province = "", provinceDB,
            country = "", countryDB,
            solved = "", solvedDB,
            UpDownVote, UpDownVoteDB,
            addVoteName;
        private bool flag = true;
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        
        //-CONSTRUCTORS-\\
        //-START-\\
        public Reports() 
            : base()
        {

        }

        public Reports(string TITLE)
            : base()
        {
            title = TITLE;
        }

        public Reports(string TITLE, string DESC)
            : base()
        {
            title = TITLE;
            desc = DESC;
        }

        public Reports(string TITLE, string DESC, string BARANGGAY_DISTRICT)
            : base()
        {
            title = TITLE;
            desc = DESC;
            baranggay_district = BARANGGAY_DISTRICT;
        }

        public Reports(string TITLE, string DESC, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY)
            : base()
        {
            title = TITLE;
            desc = DESC;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
        }

        public Reports(string TITLE, string DESC, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE)
            : base()
        {
            title = TITLE;
            desc = DESC;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
        }

        public Reports(string TITLE, string DESC, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE, string COUNTRY)
            : base()
        {
            title = TITLE;
            desc = DESC;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
            country = COUNTRY;
        }
        //-END-\\

        //-PROPERTIES-\\
        //-START-\\
        public string prop_Title
        {
            get { return title; }
            set { title = value; }
        }

        public string prop_Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public string prop_BaranggayDistrict
        {
            get { return baranggay_district; }
            set { baranggay_district = value; }
        }

        public string prop_CityMunicipality
        {
            get { return city_municipality; }
            set { city_municipality = value; }
        }

        public string prop_Province
        {
            get { return province; }
            set { province = value; }
        }

        public string prop_Country
        {
            get { return country; }
            set { country = value; }
        }

        public string prop_Solved
        {
            get { return solved; }
            set { solved = value; }
        }
        public int prop_ReportNum
        {
            get { return reportNum; }
            set { reportNum = value; }
        }

        public int prop_Index
        {
            get { return index; }
            set { index = value; }
        }

        public int prop_Points
        {
            get { return points; }
            set { points = value; }
        }

        public double prop_Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double prop_Lng
        {
            get { return lng; }
            set { lng = value; }
        }

        public string prop_TitleDB
        {
            get { return titleDB; }
            set { titleDB = value; }
        }

        public string prop_DescDB
        {
            get { return descDB; }
            set { descDB = value; }
        }

        public string prop_BaranggayDistrictDB
        {
            get { return baranggay_districtDB; }
            set { baranggay_districtDB = value; }
        }

        public string prop_CityMunicipalityDB
        {
            get { return city_municipalityDB; }
            set { city_municipalityDB = value; }
        }

        public string prop_ProvinceDB
        {
            get { return provinceDB; }
            set { provinceDB = value; }
        }

        public string prop_CountryDB
        {
            get { return countryDB; }
            set { countryDB = value; }
        }
        
        public int prop_PointsDB
        {
            get { return pointsDB; }
            set { pointsDB = value; }
        }
        public int prop_ReportNumDB
        {
            get { return reportNumDB; }
            set { reportNumDB = value; }
        }

        public double prop_LatDB
        {
            get { return latDB; }
            set { latDB = value; }
        }

        public double prop_LngDB
        {
            get { return lngDB; }
            set { lngDB = value; }
        }

        public string prop_SolvedDB
        {
            get { return solvedDB; }
            set { solvedDB = value; }
        }

        public bool prop_Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        public string prop_UpDownVote
        {
            get { return UpDownVote; }
            set { UpDownVote = value; }
        }

        public string prop_UpDownVoteDB
        {
            get { return UpDownVoteDB; }
            set { UpDownVoteDB = value; }
        }
        
        public int prop_AddPoint
        {
            get { return addPoints; }
            set { addPoints = value; }
        }

        public string prop_addVoteName
        {
            get { return addVoteName; }
            set { addVoteName = value; }
        }
        //-END-\\

        //-PROCESS-\\
        //-START-\\
        public void FixFormat()
        {
            title = title.ToLower();
            title = textInfo.ToTitleCase(title);
            desc = desc.ToLower();
            baranggay_district = baranggay_district.ToLower();
            baranggay_district = textInfo.ToTitleCase(baranggay_district);
            city_municipality = city_municipality.ToLower();
            city_municipality = textInfo.ToTitleCase(city_municipality);
            province = province.ToLower();
            province = textInfo.ToTitleCase(province);
            country = country.ToLower();
            country = textInfo.ToTitleCase(country);
        }

        public void WriteReportsListTXT()
        {
            points = 1;
            solved = "false";
            ReadCurrentloginTXT();
            TransferIdentifierDBData();
            string[] splitter;
            StreamReader TR = new StreamReader(fileloc);
            string[] reportDBLine = File.ReadAllLines(fileloc);
            if (reportDBLine.GetLength(0) > 0)
            {
                splitter = reportDBLine[(reportDBLine.GetLength(0) - 1)].Split('|');
                reportNumDB = int.Parse(splitter[2]);
                reportNum = reportNumDB + 1;
            }
            TR.Close();
            TextWriter TW = new StreamWriter(fileloc, true);
            TW.WriteLine(solved + "|" + points.ToString() + "|" + reportNum.ToString() + "|" + title + "|" + desc + "|" + lat.ToString() + "|" + lng.ToString() + "|" + baranggay_district + "|" + city_municipality + "|" + province + "|" + country + "|" + prop_Username + "|" + prop_Username + "-");
            TW.Close();
        }

        public void ReadReportsListTXT()
        {
            ReadCurrentloginTXT();
            TransferIdentifierDBData();
            string[] splitter;
            StreamReader TR = new StreamReader(fileloc);
            string[] ReportsDBLine = File.ReadAllLines(fileloc);
            if (index < ReportsDBLine.GetLength(0))
            {
                splitter = ReportsDBLine[index].Split('|');
                solvedDB = splitter[0];
                pointsDB = int.Parse(splitter[1]);
                reportNumDB = int.Parse(splitter[2]);
                titleDB = splitter[3];
                descDB = splitter[4];
                latDB = double.Parse(splitter[5]);
                lngDB = double.Parse(splitter[6]);
                baranggay_districtDB = splitter[7];
                city_municipalityDB = splitter[8];
                provinceDB = splitter[9];
                countryDB = splitter[10];
                prop_UsernameDB = splitter[11];
                UpDownVoteDB = splitter[12];
            }
            else
            {
                flag = false;
            }
            TR.Close();
        }

        public void ReadReportsListTXTbyIndex()
        {
            string[] splitter;
            StreamReader TR = new StreamReader(fileloc);
            string[] ReportsDBLine = File.ReadAllLines(fileloc);
            splitter = ReportsDBLine[index].Split('|');
            solvedDB = splitter[0];
            pointsDB = int.Parse(splitter[1]);
            reportNumDB = int.Parse(splitter[2]);
            titleDB = splitter[3];
            descDB = splitter[4];
            latDB = double.Parse(splitter[5]);
            lngDB = double.Parse(splitter[6]);
            baranggay_districtDB = splitter[7];
            city_municipalityDB = splitter[8];
            provinceDB = splitter[9];
            countryDB = splitter[10];
            prop_UsernameDB = splitter[11];
            UpDownVoteDB = splitter[12];
            TR.Close();
        }

        public void SolvedReportsListTXT()
        {
            ReadCurrentloginTXT();
            TransferIdentifierDBData();
            TextWriter TW1 = new StreamWriter("ARS_ReportsTemp.txt",false);
            TW1.Write("");
            TW1.Close();
            index = 0;
            string[] splitter;
            StreamReader TR1 = new StreamReader(fileloc);
            string[] ReportsDBLine = File.ReadAllLines(fileloc);
            while (index < ReportsDBLine.GetLength(0))
            {
                if (index < ReportsDBLine.GetLength(0) && index != reportNum)
                {
                    splitter = ReportsDBLine[index].Split('|');
                    solvedDB = splitter[0];
                    pointsDB = int.Parse(splitter[1]);
                    reportNumDB = int.Parse(splitter[2]);
                    titleDB = splitter[3];
                    descDB = splitter[4];
                    latDB = double.Parse(splitter[5]);
                    lngDB = double.Parse(splitter[6]);
                    baranggay_districtDB = splitter[7];
                    city_municipalityDB = splitter[8];
                    provinceDB = splitter[9];
                    countryDB = splitter[10];
                    prop_UsernameDB = splitter[11];
                    UpDownVoteDB = splitter[12];
                    TextWriter TW2 = new StreamWriter("ARS_ReportsTemp.txt", true);
                    TW2.WriteLine(solvedDB + "|" + pointsDB.ToString() + "|" + reportNumDB.ToString() + "|" + titleDB + "|" + descDB + "|" + latDB.ToString() + "|" + lngDB.ToString() + "|" + baranggay_districtDB + "|" + city_municipalityDB + "|" + provinceDB + "|" + countryDB + "|" + prop_UsernameDB + "|");
                    TW2.Close();
                }
                else if (index == reportNum)
                {
                    ReadReportsListTXTbyIndex();
                    TransferReportDBData();
                    solved = "true";
                    TextWriter TW3 = new StreamWriter("ARS_ReportsTemp.txt", true);
                    TW3.WriteLine(solved + "|" + points.ToString() + "|" + reportNum.ToString() + "|" + title + "|" + desc + "|" + lat.ToString() + "|" + lng.ToString() + "|" + baranggay_district + "|" + city_municipality + "|" + province + "|" + country + "|" + prop_Username + "|");
                    TW3.Close();
                }
                index++;
            }
            TR1.Close();
            TransferFromReportsTemp();
        }

        public void PointsReportsListTXT()
        {
            TextWriter TW1 = new StreamWriter("ARS_ReportsTemp.txt", false);
            TW1.Write("");
            TW1.Close();
            index = 0;
            string[] splitter;
            StreamReader TR1 = new StreamReader(fileloc);
            string[] ReportsDBLine = File.ReadAllLines(fileloc);
            while (index < ReportsDBLine.GetLength(0))
            {
                if (index < ReportsDBLine.GetLength(0) && index != reportNum)
                {
                    splitter = ReportsDBLine[index].Split('|');
                    solvedDB = splitter[0];
                    pointsDB = int.Parse(splitter[1]);
                    reportNumDB = int.Parse(splitter[2]);
                    titleDB = splitter[3];
                    descDB = splitter[4];
                    latDB = double.Parse(splitter[5]);
                    lngDB = double.Parse(splitter[6]);
                    baranggay_districtDB = splitter[7];
                    city_municipalityDB = splitter[8];
                    provinceDB = splitter[9];
                    countryDB = splitter[10];
                    prop_UsernameDB = splitter[11];
                    UpDownVoteDB = splitter[12];
                    TextWriter TW2 = new StreamWriter("ARS_ReportsTemp.txt", true);
                    TW2.WriteLine(solvedDB + "|" + pointsDB.ToString() + "|" + reportNumDB.ToString() + "|" + titleDB + "|" + descDB + "|" + latDB.ToString() + "|" + lngDB.ToString() + "|" + baranggay_districtDB + "|" + city_municipalityDB + "|" + provinceDB + "|" + countryDB + "|" + prop_UsernameDB + "|" + UpDownVoteDB);
                    TW2.Close();
                }
                else if (index == reportNum)
                {
                    ReadReportsListTXTbyIndex();
                    TransferReportDBData();
                    points = points + addPoints;
                    UpDownVote = UpDownVoteDB + prop_addVoteName + "-";
                    TextWriter TW3 = new StreamWriter("ARS_ReportsTemp.txt", true);
                    TW3.WriteLine(solved + "|" + points.ToString() + "|" + reportNum.ToString() + "|" + title + "|" + desc + "|" + lat.ToString() + "|" + lng.ToString() + "|" + baranggay_districtDB + "|" + city_municipality + "|" + province + "|" + country + "|" + prop_UsernameDB + "|" + UpDownVote);
                    TW3.Close();
                }
                index++;
            }
            TR1.Close();
            TransferFromReportsTemp();
        }

        public void TransferFromReportsTemp()
        {
            ReadCurrentloginTXT();
            TransferIdentifierDBData();
            index = 0;
            TextWriter TW4 = new StreamWriter(fileloc, false);
            TW4.Write("");
            TW4.Close();
            string[] splitter;
            StreamReader TR2 = new StreamReader("ARS_ReportsTemp.txt");
            string[] ReportsDBLine = File.ReadAllLines("ARS_ReportsTemp.txt");
            while (index < ReportsDBLine.GetLength(0))
            {
                if (index < ReportsDBLine.GetLength(0))
                {
                    splitter = ReportsDBLine[index].Split('|');
                    solvedDB = splitter[0];
                    pointsDB = int.Parse(splitter[1]);
                    reportNumDB = int.Parse(splitter[2]);
                    titleDB = splitter[3];
                    descDB = splitter[4];
                    latDB = double.Parse(splitter[5]);
                    lngDB = double.Parse(splitter[6]);
                    baranggay_districtDB = splitter[7];
                    city_municipalityDB = splitter[8];
                    provinceDB = splitter[9];
                    countryDB = splitter[10];
                    prop_UsernameDB = splitter[11];
                    UpDownVoteDB = splitter[12];
                    TextWriter TW5 = new StreamWriter(fileloc, true);
                    TW5.WriteLine(solvedDB + "|" + pointsDB.ToString() + "|" + reportNumDB.ToString() + "|" + titleDB + "|" + descDB + "|" + latDB.ToString() + "|" + lngDB.ToString() + "|" + baranggay_districtDB + "|" + city_municipalityDB + "|" + provinceDB + "|" + countryDB + "|" + prop_UsernameDB + "|" + UpDownVoteDB);
                    TW5.Close();
                }
                index++;
            }
            TR2.Close();
            TextWriter TWlast = new StreamWriter("ARS_ReportsTemp.txt", false);
            TWlast.Write("");
            TWlast.Close();
        }
        
        public void TransferReportDBData()
        {
            solved = solvedDB;
            points = pointsDB;
            reportNum = reportNumDB;
            title = titleDB;
            desc = descDB;
            lat = latDB;
            lng = lngDB;
            baranggay_district = baranggay_districtDB;
            city_municipality = city_municipalityDB;
            province = provinceDB;
            country = countryDB;
            prop_Username = prop_UsernameDB;
            UpDownVote = UpDownVoteDB;
        }
        //-END-\\
    }
}
