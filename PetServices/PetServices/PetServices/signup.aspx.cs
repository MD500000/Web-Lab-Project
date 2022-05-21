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


    protected void registerButton_Click(object sender, EventArgs e)
    {

        if(!Page.IsValid)
        {
            return;
        }

        string firstname = fNameText.Text;
        string lastname = lNameText.Text;
        string emaiL = EmailText.Text;
        string passworD = PasswordText.Text;

        if(!UserAccess.IsUserExists(emaiL))
        {
            UserAccess.InsertUser(
                new User()
                {

                    fname = firstname,
                    lname = lastname,
                    password = passworD,
                    email = emaiL
                    
                });
            ;
            Response.Redirect("signup.aspx");
        
        }
    }
}