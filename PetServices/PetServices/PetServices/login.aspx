<%@ Page Title="Login" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!--Sign up Forum Section start-->
    <div class="flex-container">
        <div class="form">
            <div class="tab-content">
                <div id="signup">
                    <h2 id="h2-signup">Login</h2>

                        <div>
                            <div class="field-wrap">
                                <asp:TextBox ID="emailText" placeholder="Email Address" required="" runat="server" ></asp:TextBox>
                            </div>

                            <div class="field-wrap">
                                <asp:TextBox ID="passwordText" placeholder="Password" required="" TextMode="Password" runat="server"></asp:TextBox>
                            </div>
                            <input type="checkbox" class="checkbox">
                            <font size="2">Remember Me</font>
                        </div>
                        <asp:button type="submit" ID="loginsubmitButton" CssClass="button-rq" Text="Login" runat="server" OnClick="loginsubmitButton_Click"></asp:button>
                        <asp:Label ID="loginValidationLabel" runat="server" Visible="false" ForeColor="Red" />
                    
                </div>

            </div>
            <!-- tab-content -->

        </div>
        <!-- /form -->
    </div>

    <!--Sign up Forum Section end-->

</asp:Content>
