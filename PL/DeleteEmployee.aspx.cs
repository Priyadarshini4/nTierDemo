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
using BLL;
using DAL;

public partial class DeleteEmployee : System.Web.UI.Page
{
    EmployeeHandler empHandler = null;
    int empID = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"] as string;

        if (id == null)
        {
            Response.Redirect("Default.aspx");
        }

        try
        {
            empID = Convert.ToInt32(id.Trim());
            empHandler = new EmployeeHandler();
            
            Employee emp = empHandler.GetEmployeeDetails(empID);

            lblEmployeeID.Text = emp.EmployeeID.ToString();
            lblLastName.Text = emp.LastName;
            lblFirstName.Text = emp.FirstName;
            lblTitle.Text = emp.Title;
            lblAddress.Text = emp.Address;
            lblCity.Text = emp.City;
            lblCountry.Text = emp.Country;
            lblRegion.Text = emp.Region;
            lblPostalCode.Text = emp.PostalCode;
            lblExtension.Text = emp.Extension;
        }
        catch(Exception)
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    
    protected void btnYES_Click(object sender, EventArgs e)
    {
        if (empHandler.DeleteEmployee(empID) == true)
        {
            Response.Redirect("Default.aspx");
        }        
    }
}
