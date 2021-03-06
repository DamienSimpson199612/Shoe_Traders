﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        txtboxFirstName.Text = CustomerID.ToString();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // function to delete the selected record 

        //create a new instance of the staff 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to delete 
        Customer.ThisCustomer.Find(CustomerID);
        //delete the record 
        Customer.Delete();
        //redirect back to the main page
        Response.Redirect("Customer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Customer.aspx");
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        //all done so redirect  back to the main page
        Response.Redirect("Customer.aspx");
    }
}