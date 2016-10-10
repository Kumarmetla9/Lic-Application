<%@ Page Title="" Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeFile="customer.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        font-size: x-large;
        text-align: center;
    }
    .auto-style6 {
        text-align: center;
    }
    .auto-style7 {
        width: 470px;
        text-align: right;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style4">
    <tr>
        <td class="auto-style5" colspan="2" style="background-color: #FFC1FF">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
            :</td>
        <td>
            <asp:TextBox ID="txtun" runat="server" Width="180px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            :</td>
        <td>
            <asp:TextBox ID="txtpwd" runat="server" Width="180px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6" colspan="2">
            <asp:Button ID="Button1" runat="server" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="chkbx" runat="server" Text="Remember me" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
    </tr>
    <tr>
        <td class="auto-style6" colspan="2">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/forgotpassword.aspx">Forgot Password?</asp:HyperLink>
        </td>
    </tr>
</table>
</asp:Content>

