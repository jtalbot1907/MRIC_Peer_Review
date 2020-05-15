using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace MRIC_Peer_Review
{
    class DatabaseQuery
    {
        //Instance Variable
        protected MySqlConnection connection;
        protected MySqlDataAdapter ad;
        protected DataTable dt;
        protected MySqlCommand cmd;

        public DatabaseQuery()
        {
            string connectionString = "Server = localhost; Port = 3306; Database = mric_db; Uid = root; Pwd = root;";
            connection = new MySqlConnection(connectionString);
        }

        public DataTable Read(string SqlQuery)
        {
            dt = new DataTable();
            ad = new MySqlDataAdapter(SqlQuery, connection);
            new MySqlCommandBuilder(ad);
            connection.Open();
            ad.Fill(dt);
            connection.Close();
            return dt;
        }

        public void Create(string SqlQuery)
        {
            cmd = new MySqlCommand(SqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(string SqlQuery)
        {
            cmd = new MySqlCommand(SqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        protected int GetInteger(string sqlQuery)
        {
            Int32 returnValue;
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            returnValue = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return returnValue;
        }

        protected string GetString(string sqlQuery)
        {
            string returnValue;
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            returnValue = cmd.ExecuteScalar().ToString();
            connection.Close();
            return returnValue;
        }

    }
}