<%@ Page Title="" Language="C#" MasterPageFile="~/HS.master" AutoEventWireup="true" CodeFile="Myprofile.aspx.cs" Inherits="Myprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem NavigateUrl="~/riskscreening.aspx" Text="View Details" Value="View Details"></asp:MenuItem>
            <asp:MenuItem Text="Edit Details" Value="Edit Details"></asp:MenuItem>
            <asp:MenuItem Text="Search Quote" ToolTip="It helps you to search your existing quotes" Value="Search Quote"></asp:MenuItem>
            <asp:MenuItem Text="Risk Screening" ToolTip="Proceed to Risk Screening" Value="Risk Screening" NavigateUrl="~/riskscreening.aspx"></asp:MenuItem>
        </Items>
    </asp:Menu>


    <h2>This is MyProfile page</h2>
</asp:Content>

