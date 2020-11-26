<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBinding.aspx.cs" Inherits="MyFirstWebFormApp.DataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server"></asp:Label></br>
            <asp:DropDownList ID="nameDropDown" runat="server" AutoPostBack="true"></asp:DropDownList>
            <asp:GridView ID="empGridView" runat="server"></asp:GridView>
            <asp:Button ID="btnLoad" Text="Load" runat="server" OnClick="btnLoad_Click"></asp:Button>
        
        </div>
    </form>
</body>
</html>
