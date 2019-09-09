<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="_ServerCalls.aspx.cs" Inherits="_05_SweetAlert._ServerCalls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script type="text/javascript">
        function clientMessage(message) {
                swal({   
                    title: "My Application!",
                    text:  message,
                   icon: "success",
                    button: "Ok",
                html: true 
                });
          
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
