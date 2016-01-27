<%@ Page Title="Wilcommin!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proiect_BD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID ="MainContent"
runat="server">
    <h1><%: Title %></h1>
    <h2>Organizarea Administrativa a Batalionului.</h2>
    <p class="lead"> Pentru ca ne place! </p>
<p class="lead"> &nbsp;</p>
<p class="lead"> &nbsp;</p>
<p class="lead"> 
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p class="lead"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" Width="142px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
<p class="lead">  
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </p>
<p class="lead"> 
    &nbsp;</p>
<p class="lead"> &nbsp;</p>
<p class="lead"> &nbsp;</p>
<p class="lead"> &nbsp;</p> 
</asp:Content>