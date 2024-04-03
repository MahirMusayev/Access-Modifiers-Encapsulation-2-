using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Assistant  :Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                GetPromotion(employee);
            }
        }
    }
}
