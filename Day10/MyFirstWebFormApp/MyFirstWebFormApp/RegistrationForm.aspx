<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="MyFirstWebFormApp.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1" align="center">
                <tr>
                    <th colspan="2">User Registration Form</th>
                </tr>
                <tr>
                    <td>
                       Enter User Name   :
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="100">

                        </asp:TextBox>
                    </td>
                 </tr>
                <tr>
                    <td>
                        Gender :
                    </td>
                    <td align="left">
                        <asp:RadioButtonList ID="rdbGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>

                    </td>
                </tr>

                <tr>
                    <td>
                        Enter Hobbies  :
                    </td>
                    <td align="left">
                        <asp:CheckBoxList ID="chkHobbies" runat="server">
                            <asp:ListItem>Reading</asp:ListItem>
                            <asp:ListItem>Travelling</asp:ListItem>
                            <asp:ListItem>Chatting</asp:ListItem>
                            <asp:ListItem>Blogging</asp:ListItem>

                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Education Qualification:
                    </td>
                    <td>
                        <asp:DropDownList ID="dropdownlist1" runat="server">
                            <asp:ListItem Value="1">B.A</asp:ListItem>
                            <asp:ListItem Value="2">B.Com</asp:ListItem>
                            <asp:ListItem Value="3">B.E</asp:ListItem>
                            <asp:ListItem Value="4">MCA</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Enter DOB:
                    </td>
                     <td>
                         <asp:Calendar ID="calDOB" runat="server"></asp:Calendar>
                     </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit Form" OnClick="btnSubmit_Click">


                        </asp:Button>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
