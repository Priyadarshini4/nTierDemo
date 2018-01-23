using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;
using DAL;

public partial class _Default : System.Web.UI.Page 
{
    EmployeeHandler empHandler = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Text = string.Empty;

        empHandler = new EmployeeHandler();
        if (IsPostBack == false)
        {
            BindData();
        }
    }

    private void BindData()
    {
        GridView1.DataSource = empHandler.GetEmployeeList();
        GridView1.DataBind();
    }

    
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindData();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        BindData();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label lblID = GridView1.Rows[e.RowIndex].FindControl("lblID") as Label;

        TextBox txtLastName = GridView1.Rows[e.RowIndex].FindControl("txtLastName") as TextBox;
        TextBox txtFirstName = GridView1.Rows[e.RowIndex].FindControl("txtFirstName") as TextBox;
        TextBox txtTitle = GridView1.Rows[e.RowIndex].FindControl("txtTitle") as TextBox;
        TextBox txtAddress = GridView1.Rows[e.RowIndex].FindControl("txtAddress") as TextBox;
        TextBox txtCity = GridView1.Rows[e.RowIndex].FindControl("txtCity") as TextBox;
        TextBox txtRegion = GridView1.Rows[e.RowIndex].FindControl("txtRegion") as TextBox;
        TextBox txtPostalCode = GridView1.Rows[e.RowIndex].FindControl("txtPostalCode") as TextBox;
        TextBox txtCountry = GridView1.Rows[e.RowIndex].FindControl("txtCountry") as TextBox;
        TextBox txtExtension = GridView1.Rows[e.RowIndex].FindControl("txtExtension") as TextBox;


        if (lblID != null && txtLastName != null && txtFirstName != null && txtTitle != null &&
            txtAddress != null && txtCity != null && txtRegion != null &&
            txtPostalCode != null && txtCountry != null && txtExtension != null)
        {
            Employee employee = new Employee();

            employee.EmployeeID = Convert.ToInt32(lblID.Text.Trim());
            employee.LastName = txtLastName.Text;
            employee.FirstName = txtFirstName.Text;
            employee.Title = txtTitle.Text;
            employee.Address = txtAddress.Text;
            employee.City = txtCity.Text;
            employee.Region = txtRegion.Text;
            employee.PostalCode = txtPostalCode.Text;
            employee.Country = txtCountry.Text;
            employee.Extension = txtExtension.Text;

            //Let us now update the database
            if (empHandler.UpdateEmployee(employee) == true)
            {
                lblResult.Text = "Record Updated Successfully";
            }
            else
            {
                lblResult.Text = "Failed to Update record";
            }

            //end the editing and bind with updated records.
            GridView1.EditIndex = -1;
            BindData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddEmployee.aspx");
    }
}
