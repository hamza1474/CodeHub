using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Company
{
    abstract class Employee
    {
        public static bool success = false;
        public string name;
        public int age;
        public int salary;

        protected Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        protected Employee(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
        }

        abstract public int GetSalary();
    }
}
