<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="TestBTS.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SHOPPING</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>SIGN UP</h1>
        <asp:TextBox ID="UsernameTB" runat="server" placeholder="Username"></asp:TextBox><br />
        <asp:TextBox ID="PassTB" runat="server" placeholder="Password"></asp:TextBox><br />
        <asp:TextBox ID="EmailTB" runat="server" placeholder="Email"></asp:TextBox><br />
        <asp:TextBox ID="PhoneTB" runat="server" placeholder="Phone"></asp:TextBox><br />
        <asp:TextBox ID="CountryTB" runat="server" placeholder="Country"></asp:TextBox><br />
        <asp:TextBox ID="CityTB" runat="server" placeholder="City"></asp:TextBox><br />
        <asp:TextBox ID="PostTB" runat="server" placeholder="Post Code"></asp:TextBox><br />
        <asp:TextBox ID="NameTB" runat="server" placeholder="Name"></asp:TextBox><br />
        <asp:TextBox ID="AddressTB" runat="server" placeholder="Address"></asp:TextBox><br />
        <asp:Button ID="SignUpBTN" runat="server" Text="SIGN UP" OnClick="SignUpBTN_Click" />
    </div>
    </form>
</body>
</html>
