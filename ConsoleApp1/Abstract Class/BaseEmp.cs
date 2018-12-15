using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class BaseEmp
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GetEmpID()
        {
            return this.ID;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public virtual int GetMonthlySalary()
        {
            throw new NotImplementedException();
        }
    }
}
