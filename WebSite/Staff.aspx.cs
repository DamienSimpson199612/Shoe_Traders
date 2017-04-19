using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shoe_Traders1
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnHome_Click1(object sender, EventArgs e)
        {
            //redirect to the Management_Screen.aspx page
            Response.Redirect("Management_Screen.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into session object to indicate this is a new record
            Session["StaffID"] = -1;
            //redirect to the data entry page
            Response.Redirect("Add_Staff.aspx");

        }

        protected void btnArchive_Click(object sender, EventArgs e)
        {
            //redirect to the Archive_Staff page
            Response.Redirect("Archive_Staff.aspx");
        }

        protected void btnArchived_Click(object sender, EventArgs e)
        {
            //redirect to the Archived_Staff page
            Response.Redirect("Archived_Staff.aspx");
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            //redirect to the Edit_Staff page
            Response.Redirect("Edit_Staff.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //redirect to the Searched page
            Response.Redirect("Searched.aspx");
        }
    }
}