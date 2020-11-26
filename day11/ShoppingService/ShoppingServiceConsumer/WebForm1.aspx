<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ShoppingServiceConsumer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Enter Id : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Enter Name :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            Enter Price :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>



            <asp:Button ID="btnAdd"  runat="server" Text="Add" OnClick="btnAdd_Click"/>
            <asp:Button ID="btnRemove" runat="server" Text="Remove" OnClick="btnRemove_Click"/>
            <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click"/>
            
            <asp:GridView ID="grid1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
