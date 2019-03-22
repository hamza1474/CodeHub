using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Company
{
    class Worker : Employee
    {
        public Worker(string name, int age, int salary) : base(name, age, salary)
        {
            this.name = name;
            this.salary = salary;
            this.age = age;

        }


        public int SetSalary
        {

            set
            {
                if (value <= 80000 && value >= 35000)
                {
                    if (age > 35)
                    {
                    salary = value + ((value*10)/100);

                    }
                    else
                    {
                        salary = value;
                    }
                    success = true;
                }
                else MessageBox.Show("Incorrect Value ", "Error");
            }

        }
        

        public override int GetSalary()
        {

            return salary;
        }
    }
}
