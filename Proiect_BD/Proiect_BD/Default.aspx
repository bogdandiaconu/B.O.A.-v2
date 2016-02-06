<%@ Page Title="Bine ati venit!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proiect_BD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID ="MainContent"
runat="server">
    <h1><%: Title %></h1>

    <div class="center">
    <asp:Label  Text="Organizarea Administrativa a Batalionului" ID="Label1" runat="server" CssClass="Label1"></asp:Label>
    </div>
</asp:Content>