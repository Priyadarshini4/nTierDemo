using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL
{
    public class EmployeeHandler
    {
        // Handle to the Employee DBAccess class
        EmployeeDBAccess employeeDb = null;

        public EmployeeHandler()
        {
            employeeDb = new EmployeeDBAccess();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public List<Employee> GetEmployeeList()
        {
            return employeeDb.GetEmployeeList();
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool UpdateEmployee(Employee employee)
        {
            return employeeDb.UpdateEmployee(employee);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public Employee GetEmployeeDetails(int empID)
        {
            return employeeDb.GetEmployeeDetails(empID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool DeleteEmployee(int empID)
        {
            return employeeDb.DeleteEmployee(empID);
        }

        // This fuction does not contain any business logic, it simply returns the 
        // list of employees, we can put some logic here if needed
        public bool AddNewEmployee(Employee employee)
        {
            return employeeDb.AddNewEmployee(employee);
        }
    }
}
