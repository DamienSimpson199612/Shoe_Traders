using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffAdd : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        //if this is the first time the page has loaded
        if (IsPostBack == false)
        {
            //populate the counties drop down
            DisplayStaff();
            //if we are not adding a new record
            if (StaffID != -1)            {
                //update the fields on the page with the data from the record
                DisplayStaff();
            }

        }
    }

    void Add()
    {

        //create an instance of the staff 
        clsStaffCollection Staff = new clsStaffCollection();

         
        //validate the data on the web form 
        Boolean OK = Staff.ThisStaff.Valid(txtboxFirstName.Text, txtboxLastName.Text, txtboxAddress.Text, txtboxPostcode.Text, txtboxCounty.Text, txtboxPayrollNo.Text, txtboxMobileNo.Text, txtboxTrainingCompleted.Text, txtboxRoleType.Text );
        //if the data is OK them add it to the object 
        if (OK == true)
    
        {
            //get the data entered by the user 

            Staff.ThisStaff.FirstName = Convert.ToString(txtboxFirstName.Text);
            Staff.ThisStaff.LastName = Convert.ToString(txtboxFirstName.Text);
            Staff.ThisStaff.Address = Convert.ToString(txtboxAddress.Text);
            Staff.ThisStaff.Postcode = Convert.ToString(txtboxPostcode.Text);
            Staff.ThisStaff.County = Convert.ToString(txtboxCounty.Text);
            Staff.ThisStaff.PayrollNo = Convert.ToString(txtboxPayrollNo.Text);
            Staff.ThisStaff.MobileNo = Convert.ToString(txtboxMobileNo.Text);
            Staff.ThisStaff.TrainingCompleted = Convert.ToString(txtboxTrainingCompleted.Text);
            Staff.ThisStaff.Active = Active.Checked;
            Staff.ThisStaff.RoleType = Convert.ToString(txtboxRoleType.Text);


            //add the record
            Staff.Add();
            Response.Redirect("Staff.aspx");
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
        clsStaffCollection Staff = new clsStaffCollection();

        //validate the data on the web form 
       // Boolean OK = Staff.ThisCustomer.Valid(txtboxFirstName.Text, txtboxAddress.Text, txtboxPostcode.Text, txtboxContactNumber.Text, txtboxEmail.Text, txtboxDateJoined.Text);
        //if the data is OK them add it to the object 
       // if (OK == true)
        //if we are adding a new record
       
       // {
            //get the data entered by the user 
            Staff.ThisStaff.Find(StaffID);
        Staff.ThisStaff.FirstName = Convert.ToString(txtboxFirstName.Text);
        Staff.ThisStaff.LastName = Convert.ToString(txtboxFirstName.Text);
        Staff.ThisStaff.Address = Convert.ToString(txtboxAddress.Text);
        Staff.ThisStaff.Postcode = Convert.ToString(txtboxPostcode.Text);
        Staff.ThisStaff.County = Convert.ToString(txtboxCounty.Text);
        Staff.ThisStaff.PayrollNo = Convert.ToString(txtboxPayrollNo.Text);
        Staff.ThisStaff.MobileNo = Convert.ToString(txtboxMobileNo.Text);
        Staff.ThisStaff.TrainingCompleted = Convert.ToString(txtboxTrainingCompleted.Text);
        Staff.ThisStaff.Active = Active.Checked;
        Staff.ThisStaff.RoleType = Convert.ToString(txtboxRoleType.Text);

        //add the record
        Staff.Update();
            Response.Redirect("Staff.aspx");
       // }
        //else
        //{
            //report an error 
          //  lblError.Text = "There were problems with the data provided";
        //}
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (StaffID == -1)
        {
            //Add new Staff
            Add();
        }
        else
        {
            //update the Staff details
            Update();
        }
        //all done so redirect  back to the main page
        Response.Redirect("Staff.aspx");
    }

    void DisplayStaff()
    {
        //create an instance of the addresses class
        clsStaffCollection MyStaff = new clsStaffCollection();
        //find the record we want to display
        MyStaff.ThisStaff.Find(StaffID);
        //display the firstname
        txtboxFirstName.Text = MyStaff.ThisStaff.FirstName;
        //display the lastname
        txtboxLastName.Text = MyStaff.ThisStaff.LastName;
        //diaplay the street
        txtboxAddress.Text = MyStaff.ThisStaff.Address;
        //display the town
        txtboxPostcode.Text = MyStaff.ThisStaff.Postcode;
        //display the post code
        txtboxPayrollNo.Text = MyStaff.ThisStaff.PayrollNo;
        //display the post code
        txtboxMobileNo.Text = MyStaff.ThisStaff.MobileNo;
        //display the post code
        txtboxTrainingCompleted.Text = MyStaff.ThisStaff.TrainingCompleted;
        //display the active state
        txtboxRoleType.Text = MyStaff.ThisStaff.RoleType;
        //display the active state
        Active.Checked = MyStaff.ThisStaff.Active;
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //all done so redirect  back to the main page
        Response.Redirect("Staff.aspx");
    }
}
