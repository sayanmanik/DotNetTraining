﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServiceConsumer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Enter ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox><br/>

            <asp:Label ID="Label2" runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox><br/>

             <asp:Label ID="Label3" runat="server" Text="Enter copies"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox><br/>

            <asp:Label ID="Label4" runat="server" Text="Enter Description"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox><br/>

            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"/>

            <asp:GridView ID="grid1" runat="server"></asp:GridView>


        </div>
        
    </form>
</body>
</html>
