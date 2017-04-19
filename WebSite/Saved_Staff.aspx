<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saved_Staff.aspx.cs" Inherits="Shoe_Traders1.Saved_Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="StyleSheet.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
                    <header> Shoe Traders Management System</header>

        <div class="articlestaff">
 
        
         <asp:Button ID="btnHome" runat="server" Text="Home" Width="110px" OnClick="btnHome_Click1" />
         <asp:Button ID="btnAdd" runat="server" Text="Add Staff" Width="110px" OnClick="btnAdd_Click" />
         <asp:Button ID="btnArchive" runat="server" Text="Archive Selected" Width="110px" OnClick="btnArchive_Click" />
         <asp:Button ID="btnArchived" runat="server" Text="Archived" Width="110px" OnClick="btnArchived_Click" />
         <asp:Button ID="Edit" runat="server" Text="Edit" Width="110px" OnClick="Edit_Click" />
         <asp:TextBox ID="txtSearch" runat="server" Width="179px"></asp:TextBox>
         <asp:Button ID="btnSearch" runat="server" Text="Search" Width="110px" OnClick="btnSearch_Click" />
    </div>
        <table class="tg">
  <tr>
    <td class="tg-yw4l"></td>
    <th class="tg-baqh">Staff ID</th>
    <th class="tg-yw4l">First Name</th>
    <th class="tg-yw4l">Last Name</th>
    <th class="tg-yw4l">Role Type</th>
    <th class="tg-yw4l">Address</th>
    <th class="tg-yw4l">Postcode</th>
    <th class="tg-yw4l">County</th>
    <th class="tg-yw4l">Mobile No.</th>
    <th class="tg-yw4l">Payroll No.</th>
    <th class="tg-yw4l">Training Completed</th>
    <th class="tg-yw4l">Active</th>
    <th class="tg-yw4l"><a href="Edit_Staff.aspx">Edit</a></th>
  </tr>
  <tr>
    <td class="tg-yw4l"> <input type="radio" name="chooseone" value="Select"><label for="Select"/></label></td>
    <td class="tg-yw4l">00001</td>
    <td class="tg-yw4l">John</td>
    <td class="tg-yw4l">Simpson</td>
    <td class="tg-yw4l">Staff Management</td>
    <td class="tg-yw4l">Flat 10 Deacon House, Deacon Street</td>
    <td class="tg-yw4l">LE2EF</td>
    <td class="tg-yw4l">Leicestershire</td>
    <td class="tg-yw4l">07493989218</td>
    <td class="tg-yw4l">123456789</td>
    <td class="tg-yw4l">ALL</td>
    <td class="tg-yw4l">Yes</td>
    <th class="tg-yw4l"><a href="Edit_Staff.aspx">Edit</a></th>
  </tr>
  <tr>
    <td class="tg-yw4l"> <input type="radio" name="chooseone" value="Select"><label for="Select"/></label></td>
    <td class="tg-yw4l">00002</td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
  </tr>
  <tr>
    <td class="tg-yw4l"> <input type="radio" name="chooseone" value="Select"><label for="Select"/></label></td>
    <td class="tg-yw4l">00003</td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
  </tr>
  <tr>
    <td class="tg-yw4l"> <input type="radio" name="chooseone" value="Select"><label for="Select"></label></td>
    <td class="tg-yw4l">00004</td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
    <td class="tg-yw4l"></td>
  </tr>
</table>
    </form>
</body>
</html>
