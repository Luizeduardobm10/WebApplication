using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
namespace WebApplication.Controllers
{
    public class DepartmentsController1 : Controller
    {
        public IActionResult Index()
        {
            List<Department> lista = new List<Department>();
            lista.Add(new Department { Id = 1, Name = "Computação" });
            lista.Add(new Department { Id = 2, Name = "Eletrônica" });

            return View(lista);
        }
    }
}
