﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Preturi.aspx.cs" Inherits="Proiect_BD.Preturi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Preturi</h2>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1"  runat="server" CellPadding="4" CssClass="table table-striped" ForeColor="#333333" Width="500px" GridLines="Both" OnRowCancelingEdit="CancelEdit" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Update">
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
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nume:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Pret:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="70px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Data:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="100px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    </p>
</asp:Content>
