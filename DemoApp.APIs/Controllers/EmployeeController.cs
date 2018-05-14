using System.Collections.Generic;
using System.Web.Http;
using DemoApp.BLL;
using DemoApp.DTO;
using System.Linq;

namespace DemoApp.APIs.Controllers
{
    public class EmployeeController : ApiController
    {
        BLL.Employee emp = new BLL.Employee();

        // GET api/employee
        public IEnumerable<DTO.GetEmployees_Result> GetEmployees()
        {
            var employees = emp.GetEmployees().ToList();

            return employees;
        }
    }
}