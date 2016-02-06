

<%@ Page Title="Administratori" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administratori.aspx.cs" Inherits="Proiect_BD.Administratori" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Administratori</h2>    
    <p>&nbsp;</p>
    <p>
       
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" CssClass="table table-striped" GridLines="Both" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Update" Width="600px"  EnableViewState="true" OnRowCancelingEdit="CancelEdit" >
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
    <h2>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="Nume: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Font-Size="Small" Height="20px" Width="110px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Prenume: "></asp:Label>
<asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="110px" Font-Size="Small"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="ID_Grad: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="70px" Font-Size="Small"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Font-Size="Medium" Height="26px" OnClick="Button1_Click" Text="Add" Width="72px" />
    </h2>
<p>
        &nbsp;</p>


</asp:Content>
