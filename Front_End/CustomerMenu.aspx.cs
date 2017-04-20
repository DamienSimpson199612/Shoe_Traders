using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("AddCustomer.aspx");
    }
}