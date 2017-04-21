<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="lblOrderNo" runat="server" Text="OrderNo"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Label ID="lblName" runat="server" Text="Customer Name"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox>
    <asp:Label ID="lblPostCode" runat="server" Text="Postcode"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
    <asp:Label ID="lblContactNumber" runat="server" Text="ContactNumber"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
    <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>
    <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined"></asp:Label>
    <br />
    <br />
    <asp:CheckBox ID="Active" runat="server" />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnOK" runat="server" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

