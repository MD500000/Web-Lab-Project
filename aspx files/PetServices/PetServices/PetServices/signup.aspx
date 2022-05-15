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
                                <input type="text" placeholder="First Name" required>
                            </div>

                            <div class="field-wrap">
                                <input type="text" placeholder="Last Name" required>
                            </div>
                        </div>

                        <div>
                            <div class="field-wrap">
                                <input type="text" placeholder="Email Address" required>
                            </div>

                            <div class="field-wrap">
                                <input type="password" placeholder="Password" required>
                            </div>

                            <div class="field-wrap">
                                <input type="password" placeholder="Repeat Password" required>
                            </div>
                            <input type="checkbox" class="checkbox" required="">
                            <font size="2">I Agree To The Terms & Conditions</font>
                        </div>
                        <button type="submit" class="button button-block">Sign Up</button>

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

