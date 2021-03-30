<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shopping.aspx.cs" Inherits="TestBTS.Shopping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="GetAllUser.aspx">HOME</a><br />
        <h1>CREATE SHOPPING</h1>        
        <asp:TextBox ID="NameTB" runat="server" placeholder="CREATE SHOPPING"></asp:TextBox>
        <asp:Button ID="CreateBTN" runat="server" Text="CREATE" OnClick="CreateBTN_Click" />
        <br /><br />
        <asp:TextBox ID="SearchNameTB" runat="server" placeholder="Masukkan ID SHOPPING"></asp:TextBox><asp:Button ID="SearchBTN" runat="server" Text="SEARCH" OnClick="SearchBTN_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="name" HeaderText="SHOPPING NAME" />
                <asp:BoundField DataField="createdate" HeaderText="CREATE SHOPPING" />          
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
