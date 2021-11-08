<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web12.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="width:400px" onsubmit="return check();">
        <fieldset>   
             <div>
        <label style="margin-right:7px">Tên đăng nhập</label><input type="text" id="user" name="user"/>
        <br />
        <br />
        <label style="margin-right:72px">Màu</label><input type="color" id="color" name="color"/>
        
        <div style="margin-top:15px">
            <input type="submit" value="Đăng nhập"/>
            <input type="reset"value="Đặt lại"/>
        </div>
    </div>
        </fieldset>

        
    </form>
    <script>
        function check()
        {
            
            if (document.getElementById("user").value === "")
            {
                document.getElementById("user").focus();
                return false;
            }
            return true;
        }
    </script>
</body>
</html>
