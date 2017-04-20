<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
      <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
       <header align="center"> Shoe Traders Management System</header>
    
    <table align="center">
        <tr>
            <td>First Name:</td>
            <td> <asp:TextBox ID="txtboxFirstName" runat="server"></asp:TextBox></td></tr>
            <tr>
                <td> Surname:</td>
                </td><td> <asp:TextBox ID="txtboxSurname" runat="server"></asp:TextBox></td></tr>
            <tr>
                <td>Address</td>
                <td><asp:TextBox ID="txtboxAddress" runat="server"></asp:TextBox></td>                
        </tr>
         <tr>
                <td> PostCode:</td>
                <td><asp:TextBox ID="txtbosPostcode" runat="server"></asp:TextBox></td>                
        </tr>
          <td> Contact Number:</td>
                <td><asp:TextBox ID="txtboxContactNumber" runat="server"></asp:TextBox></td>                
        </tr>
          <td> Email:</td>
                <td><asp:TextBox ID="txtboxEmail" runat="server"></asp:TextBox></td>                
        </tr>
           <td>
               <asp:Button ID="btnSubmit" runat="server" Text="Submit" /></td>
        <td> <asp:Button ID="btnCancel" runat="server" Text="Cancel" /></td>
         </table>
  
     
</body>
</html>