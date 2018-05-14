using DemoApp.DAL;
using System.Collections.Generic;
using System.Linq;
using DemoApp.DTO;

namespace DemoApp.BLL
{
    public class Employee
    {
        DemoAppDBContext context = new DemoAppDBContext();
        
        public IEnumerable<DTO.GetEmployees_Result> GetEmployees()
        {
            List<DTO.GetEmployees_Result> employeesResult = null;

            var employees = context.GetEmployees().ToList();

            if (employees != null)
            {
                //Add required logic here...

                employeesResult = new List<DTO.GetEmployees_Result>();

                foreach (var employee in employees)
                {
                    DTO.GetEmployees_Result emp = new DTO.GetEmployees_Result();
                    emp.DeptName = employee.DeptName;
                    emp.EmpName = employee.EmpName;
                    emp.Location = employee.Location;
                    employeesResult.Add(emp);
                }
            }

            return employeesResult;
        }
    }
}
