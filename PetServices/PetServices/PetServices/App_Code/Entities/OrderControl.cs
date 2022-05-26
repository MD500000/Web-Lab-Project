using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderControl
/// </summary>
public class OrderControl
{
    public OrderControl()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static bool IsOrderExists(int id)
    {
        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT 1 FROM [REQUEST_SERVICE] WHERE ID = @ID", connection);
            command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@ID", id));

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);

            return ds.Tables[0].Rows.Count == 1;
        }
    }


public static void InsertOrder(Order order)
{
    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
    {
        connection.Open();

        SqlCommand command = new SqlCommand("INSERT INTO [REQUEST_SERVICE] (NAME,PET_NAME,EMAIL,PHONE_NUMBER,PET_TYPE,LOCATION,ZIP_CODE, ADDRESS_1, ADDRESS_2, REQUEST) VALUES (@NAME, @PET_NAME, @EMAIL, @PHONE_NUMBER, @PET_TYPE, @LOCATION, @ZIP_CODE, @ADDRESS_1, @ADDRESS_2, @REQUEST)", connection);
        command.CommandType = CommandType.Text;

            command.Parameters.Add(new SqlParameter("@NAME", order.name));
            command.Parameters.Add(new SqlParameter("@PET_NAME", order.pet_name));
            command.Parameters.Add(new SqlParameter("@EMAIL", order.email));
            command.Parameters.Add(new SqlParameter("@PHONE_NUMBER", order.phone_number));
            command.Parameters.Add(new SqlParameter("@PET_TYPE", order.pet_type));
            command.Parameters.Add(new SqlParameter("@Location", order.location));
            command.Parameters.Add(new SqlParameter("@ZIP_CODE", order.zip_code));
            command.Parameters.Add(new SqlParameter("@ADDRESS_1", order.ADDRESS_1));
            command.Parameters.Add(new SqlParameter("@ADDRESS_2", order.ADDRESS_2));
            command.Parameters.Add(new SqlParameter("@REQUEST", order.Request));

            command.ExecuteNonQuery();
    }
}



}