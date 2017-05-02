<%@ Page Title="" Language="C#"  AutoEventWireup="true" MasterPageFile="~/ShoeTrader.master" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
                <img src="logo.png"  style="width:286px; height:141px;"/>
            <br />    

        <div class="articlestaff"  >
 
        
         <asp:Button ID="btnHome" runat="server" Text="Home" Width="110px" OnClick="btnHome_Click1" />
         <asp:Button ID="btnAdd" runat="server" Text="Add Staff" Width="110px" OnClick="btnAdd_Click" />
         <asp:Button ID="btnArchive" runat="server" Text="Archive Selected" Width="110px" OnClick="btnArchive_Click" />
         <asp:Button ID="btnArchived" runat="server" Text="Archived" Width="110px" OnClick="btnArchived_Click" />
         <asp:Button ID="Edit" runat="server" Text="Edit" Width="110px" OnClick="Edit_Click" />
         <asp:TextBox ID="txtboxsearch" runat="server" Width="179px"></asp:TextBox>
         <asp:Button ID="btnSearch" runat="server" Text="Search" Width="110px" OnClick="btnSearch_Click" />
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
       
            <asp:ListBox ID="lstStaff" runat="server" Height="286px" Width="829px"></asp:ListBox>

</asp:Content>