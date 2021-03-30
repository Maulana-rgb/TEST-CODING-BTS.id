<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestBTS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SHOPPING</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>SIGN IN</h1>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
        <asp:TextBox ID="EmailTB" runat="server" placeholder="Email"></asp:TextBox><br />
        <asp:TextBox ID="PassTB" runat="server" placeholder="Password"></asp:TextBox><br />
        <asp:Button ID="SignInBTN" runat="server" Text="SIGN IN" OnClick="SignInBTN_Click" />
        <asp:Button ID="SingUpBTN" runat="server" Text="SIGN UP" OnClick="SingUpBTN_Click" />
    </div>
    </form>
</body>
</html>
