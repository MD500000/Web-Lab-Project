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



        bool PetSitting = (Request.Form["CB1"] == "on") ? true : false;
        bool PetWalking = (Request.Form["CB2"] == "on") ? true : false;
        bool PetOvernight = (Request.Form["CB3"] == "on") ? true : false;
        bool PetTransport = (Request.Form["CB4"] == "on") ? true: false;


        if(PetSitting == true)
        {
            request = "Pet Sitting";
        }

        if(PetWalking == true)
        {
            request = "Dog Walking";
        }

        if(PetOvernight == true)
        {
            request = "Overnight Care";
        }

        if(PetTransport == true)
        {
            request = "Pet transport";
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
                    Request = request

                });
            ;
            string message = "Your order has been confirmed!";
        Response.Write(message);
        Response.Redirect("service request.aspx");

  

    }
}