using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerAdd : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        //if this is the first time the page has loaded
        if (IsPostBack == false)
        {
            //populate the counties drop down
            DisplayCustomer();
            //if we are not adding a new record
            if (CustomerId != -1)
            {
                //update the fields on the page with the data from the record
                DisplayCustomer();
            }

        }
    }

    void Add()
    {

        //create an instance of the staff 
        clsCustomerCollection Customer = new clsCustomerCollection();

        //validate the data on the web form 
        Boolean OK = Customer.ThisCustomer.Valid(txtboxFirstName.Text,txtboxAddress.Text, txtboxPostcode.Text, txtboxContactNumber.Text, txtboxEmail.Text, txtboxDateJoined.Text);
        //if the data is OK them add it to the object 
        if (OK == true)
    
        {
            //get the data entered by the user 

            Customer.ThisCustomer.Name = Convert.ToString(txtboxFirstName.Text);
           
            Customer.ThisCustomer.Address = Convert.ToString(txtboxAddress.Text);
            Customer.ThisCustomer.PostCode = Convert.ToString(txtboxPostcode.Text);
            Customer.ThisCustomer.ContactNumber = Convert.ToString(txtboxContactNumber.Text);
            Customer.ThisCustomer.EmailAddress = Convert.ToString(txtboxEmail.Text);
            Customer.ThisCustomer.DateJoined = Convert.ToDateTime(txtboxDateJoined.Text);
            Customer.ThisCustomer.Active = Active.Checked;

            //add the record
            Customer.Add();
            Response.Redirect("MenuCustomers.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data provided";
        }
    }

    void Update()
    {

        //create an instance of the staff 
        clsCustomerCollection Customer = new clsCustomerCollection();

        //validate the data on the web form 
        Boolean OK = Customer.ThisCustomer.Valid(txtboxFirstName.Text, txtboxAddress.Text, txtboxPostcode.Text, txtboxContactNumber.Text, txtboxEmail.Text, txtboxDateJoined.Text);
        //if the data is OK them add it to the object 
        if (OK == true)
        //if we are adding a new record
       
        {
            //get the data entered by the user 
            Customer.ThisCustomer.Find(CustomerId);
            Customer.ThisCustomer.Name = Convert.ToString(txtboxFirstName.Text);
            Customer.ThisCustomer.Address = Convert.ToString(txtboxAddress.Text);
            Customer.ThisCustomer.PostCode = Convert.ToString(txtboxPostcode.Text);
            Customer.ThisCustomer.ContactNumber = Convert.ToString(txtboxContactNumber.Text);
            Customer.ThisCustomer.EmailAddress = Convert.ToString(txtboxEmail.Text);
            Customer.ThisCustomer.DateJoined = Convert.ToDateTime(txtboxDateJoined.Text);
            Customer.ThisCustomer.Active = Active.Checked;

            //add the record
            Customer.Update();
            Response.Redirect("MenuCustomers.aspx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data provided";
        }
    }





    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (CustomerId == -1)
        {
            //Add new customer
            Add();
        }
        else
        {
            //update the customer details
            Update();
        }
        //all done so redirect  back to the main page
        Response.Redirect("MenuCustomers.aspx");
    }

    void DisplayCustomer()
    {
        //create an instance of the addresses class
        clsCustomerCollection MyCustomer = new clsCustomerCollection();
        //find the record we want to display
        MyCustomer.ThisCustomer.Find(CustomerId);
        //display the house no
        txtboxFirstName.Text = MyCustomer.ThisCustomer.Name;
        //diaplay the street
        txtboxAddress.Text = MyCustomer.ThisCustomer.Address;
        //display the town
        txtboxPostcode.Text = MyCustomer.ThisCustomer.PostCode;
        //display the post code
        txtboxContactNumber.Text = MyCustomer.ThisCustomer.ContactNumber;
        //diaply the data added
        txtboxDateJoined.Text = MyCustomer.ThisCustomer.DateJoined.ToString("dd/mm/yyyy");
        //display the active state
        txtboxEmail.Text = MyCustomer.ThisCustomer.PostCode;
        //display the active state
        Active.Checked = MyCustomer.ThisCustomer.Active;
    }


}
