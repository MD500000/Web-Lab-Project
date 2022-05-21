using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for UserAccess
/// </summary>
public class UserAccess
{
    private static readonly string STATIC_SALT = "42nu38721g$#t21";
    public UserAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static bool IsUserExists(string email)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT 1 FROM [USER] WHERE EMAIL = @EMAIL", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@EMAIL", email));

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            return ds.Tables[0].Rows.Count == 1;
        }
    }

    public static User GetUser(string email)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT ID, FNAME, LNAME, EMAIL FROM [USER] WHERE EMAIL = @EMAIL", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@Email", email));

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            var rows = ds.Tables[0].Rows;

            if (rows.Count == 1)
            {
                var userData = rows[0];

                int dbid = (int)userData["ID"];
                string dbfname = (string)userData["FNAME"];
                string dblname = (string)userData["LNAME"];
                string dbemail = (string)userData["EMAIL"];

                return new User()
                {
                    id = dbid,
                    fname = dbfname,
                    lname = dblname,
                    email = dbemail,
                };

            }


            return null;
        }
    }

    public static User GetUser(int id)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT ID, FNAME, LNAME, EMAIL FROM [USER] WHERE ID = @ID", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@ID", id));

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            var rows = ds.Tables[0].Rows;

            if (rows.Count == 1)
            {
                var userData = rows[0];

                int dbid = (int)userData["ID"];
                string dbfname = (string)userData["FNAME"];
                string dblname = (string)userData["LNAME"];
                string dbemail = (string)userData["EMAIL"];

                return new User()
                {
                    id = dbid,
                    fname = dbfname,
                    lname = dblname,
                    email = dbemail,
                };

            }


            return null;
        }
    }

    public static DataSet ListAllUsers()
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT ID, FNAME, LNAME, EMAIL FROM [USER]", connection);
            command.CommandType = CommandType.Text;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            return ds;
        }
    }

    public static bool ValidateUserCredentials(string email, string password)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT PASSWORD FROM [USER] WHERE EMAIL = @EMAIL", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("EMAIL", email));

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            var rows = ds.Tables[0].Rows;

            if (rows.Count == 1)
            {
                string savedPassword = (string)rows[0]["PASSWORD"];
                string hashedPassword = HashPassword(email, password);

                if (savedPassword.Equals(hashedPassword))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public static void InsertUser(User user)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [USER] (FNAME, LNAME, EMAIL, PASSWORD) VALUES (@FNAME, @LNAME, @EMAIL, @PASSWORD)", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@FNAME", user.fname));
            command.Parameters.Add(new SqlParameter("@LNAME", user.lname));
            command.Parameters.Add(new SqlParameter("@EMAIL", user.email));
            command.Parameters.Add(new SqlParameter("@PASSWORD", HashPassword(user.email, user.password)));

            command.ExecuteNonQuery();
        }
    }
    public static void DeleteUser(int id)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM [USER] WHERE ID = @ID", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@ID", id));

            command.ExecuteNonQuery();
        }
    }
    private static string HashPassword(string fname, string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            string hashedPassword =
                Utils.toHex(sha256.ComputeHash(Encoding.UTF8.GetBytes(password + fname + STATIC_SALT)));
            return hashedPassword;
        }
    }
}