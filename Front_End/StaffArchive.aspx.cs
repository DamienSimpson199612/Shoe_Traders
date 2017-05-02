using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffArchive : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
        txtboxFirstName.Text = StaffID.ToString();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // function to delete the selected record 

        //create a new instance of the staff 
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to delete 
        Staff.ThisStaff.Find(StaffID);
        //delete the record 
        Staff.Delete();
        //redirect back to the main page
        Response.Redirect("Staff.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staff.aspx");
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        //all done so redirect  back to the main page
        Response.Redirect("Staff.aspx");
    }
}