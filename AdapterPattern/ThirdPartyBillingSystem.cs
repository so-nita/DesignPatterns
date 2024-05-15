using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"EUR {employee.Salary} salary credited to {employee.Name}'s account.");
            }
        }
    }
}
