using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCLearning.Models;

namespace MVCLearning.BusinessLayer
{
    public class EmployeeBL
    {
        public List<Employee> GetEmployees()
        {
           return new EmployeeEntityModel().Employees.ToList();
        }
        public void SaveEmployee(Employee e)
        {
            EmployeeEntityModel emodel = new EmployeeEntityModel();
            emodel.Employees.Add(e);emodel.SaveChanges();

        }
    }
}