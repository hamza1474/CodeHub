using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary)
        {
            this.name = name;
            this.salary = salary;
        }


        public int SetSalary
        {

            set
            {
                if (value > 50000)
                {
                    salary = value;
                    success = true;
                }
                else
                {
                    
                    MessageBox.Show("Incorrect Value ", "Error");
                }
            }
        }

        public override int GetSalary()
        {
            return salary;
        }
    }
}
