using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment6Mock.Models;
using Assessment6Mock.Context;
using Assessment6Mock.Views.Home;
using Microsoft.EntityFrameworkCore;

namespace Assessment6Mock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeDbContext _db;

        public HomeController(EmployeeDbContext db, ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Employee()
        {
            IEnumerable<Employee> objList = _db.Employee;
            return View(objList);
        }

        [HttpPost]
        public IActionResult Employee(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Employee.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

       //GET - RetirementInfo(edit)
        public async Task<IActionResult> RetirementInfo(int? employeeId)
        {
            var employee = await _db.Employee.FirstOrDefaultAsync(m => m.Id == employeeId);
            var retirementInfo = new RetirementInfo()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                Age = employee.Age,
                Salary = employee.Salary
            };

            if (retirementInfo.Age > 60)
            {
                ViewBag.CanRetire = "Can Retire";
                ViewBag.Benefits = Decimal.Multiply(retirementInfo.Salary, (decimal)0.6);
            }
            else
            {
                ViewBag.CanRetire = false;
                ViewBag.Benefits = Decimal.Zero;
            }          
            return View(retirementInfo);
        }
           
          

            public IActionResult Privacy()
        {
            return View();
        }

     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
