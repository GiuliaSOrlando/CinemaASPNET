<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AcquistoBiglietto.aspx.cs" Inherits="CinemaASPNET.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="nome" runat="server" placeholder="Inserisci il tuo nome"></asp:TextBox>
    <asp:TextBox ID="cognome" runat="server" placeholder="Inserisci il tuo cognome" />
    <asp:DropDownList ID="ddlRoom" runat="server">
        <asp:ListItem Text="SALA NORD" Value="Sala Nord" />
        <asp:ListItem Text="SALA EST" Value="Sala Est" />
        <asp:ListItem Text="SALA SUD" Value="Sala Sud" />
    </asp:DropDownList>
    <asp:RadioButtonList ID="rblTicketType" runat="server">
        <asp:ListItem Text="Intero" Value="Intero" />
        <asp:ListItem Text="Ridotto" Value="Ridotto" />
    </asp:RadioButtonList>
    <asp:Button ID="AcquistoBigliettoButton" runat="server" Text="Prenota Biglietto" OnClick="AcquistoBigliettoButton_Click" />

</asp:Content>
