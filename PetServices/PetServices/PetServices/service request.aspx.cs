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

    protected void ServiceRequestButton_Click(object sender, EventArgs e)
    {

        if(!Page.IsValid)
        {
            return;
        }


        int id = 0;
        string name = NameBox.Text ;
        string pet_name = PetBox.Text;
        string email = MailBox.Text;
        string phone_number = NumberBox.Text;
        string pet_type="";
        string location="";
        string zip_code = ZipBox.Text;
        string address_1 = Address1Box.Text;
        string address_2 = Address2Box.Text;
        string request="";
        int TypeIndex = PetTypeDropDown.SelectedIndex;
        int LocationIndex = LocationDropDown.SelectedIndex;



        switch (TypeIndex)
        {

            case 1:
                {
                    pet_type = "Dog";
                    break;
                }

            case 2:
                {
                    pet_type = "Cat";
                    break;
                }

            case 3:
                {
                    pet_type = "Bird";
                    break;
                }

            case 4:
                {
                    pet_type = "Horse";
                    break;
                }
        }

        switch (LocationIndex)
        {


            case 1:
                {
                    location = "Saida";
                    break;
                }

            case 2:
                {
                    location = "Beirut";
                    break;
                }


            case 3:
                {
                    location = "Zahle";
                    break;
                }

            case 4:
                {
                    location = "Baalbek";
                    break;
                }

            case 5:
                {
                    location = "Kab-Elias";
                    break;
                }
        
        }


        OrderControl.InsertOrder(
                new Order()
                {

                    id = id,
                    name = name,
                    pet_name = pet_name,
                    email = email,
                    phone_number = phone_number,
                    pet_type =  pet_type,
                    location = location,
                    zip_code = zip_code,
                    ADDRESS_1 = address_1,
                    ADDRESS_2 = address_2,
                    Request = request

                });
            ;
            string message = "Your order has been confirmed!";
        Response.Write(@"<script language='javascript'>alert('Your Order Has Been Successfully Added!')</script>");
        Response.Redirect("service request.aspx");

  

    }
}