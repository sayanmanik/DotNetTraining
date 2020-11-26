<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JQueryDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.5.1.js"></script>
    <script>
        $(document).ready(function () {
            alert("Welcome");
           // $('p').text('Hello everyone');
            alert($('#p1').text())
            $('.p2').text("Third ")

            $('#btn1').click(function () {
                $('p').css('color','red')

            }
           )
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p></p>
            <p id="p1">Second</p>
            <p class="p2"></p>
            <input type="button" id="btn1" value="Click"/>
        </div>
    </form>
</body>
</html>
