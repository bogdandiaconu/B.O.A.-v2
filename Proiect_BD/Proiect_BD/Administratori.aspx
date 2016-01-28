
<%@ Page Title="Administratori" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administratori.aspx.cs" Inherits="Proiect_BD.Administratori" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Administratori<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="134px" Width="307px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
    </h2>
    <h2>&nbsp;</h2>
    <h2>
        &nbsp;&nbsp;&nbsp;
    </h2>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="Nume: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Font-Size="Small" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="146px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Prenume: "></asp:Label>
&nbsp;
<asp:TextBox ID="TextBox2" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="146px" Font-Size="Small"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="ID_Grad: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="146px" Font-Size="Small"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Font-Size="Medium" Height="24px" OnClick="Button1_Click" Text="Add" Width="72px" />
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>


</asp:Content>
