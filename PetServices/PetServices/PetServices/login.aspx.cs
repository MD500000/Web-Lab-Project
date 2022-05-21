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

    protected void loginsubmitButton_Click(object sender, EventArgs e)
    {
        Session.Clear();


        if(UserAccess.ValidateUserCredentials(emailText.Text, passwordText.Text))
        {

            User user = UserAccess.GetUser(emailText.Text);

            if (user != null)
            {
                Session["email"] = user.email;
                Session["fname"] = user.fname;
                Session["lname"] = user.lname;

                Response.Redirect("services.aspx");
            }

        }

        else
        {
            loginValidationLabel.Text = "Bad Credentials!";
            loginValidationLabel.Visible = true;

        }

        passwordText.Text = null;
    }
}