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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        /// <summary>
        /// Edits values with the custom SQL Command
        /// </summary>
        /// <param name="query"></param>
        /// <returns> The number of rows effected </returns>
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

        /// <summary>
        /// Returns Data Table with values required for Home Screen
        /// </summary>
        /// <param name="name"></param>
        /// <param password="password"></param>
        /// <returns> Data Table </returns>
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
        /// Returns Data Table with Student Info
        /// </summary>
        /// <param name="name"></param>
        /// <returns> Data Table </returns>
        public DataTable StudentInfoTable(string name)
        {
            String query = "SELECT Name, FullName, Email, Role, PhoneNumber, Book_onHold, BookID1, BookID2, BookID3, Fees FROM dbo.Account_data WHERE Name = '" + name + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                return Table(adapter);
            }

        }

        /// <summary>
        /// Updates required data in SQL data base
        /// </summary>
        /// <param fieldToUpdate="fieldToUpdate"></param>
        /// <param name="name"></param>
        /// <param newValue ="newValue"></param>
        /// <returns></returns>
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
            else if (fieldToUpdate == "Name")
            {
                command.CommandText = "UPDATE dbo.Account_data SET Name = @Name WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@Name", newValue);
            }
            else if (fieldToUpdate == "Book_onHold")
            {
                bool newValueInt = Convert.ToBoolean(newValue);
                command.CommandText = "UPDATE dbo.Account_data SET Book_onHold = @Book_onHold WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@Book_onHold", newValue);
            }
            else if (fieldToUpdate == "BookID1")
            {
                int newValueInt = Convert.ToInt32(newValue);
                command.CommandText = "UPDATE dbo.Account_data SET BookID1 = @BookID1 WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@BookID1", newValue);
            }
            else if (fieldToUpdate == "BookID2")
            {
                int newValueInt = Convert.ToInt32(newValue);
                command.CommandText = "UPDATE dbo.Account_data SET BookID2 = @BookID2 WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@BookID2", newValue);
            }
            else if (fieldToUpdate == "BookID3")
            {
                int newValueInt = Convert.ToInt32(newValue);
                command.CommandText = "UPDATE dbo.Account_data SET BookID3 = @BookID3 WHERE Name = '" + name + "'";
                command.Parameters.AddWithValue("@BookID3", newValue);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        /// <summary>
        /// Returns Data Table with srudents books on hold and fees
        /// </summary>
        /// <param name="name"></param>
        /// <returns> Data Table </returns>
        public DataTable CheckBooksonHoldTable(string name)
        {
            SqlCommand command = new SqlCommand();

            string query = "SELECT Book_onHold, BookID1, BookID2, BookID3, Fees FROM dbo.Account_data WHERE Name = '" + name + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                return Table(adapter);
            }

        }

        /// <summary>
        /// Returns Data Table with all the students, their books on hold and fees
        /// </summary>
        /// <param name="name"></param>
        /// <returns> Data Table </returns>
        public DataTable CheckStudentsBooksonHoldTable()
        {
            SqlCommand command = new SqlCommand();

            string query = "SELECT Book_onHold, BookID1, BookID2, BookID3, Fees FROM dbo.Account_data WHERE Book_onHold = '" + true + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                return Table(adapter);
            }

        }

        /// <summary>
        /// Adds new Student to a data base
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public void AddNewStudent(string name, string fullname, string email, string phonenumber, string password)
        {
            int newId = GetNextId();
            DateTime regDate = DateTime.Today;
            bool role = false;
            bool bookOnHold = false;
            int bookId1 = 0;
            int bookId2 = 0;
            int bookId3 = 0;
            decimal fees = 0;

            string query = @"INSERT INTO dbo.Account_data (Id, Name, Password, FullName, Email, Reg_Date, Role, Book_onHold, BookID1, BookID2, BookID3, PhoneNumber, Fees) VALUES (@Id, @Name, @Password, @FullName, @Email, @RegDate, @Role, @BookOnHold, @BookID1, @BookID2, @BookID3, @PhoneNumber, @Fees)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@Id", newId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FullName", fullname);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@RegDate", regDate);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@BookOnHold", bookOnHold);
                command.Parameters.AddWithValue("@BookID1", bookId1);
                command.Parameters.AddWithValue("@BookID2", bookId2);
                command.Parameters.AddWithValue("@BookID3", bookId3);
                command.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                command.Parameters.AddWithValue("@Fees", fees);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Checks accounts main IDs and returns the next one to create new student account
        /// </summary>
        /// <returns></returns>
        private int GetNextId()
        {
            string query = "SELECT MAX(Id) FROM dbo.Account_data";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result) + 1;
                }
                else
                {
                    return 1; // If no records, start from 1
                }
            }
        }

        /// <summary>
        /// Deletes user from data base
        /// </summary>
        /// <returns></returns>
        public void DeleteUser(string name)
        {
            string query = "DELETE FROM dbo.Account_data WHERE Name = @Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }


    #endregion ACCOUNT_INFO_END


    #region INVENTORY_MANAGEMENT
    /*
 * AddNewBook function allows for the addition of a new book
 * if the book already exists in the database, the only thing that changes is the amountInLibrary value in the table
 */
    public void AddNewBook(int ISBN, int amountToAdd, string bookTitle, string authour)
    {
        //new books
        SqlCommand command = new SqlCommand();

        string query = @"INSERT INTO dbo.Books (ISBN, amountInLibrary, bookTitle, author) VALUES (@ISBN, @amountToAdd, @bookTitle, @author)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {

            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@amountToAdd", amountToAdd);
            command.Parameters.AddWithValue("@bookTitle", bookTitle);
            command.Parameters.AddWithValue("@author", authour);
            connection.Open();
            command.ExecuteNonQuery();
        }

    }

    /*
     * when student borrows a book, it should look it up book and allow add it to their account
     */
    public void BorrowBook()
    {
        //borrow
        SqlCommand command = new SqlCommand();
    }

    /*
     * the RemoveBooks function works on a similar basis to the AddNewBook function
     * the function parses the input for the ISBN, amount, title, and author so that it can match with the correct book
     * should have error handling when the book is non-existent or the amount drops to 0
     */
    public void RemoveBooks(int ISBN, int amountToRemove, string bookTitle, string authour)
    {
        //remove books from the database
        SqlCommand command = new SqlCommand();
    }
    /*
     * book search implemetation
     * need to be capable of handling the use of ISBN, author, or title
     */
    public void SearchBooks()
    {
        //search books inside the database
        SqlCommand command = new SqlCommand();
    }
    #endregion INVENTORY_MANAGEMENT_END

}