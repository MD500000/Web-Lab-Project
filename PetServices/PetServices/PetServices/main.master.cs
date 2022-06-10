using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] != null)
        {
            RegisterButton.Visible = false;
            LoginButton.Visible = false;
        }
        string currentUrl = HttpContext.Current.Request.Url.LocalPath;
        if (currentUrl.EndsWith("service request.aspx"))
        {
            RequestServiceButton.Visible = false;
        }
    }

    protected void RequestServiceButton_Click(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        { Session.Clear(); }
        if(Session["email"]==null)
        { Response.Redirect("login.aspx"); }
        else { Response.Redirect("service request.aspx"); }
        
    }
}
