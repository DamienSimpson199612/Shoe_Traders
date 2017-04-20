<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>

       <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
        <title>Menu Page</title>
    
</head>
<body>

    <form id="form1" runat="server">

   <header align="center"> Shoe Traders Management System</header>
    <table align="center">

        
    <tr>
        <td> 
            Search: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Search" />
            <br />
            <br />
            <textarea id="TextArea1" cols="40" rows="4"></textarea></td>
	</tr>
        
    
         

        <br />
    <tr>
    <td>

                    <asp:Button ID="btnAdd" runat="server" Text="Add" />

                  <asp:Button ID="btnEdit" runat="server" Text="Edit" />

                 v<asp:Button ID="btnView" runat="server" Text="View" />

                <asp:Button ID="btnDelete" runat="server" Text="Delete" />

                 <asp:Button ID="btnSuspened" runat="server" Text="Suspened" />

                 <asp:Button ID="btnMenu" runat="server" Text="Menu" />

    </td>
 </tr>


         <tr>
             <td>

                  &nbsp;</td>
             </tr>
         <tr>
             <td>

                 &nbsp;</td>
             </tr>

        
         <tr>
             <td>

                 &nbsp;</td>
             </tr>
         <tr>
             <td>

                 &nbsp;</td>
             </tr>

     </table>

    </form>

</body>
</html>