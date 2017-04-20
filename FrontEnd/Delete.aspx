<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:TextBox ID="txtOrderNo" runat="server" OnTextChanged="txtOrderNo_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblDeleteOrder" runat="server" Text="Are you sure you want to delete this order?"></asp:Label>
    <br />
    <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
    <asp:Button ID="BtnNo" runat="server" OnClick="BtnNo_Click" Text="No" />
</asp:Content>

