using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLearning.ViewModels;
using MVCLearning.Models;
using MVCLearning.BusinessLayer;

namespace MVCLearning.Controllers.Employees
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            EmployeesList employees = new EmployeesList();
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();
            foreach (Employee em in new EmployeeBL().GetEmployees())
            { 
                employeeViewModels.Add(new EmployeeViewModel {Email=em.Email,FullName=em.FirstName+em.LastName});
            }
            employees.Employees = employeeViewModels;
            employees.UserName = "";
            return View("Details",employees);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new EmployeeBL().SaveEmployee(employee);
                    return RedirectToAction("Details");
                    
                }
                else
                {
                    return View("Create");
                }
               
            }
            catch(Exception e)
            {
                ModelState.AddModelError("error", e.Message);
                return View("Create");
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
