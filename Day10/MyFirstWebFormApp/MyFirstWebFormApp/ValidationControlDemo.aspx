<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationControlDemo.aspx.cs" Inherits="MyFirstWebFormApp.ValidationControlDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function validate(src, args) {
            var pwd = document.getElementById("txtPwd").value;
            if (pwd.length >= 6) {
                  args.IsValid == true
            } else {
                  args.IsValid == false
            }
        }


    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Enter UserName: <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></br>
            <asp:RequiredFieldValidator ID="valName" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="Name is mandatory"><span style="color:red">*</span></asp:RequiredFieldValidator></br>
           
            Enter Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br/>
            <asp:RegularExpressionValidator ID="valEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email should be in correct format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br>
            
            Enter DOB: <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox><br/>
            <asp:CompareValidator ID="valDOB" runat="server" ControlToValidate="txtDOB" ErrorMessage="Birth Date should be proper date value" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator></br>
            
            Enter Password: <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox><br/>
            <asp:CustomValidator ID="valPwd" runat="server" controlToValidate="txtPwd" ErrorMessage="password length should be minimum 6 characters" ClientValidateFunction="validate"></asp:CustomValidator></br>            
            <asp:Button ID="btn1" runat="server" Text="Submit"/></br>
        
            Enter Age: <asp:TextBox ID="txtAge" runat="server"/></br>
            <asp:RangeValidator ID="valAge" runat="server" ControlToValidate="txtAge" ErrorMessage="Age is invalid" MinimumValue="1" MaximumValue="100" Type="Integer"></asp:RangeValidator></br>
            Enter Mobile: <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></br>
            <asp:RegularExpressionValidator ID="val2" runat="server" ValidationExpression="[0-9]{10}" ControlToValidate="txtMobile" ErrorMessage="Mobile Number is incorrect"></asp:RegularExpressionValidator></br>
            
            <asp:ValidationSummary ID="valSum" runat="server" showSummary="true" DisplayMode="List"/></br>
        </div>
    </form>
</body>
</html>
