using ApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiProject.Controllers
{
    /// <summary>
    /// Employees Controller
    /// </summary>
    public class EmployeesController : ApiController
    {
        /// <summary>
        /// Get Employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBContext dbContext = new EmployeeDBContext())
            {
                return dbContext.Employees.ToList();
            }
        }

        /// <summary>
        /// Get EmployeeById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee Get(int id)
        {
            using (EmployeeDBContext dbContext = new EmployeeDBContext())
            {
                return dbContext.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
