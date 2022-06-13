using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void ButtonClick(object sender, EventArgs e)
    {

        ContactControl.InsertContact(
               new Contact()
               {

                  fname = fname.Text,
                  lname=lname.Text,
                  country = countrybox.Text,
                  subject = subject.Text


               });

        Response.Write("<script>alert('Your information has been received, thank you!');</script>");


    }
}