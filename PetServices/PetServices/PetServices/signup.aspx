<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!--Sign up Forum Section start-->
    <div class="flex-container">
        <div class="form">
            <div class="tab-content">
                <div id="signup">
                    <h2 id="h2-signup">Registration</h2>

                    <form action="/" method="post">

                        <div class="top-row">
                            <div class="field-wrap">
                                <asp:TextBox ID="fNameText" placeholder="First Name" required runat="server"></asp:TextBox>
                            </div>

                            <div class="field-wrap">
                                <asp:TextBox ID="lNameText" placeholder="Last Name" required runat="server"></asp:TextBox>
                            </div>
                        </div>

                        <div>
                            <div class="field-wrap">
                                <asp:TextBox ID="EmailText" placeholder="Email Address" required runat="server"></asp:TextBox>
                            </div>

                            <div class="field-wrap">
                                <asp:TextBox ID="PasswordText" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>
                            </div>

                            <div class="field-wrap">
                                <asp:TextBox ID="confirmPasswordText" TextMode="Password" placeholder="Repeat Password" runat="server"></asp:TextBox>
                            </div>
                            <input type="checkbox" class="checkbox" required="">
                            <font size="2">I Agree To The Terms & Conditions</font>
                        </div>
                        <asp:button type="submit" ID="registerButton" class="button button-block" Text="Sign-Up" OnClick="registerButton_Click" runat="server"></asp:button>
                     
                        <asp:CompareValidator ID="comparePasswordValidator" runat="server" ErrorMessage="Passwords do not match!" ControlToCompare="PasswordText" ControlToValidate="confirmPasswordText"></asp:CompareValidator>

                    </form>

                </div>


            </div>
            <!-- tab-content -->

        </div>
        <!-- /form -->
    </div>
    </div>

    <!--Sign up Forum Section end-->

</asp:Content>

