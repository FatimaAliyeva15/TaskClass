using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClass
{
    internal class Department : Employee
    {
        public Employee[] Employees = new Employee[] { };

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
            
        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public void ShowEmployeeInfo()
        {
            for(int i = 0; i<Employees.Length; i++)
            {
                Employee employee = Employees[i];
                Console.WriteLine($"{employee.Name}, {employee.Surname}, {employee.Age}, {employee.DepartmentName}, {employee.Salary}");
            }
        }

        public Employee[] GetAllEmployeesBySalary(double minSalary, double maxSalary)
        {
            Employee[] salary = new Employee[] { };

            int iscisayi = 0; 

            for (int i = 0; i < Employees.Length; i++)
            {
                Employee employee = Employees[i];
                if (employee.Salary >= minSalary && employee.Salary <= maxSalary)
                {
                    Array.Resize(ref salary, iscisayi + 1); 
                    salary[iscisayi] = employee; 
                    iscisayi ++;
                }
            }

            return salary;
        }



    }
}
