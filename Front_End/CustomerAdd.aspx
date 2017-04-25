<%@ Page Title="" Language="C#" MasterPageFile="~/ShoeTrader.master" AutoEventWireup="true" CodeFile="CustomerAdd.aspx.cs" Inherits="CustomerAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>First Name:</td>
            <td> <asp:TextBox ID="txtboxFirstName" runat="server"></asp:TextBox></td></tr>
            <tr>
                <td> DateJoined:</td>
                </td><td> <asp:TextBox ID="txtboxDateJoined" runat="server"></asp:TextBox></td></tr>
            <tr>
                <td>Address</td>
                <td><asp:TextBox ID="txtboxAddress" runat="server"></asp:TextBox></td>                
        </tr>
         <tr>
                <td> PostCode:</td>
                <td><asp:TextBox ID="txtboxPostcode" runat="server"></asp:TextBox></td>                
        </tr>
          <td> Contact Number:</td>
                <td><asp:TextBox ID="txtboxContactNumber" runat="server"></asp:TextBox></td>                
        </tr>
          <td> Email:</td>
                <td><asp:TextBox ID="txtboxEmail" runat="server"></asp:TextBox></td>                
        </tr>
    <td>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <asp:CheckBox ID="Active" runat="server" />
    </td>
    <tr>
           <td>


               <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
        <td> <asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>

        </tr>
         </table>
    
</asp:Content>




