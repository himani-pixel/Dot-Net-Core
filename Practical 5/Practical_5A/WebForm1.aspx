<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical_5C.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ViewState and Cookies</title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server"></asp:Label>

        <br /><br />

        <asp:Button ID="Button1" runat="server"
            Text="View State"
            OnClick="Button1_Click" />

        <br /><br />

        Enter Name :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <br /><br />

        <asp:Button ID="Button2" runat="server"
            Text="Cookies"
            OnClick="Button2_Click" />

    </form>
</body>
</html>
