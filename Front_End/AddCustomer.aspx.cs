using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AddCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Add()
    {

        //create an instance of the staff 
       clsCustomerCollection  Customer = new clsCustomerCollection();

        //validate the data on the web form 
        Boolean OK = Customer.ThisCustomer.Valid(txtboxFirstName.Text, txtboxSurName.Text, txtboxAddress.Text, txtboxPostCode.Text, txtboxPhoneNO.Text, txtboxJobTitle.Text, txtboxDateJoined.Text);
        //if the data is OK them add it to the object 
        if (OK == true)
        //if we are adding a new record
        //if (StaffId == -1)
        {
            //get the data entered by the user 

            Customer.ThisCustomer.Name = Convert.ToString(txtboxFirstName.Text);
            Customer.ThisCustomer. = Convert.ToString(txtboxLastName.Text);
            Customer.ThisCustomer.Address = Convert.ToString(txtboxAddress.Text);
            Customer.ThisCustomer.PostCode = Convert.ToString(txtboxPostCode.Text);
            Customer.ThisCustomer.ContactNumber = Convert.ToString(txtboxPhoneNO.Text);
            Customer.ThisCustomer.JobTitle = Convert.ToString(txtboxJobTitle.Text);
            Customer.ThisCustomer.DateJoined = Convert.ToDateTime(txtboxDateJoined.Text);
            //add the record
            Staff.Add();
            Response.Redirect("Staff.apsx");
        }
        else
        {
            //report an error 
            lblError.Text = "There were problems with the data provided";
        }
    }
}