using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClass
{
    internal class Employee
    {
        public Employee()
        {

        }
        
        public Employee(string name, string surname, byte age, string departmentname, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentname;
            Salary = salary;

        }


        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public double Salary;
    }
}


