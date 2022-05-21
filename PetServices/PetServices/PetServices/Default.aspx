<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:FormView ID="FormView1" runat="server" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                <EditItemTemplate>
                    ID:
                    <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                    <br />
                    FNAME:
                    <asp:TextBox ID="FNAMETextBox" runat="server" Text='<%# Bind("FNAME") %>' />
                    <br />
                    LNAME:
                    <asp:TextBox ID="LNAMETextBox" runat="server" Text='<%# Bind("LNAME") %>' />
                    <br />
                    EMAIL:
                    <asp:TextBox ID="EMAILTextBox" runat="server" Text='<%# Bind("EMAIL") %>' />
                    <br />
                    PASSWORD:
                    <asp:TextBox ID="PASSWORDTextBox" runat="server" Text='<%# Bind("PASSWORD") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    FNAME:
                    <asp:TextBox ID="FNAMETextBox" runat="server" Text='<%# Bind("FNAME") %>' />
                    <br />
                    LNAME:
                    <asp:TextBox ID="LNAMETextBox" runat="server" Text='<%# Bind("LNAME") %>' />
                    <br />
                    EMAIL:
                    <asp:TextBox ID="EMAILTextBox" runat="server" Text='<%# Bind("EMAIL") %>' />
                    <br />
                    PASSWORD:
                    <asp:TextBox ID="PASSWORDTextBox" runat="server" Text='<%# Bind("PASSWORD") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    ID:
                    <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                    <br />
                    FNAME:
                    <asp:Label ID="FNAMELabel" runat="server" Text='<%# Bind("FNAME") %>' />
                    <br />
                    LNAME:
                    <asp:Label ID="LNAMELabel" runat="server" Text='<%# Bind("LNAME") %>' />
                    <br />
                    EMAIL:
                    <asp:Label ID="EMAILLabel" runat="server" Text='<%# Bind("EMAIL") %>' />
                    <br />
                    PASSWORD:
                    <asp:Label ID="PASSWORDLabel" runat="server" Text='<%# Bind("PASSWORD") %>' />
                    <br />

                </ItemTemplate>
            </asp:FormView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [USER]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
