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
        if (!Page.IsPostBack)
        {   
            if (Session["email"] == null)
                Response.Redirect("login.aspx");
        }
        NameBox.Text = Session["fname"].ToString() + " " + Session["lname"].ToString();
        MailBox.Text = Session["email"].ToString();
        CB1.InputAttributes.Add("class", "checkbox");
        CB2.InputAttributes.Add("class", "checkbox");   
        CB3.InputAttributes.Add("class", "checkbox");
        CB4.InputAttributes.Add("class", "checkbox");

    }

    protected void ServiceRequestButton_Click(object sender, EventArgs e)
    {

        if(!Page.IsValid)
        {
            return;
        }
        
        string name = NameBox.Text ;
        string pet_name = PetBox.Text;
        string email = MailBox.Text;
        string phone_number = NumberBox.Text;
        string zip_code = ZipBox.Text;
        string address_1 = Address1Box.Text;
        string address_2 = Address2Box.Text;

        string pet_type= PetTypeDropDown.SelectedValue;
        string location= LocationDropDown.SelectedValue;

        string additional = Request.Form["AdditionalComments"];

        string request="";
        
        string bundle = Bundles.SelectedValue;

        if (!bundle.Equals("Select Bundle"))
        {
            request += bundle;
        }
        if(CB1.Checked == true)
        {
            request += " Pet Sitting";
        }

        if(CB2.Checked == true)
        {
            request += " Dog Walking";
        }

        if(CB3.Checked == true)
        {
            request += " Overnight Care";
        }

        if(CB4.Checked == true)
        {
            request += " Pet Taxi";
        }


        OrderControl.InsertOrder(
                new Order()
                {

                    name = name,
                    pet_name = pet_name,
                    email = email,
                    phone_number = phone_number,
                    pet_type =  pet_type,
                    location = location,
                    zip_code = zip_code,
                    ADDRESS_1 = address_1,
                    ADDRESS_2 = address_2,
                    Request = request,
                    Additional_Comments = additional
                   

                });

        Response.Write("<script>alert('Your Order Has Been Confirmed');</script>");

  

    }
}