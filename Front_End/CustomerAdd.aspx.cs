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

            //add the record
            Customer.Add();
            Response.Redirect("MenuCustomer.apsx");
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
        //if (StaffId == -1)
        {
            //get the data entered by the user 

            Customer.ThisCustomer.Name = Convert.ToString(txtboxFirstName.Text);
            Customer.ThisCustomer.Address = Convert.ToString(txtboxAddress.Text);
            Customer.ThisCustomer.PostCode = Convert.ToString(txtboxPostcode.Text);
            Customer.ThisCustomer.ContactNumber = Convert.ToString(txtboxContactNumber.Text);
            Customer.ThisCustomer.EmailAddress = Convert.ToString(txtboxEmail.Text);
            Customer.ThisCustomer.DateJoined = Convert.ToDateTime(txtboxDateJoined.Text);

            //add the record
            Customer.Update();
            Response.Redirect("MenuCustomer.apsx");
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
            //Add a new staff
            Add();
        }
        else
        {
            //update the staff details
            Update();
        }
        //all done so redirect  back to the main page
        Response.Redirect("MenuCustomer.aspx");
    }

}
