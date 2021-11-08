<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly.aspx.cs" Inherits="Tuan6.Xuly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       table, th, td {
    border: 2px solid black;
    margin:auto;
    background: lightcyan;
}
    </style>
</head>
<body>
    
    <asp:Table ID="Table1" runat="server" >
<asp:TableRow>
     <asp:TableCell>STT</asp:TableCell>
    <asp:TableCell>Họ và tên</asp:TableCell>
     <asp:TableCell>Giới tính</asp:TableCell>
     <asp:TableCell>Ngày sinh</asp:TableCell>
     <asp:TableCell>Email</asp:TableCell>
     <asp:TableCell>Số điện thoại</asp:TableCell>
     <asp:TableCell>Địa chỉ</asp:TableCell>
</asp:TableRow>

    </asp:Table>

  
</body>
</html>
