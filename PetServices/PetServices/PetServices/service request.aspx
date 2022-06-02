<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="service request.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!--Request Forum Section start-->
    <section class="section">
        <div class="section__item section__item--start">
            <div class="tab-content">
          <div id="signup">   
            
            <font size="6">Request Service</font><br><br>
            <p>Please select any services you’re interested in and fill out the form. 
              We’ll help create your account on Pets United.</p><br>



              <!-- services start -->

              <div class="service">
                <label class="option_item">
                    <asp:CheckBox ID="CB1" runat="server" />
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/pet-sitting-icon.png" alt="" style="height: 18px;">
                    <h5>Pet Sitting</h5>
                  </div>
                </label>

                <label class="option_item">
                    <asp:CheckBox ID="CB2" runat="server" />
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/dog-walking-icon.png" alt="" style="height: 18px;">
                     <h5>Dog Walking</h5>
                  </div>
                </label>

                <label class="option_item">
                    <asp:CheckBox ID="CB3" runat="server" />
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/overnight-pet-care-icon.png" alt="" style="height: 18px;">
                     <h5>Overnight Care</h5>
                  </div>
                </label>
                <label class="option_item">
                    <asp:CheckBox ID="CB4" runat="server" />
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/pet-transport-icon.png" alt="" style="height: 18px;">
                     <h5>Pet Taxi</h5>
                  </div>
                </label>

              </div>

              <!-- services end -->
            
            <form action="/" method="post">
            
            <div class="top-row">
              <div class="field-wrap">
                  <asp:TextBox ID="NameBox" runat="server" placeholder="Your Name"></asp:TextBox>
              </div>
          
              <div class="field-wrap">
                  <asp:TextBox ID="PetBox" runat="server" placeholder="Pet Name(s)"></asp:TextBox>
              </div>
            </div>
  
            <div class="top-row">
              <div class="field-wrap">
                  <asp:TextBox ID="MailBox" runat="server" placeholder="Email Address"></asp:TextBox>
              </div>
          
              <div class="field-wrap">
                  <asp:TextBox ID="NumberBox" runat="server" placeholder="Phone Number"></asp:TextBox>
              </div>
            </div>
  
            <div class="top-row">
              <div class="field-wrap">
                  <asp:DropDownList ID="PetTypeDropDown" runat="server">
                     <asp:ListItem Value="">Select Pet Type  </asp:ListItem>
                      <asp:ListItem>Dog</asp:ListItem>
                      <asp:ListItem>Cat</asp:ListItem>
                      <asp:ListItem>Bird</asp:ListItem>
                      <asp:ListItem>Horse</asp:ListItem>
                  </asp:DropDownList>
            </div>
  
            <div>
               <asp:DropDownList ID="LocationDropDown" runat="server">
                     <asp:ListItem Value="">Select Location </asp:ListItem>
                      <asp:ListItem>Saida</asp:ListItem>
                      <asp:ListItem>Beirut</asp:ListItem>
                      <asp:ListItem>Zahle</asp:ListItem>
                      <asp:ListItem>Baalbek</asp:ListItem>
                      <asp:ListItem>Kab-Elias</asp:ListItem>
                  </asp:DropDownList>
          </div>
  
            </div>
  
            <div>
                <div class="field-wrap">
                    <asp:TextBox ID="ZipBox"  runat="server" placeholder="Zip Code"></asp:TextBox>
                </div>
  
                <div class="field-wrap">
                    <asp:TextBox ID="Address1Box" runat="server" placeholder="Address Line 1"></asp:TextBox>
                </div>
  
                <div class="field-wrap">
                    <asp:TextBox ID="Address2Box" runat="server" placeholder="Address Line 2"></asp:TextBox>
                </div>
  
                <div class="field-wrap">
                  <textarea class="form-control p-4" rows="6" id="message" placeholder="Speical Requests" data-validation-required-message="Please enter your message" name="AdditionalComments"></textarea>
                  <p class="help-block text-danger"></p>
                  
                </div>
              </div>
                <asp:Button ID="ServiceRequestButton" runat="server" Text="Start Your Service Request" CssClass="button-rq" OnClick="ServiceRequestButton_Click"/>
          </div>
          
          
            </div><!-- tab-content -->
        
        </div>
    
        <div class="section__item section__item--end">
          <font size="6">Already a Customer?</font>
  
          <button type="submit" class="button-rq">Log In and Schedule Service</button>
        </div>
      </section>
  
      <!--Request Forum Section end-->


</asp:Content>

