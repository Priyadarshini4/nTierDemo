using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Employee
    {
        int employeeID;
        string lastName;    //  should be (20)  chars only
        string firstName;   //	should be (10)	chars only
        string title;       //	should be (30)	chars only
        string address;     //	should be (60)	chars only
        string city;        //	should be (15)	chars only
        string region;      //	should be (15)	chars only
        string postalCode;  //	should be (10)	chars only
        string country;     //	should be (15)	chars only
        string extension;   //	should be (4)	chars only

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName  = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                extension = value;
            }
        }
    }
}
