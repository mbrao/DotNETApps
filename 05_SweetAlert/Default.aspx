<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_05_SweetAlert.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script type="text/javascript">
        function f1() {
            swal({
            title: "Good job!",
            text: "You clicked the button!",
            icon: "success",
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" id="btnCLick" value="Click Me" onclick="f1()" />
            
        </div>
    </form>
</body>
</html>
