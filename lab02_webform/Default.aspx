<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab02_webform._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:TextBox ID="TextBoxWartosc1" runat="server"></asp:TextBox>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>+</asp:ListItem>
        <asp:ListItem>-</asp:ListItem>
        <asp:ListItem>*</asp:ListItem>
        <asp:ListItem>/</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="TextBoxWartosc2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="=" OnClick="Button1_Click" />
    <asp:TextBox ID="TextBoxWynik" runat="server"></asp:TextBox>
</asp:Content>
