using RazorPagesTutorialModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesTutorialServices
{
    interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
