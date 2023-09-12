<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CinemaASPNET.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="usernameInput" runat="server" placeholder="Scrivi il tuo username"></asp:TextBox>
    <asp:TextBox ID="passwordInput" runat="server" placeholder="Scrivi la tua password"></asp:TextBox>
    <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />

</asp:Content>
