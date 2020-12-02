<%@ Page Title="Test" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="PresentationLayer.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    <asp:Button ID="Kreiraj" runat="server" Text="Kreiraj" OnClick="Kreiraj_Click" />
<asp:Label ID="Title1" runat="server" Text="Title"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
        <asp:Label ID="LB" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Text=""></asp:TextBox>
                <asp:Label ID="ListBox" runat="server" Text ="Price"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" Text=""></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Update" ViewStateMode="Disabled" OnClick="Button2_Click" />

</asp:Content>
