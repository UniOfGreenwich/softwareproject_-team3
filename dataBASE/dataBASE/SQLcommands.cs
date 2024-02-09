using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.ObjectModel;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Reflection;
using dataBASE.Properties;
using System.Xml.Linq;

namespace dataBASE
{
    public class SQLcommands
    {
        #region ACCOUNT_MANAGEMENT
        String ConnectionString;

        static string currentDirectory0 = Directory.GetCurrentDirectory();

        static string currentDirectory = Directory.GetParent(currentDirectory0).FullName;

        static string path = Directory.GetParent(currentDirectory).FullName + @"\Resources\MSSQLLocalDB\Accounts.mdf";

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// Returns SQLReader for the custom query
        /// </summary>
        /// <param name="query"></param>
        /// <returns> SqlDataReader </returns>
        public SqlDataReader Select(String query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return command.ExecuteReader();
            }
        }

        public int Edit(String query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Returns table from SQL Query
        /// </summary>
        /// <param name="ladapter"></param>
        /// <returns> Data Table </returns>
        public DataTable Table(SqlDataAdapter ladapter)
        {
            DataTable dataTable = new DataTable();

            ladapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable GetHomeScreenDetails(string name, string password)
        {


            string query = "SELECT Name, Password, FullName, Role, Book_onHold, BookID1, BookID2, BookID3 FROM dbo.Account_data WHERE Name = '" + name + "' AND Password = '" + password + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                return Table(adapter);
            }
        }
        /// <summary>
        /// BLAH BLAH
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable StudentInfoTable(string name)
        {
            String query = "SELECT Name, FullName, Email, Role, PhoneNumber, Book_onHold, BookID1, BookID2, BookID3, Fees FROM dbo.Account_data WHERE Name = '" + name + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                return Table(adapter);
            }

        }

        public void UpdateStudentInfo(string fieldToUpdate, string newValue, string name)
        {

            SqlCommand command = new SqlCommand();

            if (fieldToUpdate == "Email")
            {
                command.CommandText = "UPDATE dbo.Account_data SET Email = @Email WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@Email", newValue);
            }
            else if (fieldToUpdate == "Password")
            {
                command.CommandText = "UPDATE dbo.Account_data SET Password = @Password WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@Password", newValue);
            }
            else if (fieldToUpdate == "PhoneNumber")
            {
                command.CommandText = "UPDATE dbo.Account_data SET PhoneNumber = @PhoneNumber WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@PhoneNumber", newValue);
            }
            else if (fieldToUpdate == "FullName")
            {
                command.CommandText = "UPDATE dbo.Account_data SET FullName = @FullName WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@FullName", newValue);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        #endregion ACCOUNT_INFO_END


        #region INVENTORY_MANAGEMENT

        #endregion INVENTORY_MANAGEMENT_END
    }
}

