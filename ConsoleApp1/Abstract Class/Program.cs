using ConsoleApp1;
using ConsoleApp1.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacelesson
{
    class Program
    {
        public static void Main()
        {
            FullTimeEmp fte = new FullTimeEmp()
            {
                ID = 102,
                FirstName = "Kushal Selenium..",
                LastName = "99999999",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetEmpID());
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("-------------");

            ContractEmp cte = new ContractEmp()
            {
                ID = 103,
                FirstName = "Sam",
                LastName = "Brooks",
                HourlyPay = 100,
                TotalHoursWorked = 40
            };
            Console.WriteLine(cte.GetEmpID());
            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
