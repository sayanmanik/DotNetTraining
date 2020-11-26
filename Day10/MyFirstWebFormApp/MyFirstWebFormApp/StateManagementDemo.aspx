<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateManagementDemo.aspx.cs" Inherits="MyFirstWebFormApp.StateManagementDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Store Viewstore : <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btn1" runat="server" Text="Store viewstore" OnClick="btn_Click"/>
            Retrieve ViewState : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Retrieve viewstore" OnClick="Btn_Click"/>
        
            <br/>
            Store Cookie : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Store cookie" OnClick="btn1_Click"/>
            <br/>
            Retrieve Cookie : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Retrieve cookie" OnClick="Btn1_Click"/>
        

            <br/>
            <asp:Button ID="btn2" runat="server" Text="Go to page" OnClick="btn2_Click"/>
        </div>
    </form>
</body>
</html>
