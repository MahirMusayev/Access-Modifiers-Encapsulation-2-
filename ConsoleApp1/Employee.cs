using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Employee : Manager
    {
        private string _name;
        private bool _isSuccessfull;
        private decimal _salary;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public bool IsSuccessfull
        {
            get { return _isSuccessfull; }
            set { _isSuccessfull = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Maaş 0 dan kicik ola bilmez ");
                }
            }
        }
        public Employee(string name, bool issuccessfull, decimal salary)
        {
            Name = name;
            IsSuccessfull = issuccessfull;
            Salary = salary;
        }
    }
}
