using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Orders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack== false)
        {
            //Populate the list and display the number of the records found
            lblError.Text = DisplayOrders("") + "records in the database";
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session 
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrder.SelectedIndex !=-1)
        {
            //get the primary key value of the record to be edited
            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to th edit page
            Response.Redirect("AnOrder.aspx");

        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text="Please select a record to delete from the list";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        //if a record has been selected from the list
        if(lstOrder.SelectedIndex !=-1)
        {
            //get primary key value fro the record to delete
            OrderNo = Convert.ToInt32(lstOrder.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");

        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        //declare var to store record count
        Int32 RecordCount;
        //assign the results of the display Orders function to the record count
        RecordCount = DisplayOrders(txtOrders.Text);
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the displayorders fuction to the record count var
        RecordCount = DisplayOrders("");
        //display the number of the records found
        lblError.Text = RecordCount + "Records in the database";
        //clear the postcode filter in the textbox
        txtOrders.Text = "";
    }
    //function to use to populate the box
    Int32 DisplayOrders(string CustomerNameFilter)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found
        
        clsOrderCollection MyOrders = new clsOrderCollection();
        //var to store the record count
        Int32 RecordCount;
        //var to store the orderNo
        string OrderNo;
        string OrderDate;
        string CustomerName;
        string CustomerNo;
        string NumberOfOrder;
        //var to store the index
        Int32 Index = 0;
        //clear the list to any existing times
        lstOrder.Items.Clear();
        //call the filter by customer name
        MyOrders.FilterByCustomerName(CustomerNameFilter);
        //get the counts of records found
        RecordCount = MyOrders.Count;
        //loop through each record found using the index to point to each record in the datatable
        while(Index<RecordCount)
        {
            //GET THE HOUSE NO FROM QUERY RESULTS
            OrderNo = Convert.ToString(MyOrders.OrderList[Index].OrderNo);
            OrderDate= Convert.ToString(MyOrders.OrderList[Index].OrderDate);
            CustomerName = Convert.ToString(MyOrders.OrderList[Index].CustomerName);
            CustomerNo = Convert.ToString(MyOrders.OrderList[Index].CustomerNo);
            NumberOfOrder = Convert.ToString(MyOrders.OrderList[Index].NumberOfOrder);
            //set up a new object of the class list item
            ListItem NewItem=new ListItem(OrderNo + " " + CustomerName + " " + CustomerNo,NumberOfOrder);
            //add the new item to the list
            lstOrder.Items.Add(NewItem);
            //INCREMENT THE INDEX
            Index++;
        }

 return RecordCount;

    }
}