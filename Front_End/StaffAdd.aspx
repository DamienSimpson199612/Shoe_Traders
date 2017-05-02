<%@ Page Title="" Language="C#" MasterPageFile="~/ShoeTrader.master" AutoEventWireup="true" CodeFile="StaffAdd.aspx.cs"  Inherits="StaffAdd"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>First Name:</td>
            <td> <asp:TextBox ID="txtboxFirstName" runat="server"></asp:TextBox></td></tr>
            <tr>
            <td>Last Name:</td>
            <td> <asp:TextBox ID="txtboxLastName" runat="server"></asp:TextBox></td></tr>
            <tr>
            <td> Address:</td>
            <td> <asp:TextBox ID="txtboxAddress" runat="server"></asp:TextBox></td></tr>
            <tr>
            <td>Postcode</td>
            <td><asp:TextBox ID="txtboxPostcode" runat="server"></asp:TextBox></td>                
            </tr>
            <tr>
            <td> County:</td>
            <td><asp:TextBox ID="txtboxCounty" runat="server"></asp:TextBox></td>                
            </tr>
            <td> Payroll Number:</td>
            <td><asp:TextBox ID="txtboxPayrollNo" runat="server"></asp:TextBox></td>                
            </tr>
            <td> MobileNo:</td>
            <td><asp:TextBox ID="txtboxMobileNo" runat="server"></asp:TextBox></td>                
            </tr>
            <td> Training Completed:</td>
            <td><asp:TextBox ID="txtboxTrainingCompleted" runat="server"></asp:TextBox></td>                
            </tr>
             <td> Role Type:</td>
            <td><asp:TextBox ID="txtboxRoleType" runat="server"></asp:TextBox></td>                
            </tr>
            <td>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <asp:CheckBox ID="Active" runat="server" />
    </td>
    <tr>
           <td>


               <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
        <td> <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" /></td>

        </tr>
         </table>
    
</asp:Content>




