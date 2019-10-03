using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COE114L_Projectv3
{
    class Identifiers
    {
        private string fileloc = "ARS_CurrentLogin.txt";

        private string
            username = "", usernameDB,
            firstName = "", firstNameDB,
            lastName = "", lastNameDB;

        //-CONSTRUCTORS-\\
        //-START-\\
        public Identifiers()
        {

        }

        public Identifiers(string USERNAME)
        {
            username = USERNAME;
        }

        public Identifiers(string USERNAME, string FIRSTNAME)
        {
            username = USERNAME;
            firstName = FIRSTNAME;
        }

        public Identifiers(string USERNAME, string FIRSTNAME, string LASTNAME)
        {
            username = USERNAME;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
        }

        public Identifiers(string USERNAME, string FIRSTNAME, string LASTNAME, string USERNAME_DB)
        {
            username = USERNAME;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
            usernameDB = USERNAME_DB;
        }

        public Identifiers(string USERNAME, string FIRSTNAME, string LASTNAME, string USERNAME_DB, string FIRSTNAME_DB)
        {
            username = USERNAME;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
            usernameDB = USERNAME_DB;
            firstNameDB = FIRSTNAME_DB;
        }

        public Identifiers(string USERNAME, string FIRSTNAME, string LASTNAME, string USERNAME_DB, string FIRSTNAME_DB, string LASTNAME_DB)
        {
            username = USERNAME;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
            usernameDB = USERNAME_DB;
            firstNameDB = FIRSTNAME_DB;
            lastNameDB = LASTNAME_DB;
        }
        //-END-\\

        //-PROPERTIES-\\
        //-START-\\
        public string prop_Username
        {
            get { return username; }
            set { username = value; }
        }

        public string prop_FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string prop_LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string prop_UsernameDB
        {
            get { return usernameDB; }
            set { usernameDB = value; }
        }

        public string prop_FirstNameDB
        {
            get { return firstNameDB; }
            set { firstNameDB = value; }
        }

        public string prop_LastNameDB
        {
            get { return lastNameDB; }
            set { lastNameDB = value; }
        }
        //-END-\\

        //-PROCESS-\\
        //-START-\\
        public void WriteCurrentLoginTXT()
        {
            TextWriter TW = new StreamWriter(fileloc, false);
            TW.WriteLine(username + "|" + firstName + "|" + lastName);
            TW.Close();
        }

        public void ReadCurrentloginTXT()
        {
            StreamReader SR = new StreamReader(fileloc);
            string[] splitter;
            string[] accDBLine = File.ReadAllLines(fileloc);
            splitter = accDBLine[0].Split('|');
            usernameDB = splitter[0];
            firstNameDB = splitter[1];
            lastNameDB = splitter[2];
            SR.Close();
        }

        public void TransferIdentifierDBData()
        {
            username = usernameDB;
            firstName = firstNameDB;
            lastName = lastNameDB;
        }
        //-END-\\
    }
}