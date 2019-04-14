<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="EmailSenderApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Create User" runat="server" Font-Size="XX-Large" />
            <br />
            <br />
        </div>
        <div ><asp:Label Text="User Name:" runat="server" /> &nbsp;   <asp:TextBox runat="server" ID="txt_username" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Text="Name:" runat="server" />&nbsp;   <asp:TextBox runat="server" ID="txt_name" style="margin-bottom: 0px" />
            <br />
            <br />
        </div>
        <div >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Text="Email:" runat="server" />              &nbsp;&nbsp;   <asp:TextBox runat="server" ID="txt_email" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Text="Mobile:" runat="server" />             &nbsp;&nbsp;<asp:TextBox runat="server" ID="txt_mobile" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <br />
            <br />
        </div>
        <div >&nbsp;<asp:Label Text="Password:" runat="server" />           &nbsp;&nbsp;&nbsp;   <asp:TextBox runat="server" ID="txt_pwd" TextMode="Password" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label Text="Confirm Password:" runat="server" />   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox runat="server" ID="txt_cnf_pwd" TextMode="Password" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <br />
            <br />
        </div>
        <div >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button Text="Create User" runat="server" ID="btn_createuser" OnClick="btn_createuser_Click" />
            <br />
            <br />
        </div>
        <div >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label Text="" runat="server" ID="lblUserCreate" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
