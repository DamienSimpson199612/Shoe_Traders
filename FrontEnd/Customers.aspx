<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:ListBox ID="lstCustomer" runat="server" Height="107px" Width="338px"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Please Enter  a Customer"></asp:Label>
    <br />
    <asp:TextBox ID="txtBoxSearch" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
    <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" />
    <br />
    <br />
</asp:Content>

