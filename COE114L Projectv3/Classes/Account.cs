using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COE114L_Projectv3
{
    class Account : Identifiers
    {
        private string fileloc = "ARS_Accounts.txt";
        private string
            password = "", passwordDB,
            email = "", emailDB,
            confirmEmail = "",
            gender = "", genderDB,
            line1 = "", line1DB,
            line2 = "", line2DB,
            baranggay_district = "", baranggay_districtDB,
            city_municipality = "", city_municipalityDB,
            province = "", provinceDB,
            country = "", countryDB;

        private int index = 0, permissionLevel = 1, permissionLevelDB;

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        //-CONSTRUCTORS-\\
        //-START-\\
        public Account() : 
            base ( )
        {

        }

        public Account(string USERNAME) 
            :base (USERNAME)
        {

        }

        public Account(string USERNAME, string PASSWORD)
            : base(USERNAME)
        {
            password = PASSWORD;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL)
            : base(USERNAME)
        {
            password = PASSWORD;
            email = EMAIL;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME)
            : base(USERNAME, FIRSTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE, string COUNTRY)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
            country = COUNTRY;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE, string COUNTRY, int PERMISSION_LEVEL)
            : base(USERNAME, FIRSTNAME, LASTNAME)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
            country = COUNTRY;
            permissionLevel = PERMISSION_LEVEL;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE, string COUNTRY, int PERMISSION_LEVEL, string USERNAME_DB)
            : base(USERNAME, FIRSTNAME, LASTNAME, USERNAME_DB)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
            country = COUNTRY;
            permissionLevel = PERMISSION_LEVEL;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE, string COUNTRY, int PERMISSION_LEVEL, string USERNAME_DB, string FIRSTNAME_DB)
            : base(USERNAME, FIRSTNAME, LASTNAME, USERNAME_DB, FIRSTNAME_DB)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
            country = COUNTRY;
            permissionLevel = PERMISSION_LEVEL;
        }

        public Account(string USERNAME, string PASSWORD, string EMAIL, string FIRSTNAME, string LASTNAME, string GENDER, string LINE1, string LINE2, string BARANGGAY_DISTRICT, string CITY_MUNICIPALITY, string PROVINCE, string COUNTRY, int PERMISSION_LEVEL, string USERNAME_DB, string FIRSTNAME_DB, string LASTNAME_DB)
            : base(USERNAME, FIRSTNAME, LASTNAME, USERNAME_DB, FIRSTNAME_DB, LASTNAME_DB)
        {
            password = PASSWORD;
            email = EMAIL;
            gender = GENDER;
            line1 = LINE1;
            line2 = LINE2;
            baranggay_district = BARANGGAY_DISTRICT;
            city_municipality = CITY_MUNICIPALITY;
            province = PROVINCE;
            country = COUNTRY;
            permissionLevel = PERMISSION_LEVEL;
        }
        //-END-\\

        //-PROPERTIES-\\
        //-START-\\
        public string prop_Password
        {
            get { return password; }
            set { password = value; }
        }

        public string prop_Email
        {
            get { return email; }
            set { email = value; }
        }

        public string prop_ConfirmEmail
        {
            get { return confirmEmail; }
            set { confirmEmail = value; }
        }

        public string prop_Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        public string prop_Line1
        {
            get { return line1; }
            set { line1 = value; }
        }
        
        public string prop_Line2
        {
            get { return line2; }
            set { line2 = value; }
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

        public int prop_Index
        {
            get { return index; }
            set { index = value; }
        }

        public int prop_PermissionLevel
        {
            get { return permissionLevel; }
            set { permissionLevel = value; }
        }

        public string prop_PasswordDB
        {
            get { return passwordDB; }
            set { passwordDB = value; }
        }

        public string prop_EmailDB
        {
            get { return emailDB; }
            set { emailDB = value; }
        }

        public string prop_GenderDB
        {
            get { return genderDB; }
            set { genderDB = value; }
        }

        public string prop_Line1DB
        {
            get { return line1DB; }
            set { line1DB = value; }
        }

        public string prop_Line2DB
        {
            get { return line2DB; }
            set { line2DB = value; }
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

        public int prop_PermissionLevelDB
        {
            get { return permissionLevelDB; }
            set { permissionLevelDB = value; }
        }
        //-END-\\

        //-PROCESS-\\
        //-START-\\
        public void FixFormat()
        {
            prop_FirstName = prop_FirstName.ToLower();
            prop_FirstName = textInfo.ToTitleCase(prop_FirstName);
            prop_LastName = prop_LastName.ToLower();
            prop_LastName = textInfo.ToTitleCase(prop_LastName);
            email = email.ToLower();
            confirmEmail = confirmEmail.ToLower();
            prop_Username = prop_Username.ToLower();
            line1 = line1.ToLower();
            line1 = textInfo.ToTitleCase(line1);
            line2 = line2.ToLower();
            line2 = textInfo.ToTitleCase(line2);
            baranggay_district = baranggay_district.ToLower();
            baranggay_district = textInfo.ToTitleCase(baranggay_district);
            city_municipality = city_municipality.ToLower();
            city_municipality = textInfo.ToTitleCase(city_municipality);
            province = province.ToLower();
            province = textInfo.ToTitleCase(province);
            country = country.ToLower();
            country = textInfo.ToTitleCase(country);
        }

        public void WriteAccountsTXT()
        {
            TextWriter TW = new StreamWriter(fileloc, true);
            TW.WriteLine(prop_Username + "|" + password + "|" + email + "|" + prop_FirstName + "|" + prop_LastName + "|" + gender + "|" + line1 + "|" + line2 + "|" + baranggay_district + "|" + city_municipality + "|" + province + "|" + country + "|" + permissionLevel.ToString());
            TW.Close();
        }


        public void ReadAccountsTXT()
        {
            string[] splitter;
            StreamReader TR = new StreamReader(fileloc);
            int index = 0;
            string[] accDBLine = File.ReadAllLines(fileloc);
            while (prop_Username != prop_UsernameDB && accDBLine.Length != 0 && index < accDBLine.GetLength(0))
            {
                splitter = accDBLine[index].Split('|');
                prop_UsernameDB = splitter[0];
                passwordDB = splitter[1];
                emailDB = splitter[2];
                prop_FirstNameDB = splitter[3];
                prop_LastNameDB = splitter[4];
                genderDB = splitter[5];
                line1DB = splitter[6];
                line2DB = splitter[7];
                baranggay_districtDB = splitter[8];
                city_municipalityDB = splitter[9];
                provinceDB = splitter[10];
                countryDB = splitter[11];
                permissionLevelDB = int.Parse(splitter[12]);
                index++;
            }
            TR.Close();
        }

        public void TransferAccountsDBData()
        {
            prop_Username = prop_UsernameDB;
            prop_UsernameDB = "";
            password = passwordDB;
            passwordDB = "";
            email = emailDB;
            emailDB = "";
            prop_FirstName = prop_FirstNameDB;
            prop_FirstNameDB = "";
            prop_LastName = prop_LastNameDB;
            prop_LastNameDB = "";
            gender = genderDB;
            genderDB = "";
            line1 = line1DB;
            line1DB = "";
            line2 = line2DB;
            line2DB = "";
            baranggay_district = baranggay_districtDB;
            baranggay_districtDB = "";
            city_municipality = city_municipalityDB;
            city_municipalityDB = "";
            province = provinceDB;
            provinceDB = "";
            country = countryDB;
            countryDB = "";
            permissionLevel = permissionLevelDB;
        }

        //-END-\\
    }
}