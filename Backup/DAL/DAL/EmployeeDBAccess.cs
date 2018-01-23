using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class EmployeeDBAccess
    {
        public bool AddNewEmployee(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {                
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("@Title", employee.Title),
                new SqlParameter("@Address", employee.Address),
                new SqlParameter("@City", employee.City),
                new SqlParameter("@Region", employee.Region),
                new SqlParameter("@PostalCode", employee.PostalCode),
                new SqlParameter("@Country", employee.Country),
                new SqlParameter("@Extension", employee.Extension)
            };

            return SqlDBHelper.ExecuteNonQuery("AddNewEmployee", CommandType.StoredProcedure, parameters);
        }

        public bool UpdateEmployee(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", employee.EmployeeID),
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("@Title", employee.Title),
                new SqlParameter("@Address", employee.Address),
                new SqlParameter("@City", employee.City),
                new SqlParameter("@Region", employee.Region),
                new SqlParameter("@PostalCode", employee.PostalCode),
                new SqlParameter("@Country", employee.Country),
                new SqlParameter("@Extension", employee.Extension)
            };

            return SqlDBHelper.ExecuteNonQuery("UpdateEmployee", CommandType.StoredProcedure, parameters);
        }

        public bool DeleteEmployee(int empID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@empId", empID)
            };

            return SqlDBHelper.ExecuteNonQuery("DeleteEmployee", CommandType.StoredProcedure, parameters);
        }

        public Employee GetEmployeeDetails(int empID)
        {
            Employee employee = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@empId", empID)
            };
            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteParamerizedSelectCommand("GetEmployeeDetails", CommandType.StoredProcedure, parameters))
            {
                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    //Lets go ahead and create the list of employees
                    employee = new Employee();

                    //Now lets populate the employee details into the list of employees                                           
                    employee.EmployeeID = Convert.ToInt32(row["EmployeeID"]);
                    employee.LastName = row["LastName"].ToString();
                    employee.FirstName = row["FirstName"].ToString();
                    employee.Title = row["Title"].ToString();
                    employee.Address = row["Address"].ToString();
                    employee.City = row["City"].ToString();
                    employee.Region = row["Region"].ToString();
                    employee.PostalCode = row["PostalCode"].ToString();
                    employee.Country = row["Country"].ToString();
                    employee.Extension = row["Extension"].ToString();
                }
            }

            return employee;
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> listEmployees = null;

            //Lets get the list of all employees in a datataable
            using (DataTable table = SqlDBHelper.ExecuteSelectCommand("GetEmployeeList", CommandType.StoredProcedure))
            {
                //check if any record exist or not
                if (table.Rows.Count > 0)
                {
                    //Lets go ahead and create the list of employees
                    listEmployees = new List<Employee>();

                    //Now lets populate the employee details into the list of employees
                    foreach (DataRow row in table.Rows)
                    {
                        Employee employee = new Employee();
                        employee.EmployeeID = Convert.ToInt32(row["EmployeeID"]);
                        employee.LastName = row["LastName"].ToString();
                        employee.FirstName = row["FirstName"].ToString();
                        employee.Title = row["Title"].ToString();
                        employee.Address = row["Address"].ToString();
                        employee.City = row["City"].ToString();
                        employee.Region = row["Region"].ToString();
                        employee.PostalCode = row["PostalCode"].ToString();
                        employee.Country = row["Country"].ToString();
                        employee.Extension = row["Extension"].ToString();

                        listEmployees.Add(employee);
                    }
                }
            }

            return listEmployees;
        }        
    }
}
