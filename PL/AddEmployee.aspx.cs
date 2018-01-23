using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DAL;
using BLL;

public partial class AddEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYES_Click(object sender, EventArgs e)
    {
        Employee emp = new Employee();

        emp.LastName = txtLName.Text;
        emp.FirstName = txtFName.Text;
        emp.Address = txtAddress.Text;
        emp.City = txtCity.Text;
        emp.Country = txtCountry.Text;
        emp.Region = txtRegion.Text;
        emp.PostalCode = txtCode.Text;
        emp.Extension = txtExtension.Text;
        emp.Title = txtTitle.Text;

        EmployeeHandler empHandler = new EmployeeHandler();

        if (empHandler.AddNewEmployee(emp) == true)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
