using System;
using System.Data;
using System.Globalization;
using MRIC_Peer_Review.Utilities;


namespace MRIC_Peer_Review.Processes
{
    class LogIn : DatabaseQuery
    {
        private string username;
        private string encryptedPassword;
        private int userId;

        public LogIn(int userId)
        {
            this.userId = userId;
        }

        public LogIn(string username, string password)
        {
            this.username = username;
            encryptedPassword = Encrypter.Encrypt(password);
        }

        public Boolean Authenticate()
        {
            return IsUsernameExist() && IsPasswordCorrect();
        }

        private Boolean IsUsernameExist()
        {
            string sqlQuery = "SELECT count(username) FROM  users WHERE username='" + username + "';";
            return runBooleanQuery(sqlQuery);
        }

        private Boolean IsPasswordCorrect()
        {
            string sqlQuery = "SELECT count(username) FROM  users WHERE password='" + encryptedPassword + "';";
            return runBooleanQuery(sqlQuery);
        }

        private Boolean runBooleanQuery(string sqlQuery)
        {
            int count;
            count = GetInteger(sqlQuery);
            return (count == 0) ? false : true;
        }

        public int GetUserId()
        {
            string sqlQuery = "SELECT userId FROM  users WHERE username='" + username + "';";
            return GetInteger(sqlQuery);
        }

        public String GetFullName()
        {
            string fullName;
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string sqlQuery = "SELECT CONCAT(firstname,' ', surname) AS FullName FROM  users WHERE userId=" + userId + ";";
            fullName = GetString(sqlQuery);
            return myTI.ToTitleCase(fullName);
        }

        public String GetFirstName()
        {
            string firstName;
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string sqlQuery = "SELECT firstname FROM  users WHERE userId=" + userId + ";";
            firstName = GetString(sqlQuery);
            return myTI.ToTitleCase(firstName);
        }

        public String GetSurname()
        {
            string surname;
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string sqlQuery = "SELECT surname FROM  users WHERE userId=" + userId + ";";
            surname = GetString(sqlQuery);
            return myTI.ToTitleCase(surname);
        }

        public String GetUsername()
        {
            string username;
            string sqlQuery = "SELECT username  FROM  users WHERE userId=" + userId + ";";
            username = GetString(sqlQuery);
            return (username);
        }
    }
}
