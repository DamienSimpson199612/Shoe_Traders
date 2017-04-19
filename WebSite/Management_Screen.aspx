<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Management_Screen.aspx.cs" Inherits="Shoe_Traders1.Management_Screen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="StyleSheet.css" rel="stylesheet" type="text/css" />

</head>
            

<body>
    <header> Shoe Traders Management System</header>
    <form id="form1" runat="server">
        <article>        
            <img src="../Image/logo.png"  style="width:286px; height:141px;"/>
            <br />       
            <button type="submit" formaction="MenuStock.aspx">Stock</button>
     
            <button type="submit" formaction="Staff.aspx">Staff</button>
     
            <button type="submit" formaction="">Suppliers</button>
     
            <button type="submit" formaction="">Orders</button>
     
            <button type="submit" formaction="">Customers</button>

            <button type="submit" formaction="Login_Screen.aspx">Logout</button>
        </article>
    </form>
</body>
</html>
