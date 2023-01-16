﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Jogos"});
            list.Add(new Department { Id = 2, Name = "Financeiro" });

            return View(list);
        }
    }
}
