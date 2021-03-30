<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetAllUser.aspx.cs" Inherits="TestBTS.GetAllUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="Shopping.aspx">CREATE SHOPPING</a>
        <br />
        <h1>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="Username" />
                <asp:BoundField DataField="password" HeaderText="Password" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="phone" HeaderText="Phone" />
                <asp:BoundField DataField="country" HeaderText="Country" />
                <asp:BoundField DataField="city" HeaderText="City" />
                <asp:BoundField DataField="postcode" HeaderText="Post Code" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:BoundField DataField="address" HeaderText="Address" />             
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
