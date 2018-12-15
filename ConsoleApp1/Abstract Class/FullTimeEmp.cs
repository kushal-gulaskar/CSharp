using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FullTimeEmp : BaseEmp
    {
            public int AnnualSalary { get; set; }
        
            public override int GetMonthlySalary()
            {
                return this.AnnualSalary / 12;
            }
        }
    }
