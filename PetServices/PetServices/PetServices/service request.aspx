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
                  <input type="checkbox" class="checkbox">
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/pet-sitting-icon.png" alt="" style="height: 18px;">
                    <h5>Pet Sitting</h5>
                  </div>
                </label>

                <label class="option_item">
                  <input type="checkbox" class="checkbox">
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/dog-walking-icon.png" alt="" style="height: 18px;">
                     <h5>Dog Walking</h5>
                  </div>
                </label>

                <label class="option_item">
                  <input type="checkbox" class="checkbox">
                  <div class="option_inner">
                    <div class="tickmark"></div>
                    <img src="images/overnight-pet-care-icon.png" alt="" style="height: 18px;">
                     <h5>Overnight Care</h5>
                  </div>
                </label>

                <label class="option_item">
                  <input type="checkbox" class="checkbox">
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
                <input type="text" placeholder="Your Name" required>
              </div>
          
              <div class="field-wrap">
                <input type="text" placeholder="Pet Name(s)" required>
              </div>
            </div>
  
            <div class="top-row">
              <div class="field-wrap">
                <input type="text" placeholder="Email Address" required>
              </div>
          
              <div class="field-wrap">
                <input type="text" placeholder="Phone Number" required>
              </div>
            </div>
  
            <div class="top-row">
              <div class="field-wrap">
                <select required>
                    <option selected>Pet Type</option>
                    <option value="1">Dog</option>
                    <option value="2">Cat</option>
                    <option value="3">Bird</option>
                    <option value="4">Horse</option>
                </select>
            </div>
  
            <div>
              <select>
                  <option selected>Select Location</option>
                  <option value="1">Saida</option>
                  <option value="2">Beirut</option>
                  <option value="3">Zahle</option>
                  <option value="4">Baalbek</option>
                  <option value="5">Kab-Elias</option>
              </select>
          </div>
  
            </div>
  
            <div>
                <div class="field-wrap">
                  <input type="text" placeholder="Zip Code">
                </div>
  
                <div class="field-wrap">
                  <input type="text" placeholder="Address Line 1">
                </div>
  
                <div class="field-wrap">
                  <input type="text" placeholder="Address Line 2">
                </div>
  
                <div class="field-wrap">
                  <textarea class="form-control p-4" rows="6" id="message" placeholder="Speical Requests" data-validation-required-message="Please enter your message"></textarea>
                  <p class="help-block text-danger"></p>
                  
                </div>
              </div>
            <button type="submit" class="button-rq">Start Your Service Request</button>
  
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

