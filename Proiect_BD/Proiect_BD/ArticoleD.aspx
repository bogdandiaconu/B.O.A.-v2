﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticoleD.aspx.cs" Inherits="Proiect_BD.AlocareD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Articole Drepturi</h2>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" CssClass="table table-striped" GridLines="Both" OnRowCancelingEdit="CancelEdit" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Update">
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
        <asp:TextBox ID="TextBox1" runat="server" Width="40px" ></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="ID_Administrator:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Data:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="80px" ></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Savoniera:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Sapun:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="SpumaRas"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="AparatRas:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Caiete:"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="Rigla:"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server" Width="40px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="Guma:"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="Crema:"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" Text="Maieu:"></asp:Label>
        <asp:TextBox ID="TextBox12" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label13" runat="server" Text="Agrafe:"></asp:Label>
        <asp:TextBox ID="TextBox13" runat="server" Width="40px"></asp:TextBox>
        <asp:Label ID="Label14" runat="server" Text="Capse:"></asp:Label>
        <asp:TextBox ID="TextBox14" runat="server" Width="40px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    </p>
</asp:Content>
