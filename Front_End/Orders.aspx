<%@ Page Title="" Language="C#" MasterPageFile="~/ShoeTrader.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="lstOrder" runat="server" Height="166px" Width="410px"></asp:ListBox>
<br />
<asp:TextBox ID="txtOrders" runat="server"></asp:TextBox>
<asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
&nbsp;<asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display All" />
<br />
<br />
<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
    <br />
    <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
<br />
</asp:Content>

