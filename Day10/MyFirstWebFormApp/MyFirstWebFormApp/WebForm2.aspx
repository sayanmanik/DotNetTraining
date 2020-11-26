<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MyFirstWebFormApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h1>First Webforms</h1>
             <%--  <asp:TextBox ID="txtName" runat="server" TextMode="Password"></asp:TextBox>
              <input type="button" value="Submit" runat="server"/>--%>


            <asp:Label ID="lblmsg" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
