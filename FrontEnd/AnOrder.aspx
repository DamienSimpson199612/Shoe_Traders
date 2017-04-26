<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="lblOrderNo" runat="server" Text="OrderNo"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate"></asp:Label>
    <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblCustomerNo" runat="server" Text="CustomerNo"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblNumOfOrder" runat="server" Text="Number Of Order"></asp:Label>
&nbsp;<asp:TextBox ID="txtNumberOfOrder" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblActive" runat="server" Text="Active"></asp:Label>
&nbsp;<asp:CheckBox ID="Active" runat="server" />
    <br />
    <br />
    <br />
<%--    <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />--%>
    <br />
    <br />
    <br />
</asp:Content>

