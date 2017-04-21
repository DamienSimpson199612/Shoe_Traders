using Class_Library;
using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page


{
    //var to store the address number
    Int32 OrderNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the address no from the session object
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        //if this is the first time the page has loaded
        if (IsPostBack == false)
        {
            //Populate the counties drop down
            DisplayCustomers();
            //if we are not adding a new record
            if (OrderNo != -1)
            {

                //update the fields on the page with the data from the record
                DisplayOrders();
            }
            else//this is the new record
            {
                //set the date to todays date
                txtOrderDate.Text = DateTime.Today.Date.ToString("dd/MM/yyy");
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //var to store error messages
        string ErrorMsg;
        // //create an instance of the address class
        clsOrderCollection OrderFile = new clsOrderCollection();
        //use the objects validation method to test the data
        ErrorMsg = OrderFile.ThisOrder.Valid(txtCustomerName.Text, txtNumberOfOrder.Text, txtOrderDate.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (OrderNo == -1)
            {
                //set the property
                OrderFile.ThisOrder.CustomerName = txtCustomerName.Text;
                //set the property
                OrderFile.ThisOrder.NumberOfOrder = Convert.ToInt32(txtNumberOfOrder.Text);
                //set the property
                OrderFile.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate);
                //set the property
                OrderFile.ThisOrder.Active = Active.Checked;
                //invoke the add method
                OrderFile.Add();
            }
            else
            {
                OrderFile.ThisOrder.Find(OrderNo);
                //set the property
                OrderFile.ThisOrder.CustomerName = txtCustomerName.Text;
                //set the property
                OrderFile.ThisOrder.NumberOfOrder = Convert.ToInt32(txtNumberOfOrder.Text);
                //set the property
                OrderFile.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate);
                //set the property
                OrderFile.ThisOrder.Active = Active.Checked;
                //update record
                OrderFile.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("Orders.aspx");
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = ErrorMsg;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}