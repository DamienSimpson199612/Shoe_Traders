<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Screen.aspx.cs" Inherits="Shoe_Traders1.Login_Screen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="LoginForm" runat="server">        
        <header> Shoe Traders Management System</header>
        <article>
            <img src="../Image/logo.png"  style="width:286px; height:141px;"/>
            <br />
            Username: <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>
            <br />
            Password:&nbsp; <asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox>
            <br />          
       
            <button type="submit" formaction="Management_Screen.aspx">Login</button>            
        </article>
    </form>
</body>
</html>