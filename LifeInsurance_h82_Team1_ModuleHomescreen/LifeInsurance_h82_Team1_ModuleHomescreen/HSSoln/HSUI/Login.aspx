<%@ Page Title="" Language="C#" MasterPageFile="~/HS.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
&nbsp;<table class="auto-style4">
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label1" runat="server" style="text-align: right" Text="UserName"></asp:Label>
                :</td>
            <td>
                <asp:TextBox ID="txtun" runat="server" Width="210px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="208px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClientClick="JavaScript:valid1();" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
</asp:Content>

