using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customers : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //ListItem NewItem = new ListItem("Name     " + "Address     " + "PostCode    " + "Email     ");
            //lstCustomer.Items.Add(NewItem);
            //populate the list and display the number of records found
            lblError.Text = DisplayCustomer(1) + " records in the database";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnCustomer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be delete
        Int32 CustomerId;
        //if a record has been selected from the list 
        if (lstCustomer.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            CustomerId = Convert.ToInt32(lstCustomer.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the delete page
            Response.Redirect("AnCustomer.aspx");

        }
        else
        {
            //display an error 
            lblError.Text = "please select a record to delete from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be delete
        Int32 CustomerID;
        //if a record has been selected from the list 
        if (lstCustomer.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete 
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");

        }
        else
        {
            //display an error 
            lblError.Text = "please select a record to delet from the list";
        }
    }

    Int32 DisplayCustomer(int customerID)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsCustomerCollection Customer = new clsCustomerCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the house no
        string Name;
        //var to store the post code
        string Address;
        //var to store the post code
        //string ContactNumber;
        //var to store the post code
        string PostCode;
        //var to store the post code
        string EmailAddress;
        //var to store the post code
        string CustomerID;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstCustomer.Items.Clear();
        //call the filter by post code method
        Customer.FilterByCustomerID(customerID);
        //get the count of records found
        RecordCount = Customer.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the house no from the query results
            Name = Convert.ToString(Customer.CustomerList[Index].Name);
            //get the street from the query results
            Address = Convert.ToString(Customer.CustomerList[Index].Address);
            //get the post code from the query results
            PostCode = Convert.ToString(Customer.CustomerList[Index].PostCode);
            //get the address no from the query results
            EmailAddress = Convert.ToString(Customer.CustomerList[Index].EmailAddress);
            //get the address no from the query results
            CustomerID = Convert.ToString(Customer.CustomerList[Index].CustomerID);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(Name + Address + PostCode + EmailAddress, CustomerID);
            //add the new item to the list
            lstCustomer.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }


    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
  // var to store the record count
         Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomer(0);
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtBoxSearch.Text = "";
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        if (txtBoxSearch.Text == "")
        {
            lblError.Text = "Please enter valid Customer ID";
        }
        Int32 CustomerID = Convert.ToInt32(txtBoxSearch.Text);
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomer(CustomerID);
        //display the number of records found
        lblError.Text = RecordCount + " records found";

    }
}