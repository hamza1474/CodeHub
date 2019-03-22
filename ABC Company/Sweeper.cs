using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Company
{
    class Sweeper : Employee
    {
        public Sweeper(string name,  int salary) : base(name, salary)
        {
            this.name = name;
            this.salary = salary;
              
        }

        public override int GetSalary()
        {
            success = true;
            salary = 10000;
            return salary;
        }
    }
}
