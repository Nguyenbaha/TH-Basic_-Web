<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="Bai10.Bai10" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        form {
            width: max-content;
            border: 1px solid black;
            margin: auto;
            padding: 10px 20px 20px 20px;
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background: lightcyan;
        }
    </style>
    <script>

        var noidung, file;
        function checkForm() {
            noidung = document.getElementById("txtNoiDung");
            file = document.getElementById("Folder");
            if (noidung.value === "")
            {
                alert('Bạn chưa nhập nội dung');
                return false;
            }
            if (file.value === "") {
                alert('Bạn chưa chọn file');
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    
    <form id="form" method="post" runat="server" onsubmit="return checkForm();" >
        
        <div>
            <textarea id="txtNoiDung" name="txtNoiDung" cols="45" rows="5"></textarea>
            <br />
            
            <br />
            <input id="Folder" type="file" runat="server"/>
            <br />
            <div id="tcon" runat="server"></div>
            <br />
            <input id="Submit1" type="submit" value="submit" />
        </div>
        <div>
            <div id="sucess" runat="server" style="margin-top:5px;color:red">
        </div>
    </form>
    
    
</body>
</html>

