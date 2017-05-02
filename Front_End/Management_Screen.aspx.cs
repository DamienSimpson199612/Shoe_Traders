using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shoe_Traders1
{
    public partial class Management_Screen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //redirect to the Staff page
            Response.Redirect("Staff.aspx");
        }
    }
}