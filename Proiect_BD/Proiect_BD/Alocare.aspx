﻿<%@ Page Title="Alocare Hrana" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alocare.aspx.cs" Inherits="Proiect_BD.Alocare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Alocare Hrana</h2>
    
<p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" CssClass="table table-striped" ForeColor="#333333" GridLines="Both" OnRowCancelingEdit="CancelEdit" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Update">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ID_Student:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="ID_Pret:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="50px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="ID_Administrator:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="50px"></asp:TextBox>
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Counter:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Width="50px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        <br />
    </p>
    <p>
    </p>
</asp:Content>
