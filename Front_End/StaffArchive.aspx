<%@ Page Title="" Language="C#" MasterPageFile="~/ShoeTrader.master" AutoEventWireup="true" CodeFile="StaffArchive.aspx.cs" Inherits="StaffArchive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



<table>
        <tr>
            <td>StaffID:</td>
            <td> <asp:TextBox ID="txtboxFirstName" runat="server"></asp:TextBox></td></tr>
            <td style="height: 32px"> &nbsp;</td>
                <td style="height: 32px"></td>                
        </tr>
    <td style="height: 32px">
        &nbsp;</td>
    <tr>
           <td>


               <asp:Button ID="btnSubmit" runat="server" Text="Delete" OnClick="btnSubmit_Click" /></td>
        <td> <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click1" /></td>

        </tr>
         </table>
    


</asp:Content>

