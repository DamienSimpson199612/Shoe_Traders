using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {

            //populate the list and display the number of records found

        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerAdd.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store th eprimary key value of the record to be deleted 
        Int32 CustomerID;
        //if a record has been selected from th elist 
        if (lstCustomer.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            //store the dta in the session object 
            Session["CustomerID"] = CustomerID;
            //redirect to the home page 
            Response.Redirect("CustomerAdd.aspx");
        }
        else
        {
            //displaye an error
            lblError.Text = "please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store th eprimary key value of the record to be deleted 
        Int32 CustomerID;
        //if a record has been selected from th elist 
        if (lstCustomer.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
            //store the dta in the session object 
            Session["CustomerID"] = CustomerID;
            //redirect to the home page 
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            //displaye an error
            lblError.Text = "please select a record to delete from the list";
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        if (txtboxsearch.Text == "")
        {
            lblError.Text = "Please enter valid Customer ID";
        }
        string Name = txtboxsearch.Text;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomer(Name);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    Int32 DisplayCustomer(string Name)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsCustomer 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //var to store the count of records 
        Int32 RecordCount;
        //var to stroe the name 
        string name;
        //var to the address 
        string Address;
        //car to store the ContactNumber 
        string ContactNumber;
        //var to store the Postcode 
        string PostCode;
        //var to store th email address
        string EmailAddress;
        //var to store the active
        bool Active;
        //var to store the customerid 
        string CustomerID;

        Int32 Index = 0;
        //clear the lists of any existing items
        lstCustomer.Items.Clear();
        //call the filer by CustomerID 
        Customer.FilterByCustomerID(Name);
        //get the counts of records found 
        RecordCount = Customer.Count;
        ListItem NewItem1 = new ListItem("Name...." + "Address...." + "PostCode.... " + "Email...." + "ContactNumber.... " + "Active...." + "CustomerID....");
        lstCustomer.Items.Add(NewItem1);
        //loop through each records found using the index point to each record in the data table 
        while (Index < RecordCount)
        {
            //get the name from the query resutlos 
            name = Convert.ToString(Customer.CustomerList[Index].Name);
            //get the address from the query resutlos 
            Address = Convert.ToString(Customer.CustomerList[Index].Address);
            //get the post code from the query results
            PostCode = Convert.ToString(Customer.CustomerList[Index].PostCode);
            //get the emailaddress no from the query results
            EmailAddress = Convert.ToString(Customer.CustomerList[Index].EmailAddress);
            //get the address no from the query results
            CustomerID = Convert.ToString(Customer.CustomerList[Index].CustomerID);
            //get the contact number from the quesry results 
            ContactNumber = Convert.ToString(Customer.CustomerList[Index].ContactNumber);
            //get the active from the quesry results 
            Active = Convert.ToBoolean(Customer.CustomerList[Index].Active);

            //set up a new object of class list item 
            ListItem NewItem = new ListItem("" + name + "...." + Address + "...." + PostCode + ".... " + EmailAddress + "...." + ContactNumber + "...." + Active + "....", CustomerID);
            //add the new item to the list
            lstCustomer.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }



    //void DisplayCustomer()
    //{
    //    clsCustomerCollection customer = new clsCustomerCollection();
    //    lstCustomer.DataSource = customer.CustomerList;
    //    lstCustomer.DataValueField = "CustomerID";
    //    lstCustomer.DataTextField = "Name";


    //    lstCustomer.DataBind();
    //}




    protected void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Management_Screen.aspx");
    }
}
