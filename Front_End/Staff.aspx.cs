using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {

            //populate the list and display the number of records found

        }
    }
        
        protected void btnHome_Click1(object sender, EventArgs e)
        {
            //redirect to the Management_Screen.aspx page
            Response.Redirect("Management_Screen.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into session object to indicate this is a new record
            Session["StaffID"] = -1;
            //redirect to the data entry page
            Response.Redirect("StaffAdd.aspx");

        }

    protected void btnArchive_Click(object sender, EventArgs e)
    {
        //var to store th eprimary key value of the record to be deleted 
        Int32 StaffID;
        //if a record has been selected from th elist 
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the dta in the session object 
            Session["StaffID"] = StaffID;
            //redirect to the Archive_Staff page
            Response.Redirect("Archive_Staff.aspx");
        }
        else
        {
            //displaye an error
            lblError.Text = "please select a record to delete from the list";
        }
    }
        protected void btnArchived_Click(object sender, EventArgs e)
        {
            //redirect to the Archived_Staff page
            Response.Redirect("Archived_Staff.aspx");
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
        //var to store th eprimary key value of the record to be deleted 
        Int32 StaffID;
        //if a record has been selected from th elist 
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the dta in the session object 
            Session["StaffID"] = StaffID;
            //redirect to the Edit_Staff page
            Response.Redirect("Edit_Staff.aspx");
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
        RecordCount = DisplayStaff(Name);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    Int32 DisplayStaff(string Name)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsStaff
        clsStaffCollection Staff = new clsStaffCollection();
        //var to store the count of records 
        Int32 RecordCount;
        //var to stroe the FirstName 
        string FirstName;
        //var to stroe the lastName 
        string LastName;
        //var to the address 
        string Address;
        //var to store the Postcode 
        string Postcode;
        //var to store the County 
        string County;
        //var to store the PayrollNo 
        string PayrollNo;
        //var to store the MobileNo 
        string MobileNo;
        //var to store the TrainingCompleted 
        string TrainingCompleted;
        //var to store the Active 
        bool Active;
        //var to store the RoleType 
        string RoleType;
        //var to store the Staffid 
        string StaffID;

        Int32 Index = 0;
        //clear the lists of any existing items
        lstStaff.Items.Clear();
        //call the filer by StaffID 
        Staff.FilterByStaffID(Name);
        //get the counts of records found 
        RecordCount = Staff.Count;
        ListItem NewItem1 = new ListItem("FirstName...." + "LastName...." + "Address...." + "Postcode.... " + "County...." + "PayrollNo.... " + "MobileNo...." + "TrainingCompleted...." + "Active...." + "RoleType...." + "StaffID....");
        lstStaff.Items.Add(NewItem1);
        //loop through each records found using the index point to each record in the data table 
        while (Index < RecordCount)
        {
            //get the name from the query resutlos 
            FirstName = Convert.ToString(Staff.StaffList[Index].FirstName);
            //get the name from the query resutlos 
            LastName = Convert.ToString(Staff.StaffList[Index].LastName);
            //get the address from the query resutlos 
            Address = Convert.ToString(Staff.StaffList[Index].Address);
            //get the post code from the query results
            Postcode = Convert.ToString(Staff.StaffList[Index].Postcode);
            //get the emailaddress no from the query results
            County = Convert.ToString(Staff.StaffList[Index].County);
            //get the contact number from the quesry results 
            PayrollNo = Convert.ToString(Staff.StaffList[Index].PayrollNo);
            //get the contact number from the quesry results 
            MobileNo = Convert.ToString(Staff.StaffList[Index].MobileNo);
            //get the contact number from the quesry results 
            TrainingCompleted = Convert.ToString(Staff.StaffList[Index].TrainingCompleted);
            //get the active from the quesry results 
            Active = Convert.ToBoolean(Staff.StaffList[Index].Active);
            //get the contact number from the quesry results 
            RoleType = Convert.ToString(Staff.StaffList[Index].RoleType);
            //get the address no from the query results
            StaffID = Convert.ToString(Staff.StaffList[Index].StaffID);

            //set up a new object of class list item 
            ListItem NewItem = new ListItem("" + FirstName + "...." +  LastName + "...." + Address + "...." +  Postcode + ".... " + County + "...." + PayrollNo + ".... " + MobileNo + "...." + TrainingCompleted + "...." + Active + "...." + RoleType + "...." + StaffID + "....");
            //add the new item to the list
            lstStaff.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }
}
