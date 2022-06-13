<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div class="container">
        

            <label for="fname">First Name</label>
            <asp:TextBox id="fname" name="firstname" placeholder="Your name.." runat="server"/>

            <label for="lname">Last Name</label>
            <asp:TextBox id="lname" name="lastname" placeholder="Your last name.." runat="server"/>

            <label for="countrybox">Country</label>
            <asp:TextBox id="countrybox" name="country" placeholder="Your country.." runat="server" />

            <label for="subject">Subject</label>
            <asp:TextBox id="subject" name="subject" placeholder="What's on your mind?" style="height:200px" textmode="MultiLine" runat="server"></asp:TextBox>

            <asp:Button ID="submitButton" text="Submit"  runat="server" onclick="ButtonClick" CssClass="button-rq"/>

    </div>

</asp:Content>

