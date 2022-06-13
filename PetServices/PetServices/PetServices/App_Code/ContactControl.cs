using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactControl
/// </summary>
public class ContactControl
{
    public ContactControl()
    {
        //
        // TODO: Add constructor logic here
        //
    }



    public static void InsertContact(Contact contact)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO [Contact] (First_Name, Last_Name, Country, Subject) values (@FIRST_NAME,@LAST_NAME,@COUNTRY,@SUBJECT)", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@FIRST_NAME", contact.fname));
            command.Parameters.Add(new SqlParameter("@LAST_NAME", contact.lname));
            command.Parameters.Add(new SqlParameter("@COUNTRY", contact.country));
            command.Parameters.Add(new SqlParameter("@SUBJECT", contact.subject));
          

            command.ExecuteNonQuery();
        }
    }
}