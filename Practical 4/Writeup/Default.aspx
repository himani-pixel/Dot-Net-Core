<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CollegeAdmission.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Online College Admission System</title>
</head>
<body>
<form id="form1" runat="server">

<h2>ONLINE COLLEGE ADMISSION SYSTEM</h2>
<hr />

    <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile2.xml" />
    <br />
    <br />

Student Name :
<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
ControlToValidate="txtName" ErrorMessage="*" ForeColor="Red" />
<br /><br />

Gender :
<asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem>Male</asp:ListItem>
    <asp:ListItem>Female</asp:ListItem>
</asp:RadioButtonList>

Date of Birth :
<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

Email :
<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
<br /><br />

Mobile :
<asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
<br /><br />

Course :
<asp:DropDownList ID="ddlCourse" runat="server">
    <asp:ListItem>BSc.IT</asp:ListItem>
    <asp:ListItem>BSc.CS</asp:ListItem>
    <asp:ListItem>BCA</asp:ListItem>
</asp:DropDownList>

<br /><br />

Percentage :
<asp:TextBox ID="txtPer" runat="server"></asp:TextBox>

<br /><br />

Password :
<asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>

<br /><br />

Confirm Password :
<asp:TextBox ID="txtCPass" runat="server" TextMode="Password"></asp:TextBox>

<asp:CompareValidator
ID="CompareValidator1"
runat="server"
ControlToValidate="txtCPass"
ControlToCompare="txtPass"
ErrorMessage="Password not match"
ForeColor="Red" />

<br /><br />

<asp:CheckBox ID="CheckBox1" runat="server"
Text="Accept Terms & Conditions" />

<br /><br />

<asp:Button ID="btnRegister" runat="server"
Text="Register"
OnClick="btnRegister_Click" />

<asp:Button ID="btnReset" runat="server"
Text="Reset"
OnClick="btnReset_Click"
CausesValidation="False" />

<br /><br />

<asp:Label ID="lblResult" runat="server"></asp:Label>

</form>
</body>
</html>
