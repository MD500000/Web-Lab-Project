using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public Order()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int id { get; set; }

    public String name { get; set; }

    public String pet_name { get; set; }

    public String email { get; set; }

    public String phone_number { get; set; }


    public String pet_type { get; set; }

    public String location { get; set; }


    public String zip_code { get; set; }

    public String ADDRESS_1 { get; set; }

    public String ADDRESS_2 { get; set; }

    public String Request { get; set; }

    public String Additional_Comments { get; set; } 


}