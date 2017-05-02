<%@ Page Title="" Language="C#" MasterPageFile="~/ShoeTrader.master" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
                <img src="logo.png"  style="width:286px; height:141px;"/>
            <br />    
    <div class="article">
        
    <asp:Button ID="btnHome" runat="server" Text="Home" Width="110px" OnClick="btnHome_Click" />
    <asp:Button ID="btnAdd" runat="server" Text="Add" Width="110px" OnClick="btnAdd_Click" />
    <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="110px"  OnClick="btnEdit_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="110px" OnClick="btnDelete_Click" />
    <asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label>
    <asp:TextBox ID="txtboxsearch" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Search" Width="110px" OnClick="btnSearch_Click" />
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
            <asp:ListBox ID="lstCustomer" runat="server" Height="286px" Width="829px"></asp:ListBox>

<%--    <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />--%>

        </div>



</asp:Content>

