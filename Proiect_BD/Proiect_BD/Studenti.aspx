<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Studenti.aspx.cs" Inherits="Proiect_BD.Studenti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Studenti</h2>
    
     <p>
         &nbsp;</p>
<p>
        <asp:GridView ID="GridView2" runat="server" CellPadding="4" CssClass="table table-striped" ForeColor="#333333" GridLines="Both" OnRowCancelingEdit="CancelEdit" OnRowDeleting="Delete" OnRowEditing="Edit" OnRowUpdating="Update">
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
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nume:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="90px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Prenume:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="90px"></asp:TextBox>
&nbsp;<asp:Label ID="Label3" runat="server" Text="ID_Grad:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="60px"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="CNP:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Width="90px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Adresa:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="90px"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="ID_Companie:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" Width="60px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Optiuni:
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
             <asp:ListItem></asp:ListItem>
            <asp:ListItem>StudentByCompanie</asp:ListItem>
        </asp:DropDownList>
    &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" Visible="false" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;
        <asp:Button ID="Button2" runat="server" Visible="false" OnClick="Button2_Click" Text="OK" Width="63px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView3" runat="server" CellPadding="4" CssClass="table table-striped" ForeColor="#333333" GridLines="Both">
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
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
</asp:Content>
