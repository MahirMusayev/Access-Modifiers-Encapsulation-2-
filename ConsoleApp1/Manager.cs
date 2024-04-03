using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manager
    {
        protected internal void GetPromotion(Employee employee)
        {
            if (employee.Salary > 0)
            {
                employee.Salary += 100;
                Console.WriteLine($"{employee.Name} maasi 100 vahid artaraq {employee.Salary}");
            }
        }
    }
}
