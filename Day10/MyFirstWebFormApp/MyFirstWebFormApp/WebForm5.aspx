<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="MyFirstWebFormApp.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" AutoPostBack="true" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" AutoPostBack="true" Text="Aadhar" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged"/>


<%--        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1"  runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1"  Text="Aadhar" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged"/>--%>
        
        </div>
        
    </form>
</body>
</html>
