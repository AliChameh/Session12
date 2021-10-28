using RazorPagesTutorialModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesTutorialServices
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Mary",Department= Department.HR,Email ="mary@par.com",PhotoPath = "mary.png"},
                new Employee(){Id = 2, Name = "John",Department= Department.IT,Email ="john@par.com",PhotoPath = "john.png"},
                new Employee(){Id = 3, Name = "Sara",Department= Department.IT,Email ="Sara@par.com",PhotoPath = "Sara.png"},
                new Employee(){Id = 4, Name = "Dave",Department= Department.Payrol,Email ="David@par.com",PhotoPath = "David.png"}
            };
        }

        private List<Employee> _employeeList { get; set; }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
