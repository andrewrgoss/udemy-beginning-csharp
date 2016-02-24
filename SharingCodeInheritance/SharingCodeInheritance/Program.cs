using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharingCodeInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee employee = new HourlyEmployee();
            employee.Name = "Joe Dirt"; //inherited from base class
            employee.EmployeeId = 5; //inherited from base class
            employee.HourlyRate = 10.50M; //extended from base class
        }

        class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
        }

        class SalariedEmployee : Employee
        {
            public decimal AnnualPay { get; set; }
        }

        class HourlyEmployee : Employee
        {
            public decimal HourlyRate { get; set; }
        }
    }
}
