using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelintecApp.Data;
using TelintecApp.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TelintecApp.Controllers

    {
        public class DepartmentsController : Controller
        {
            private readonly AppDbContext _context;

            public DepartmentsController(AppDbContext context)
            {
                _context = context;
            }

        public IActionResult Index(string searchString = "")
        {
            List<Department> Departments;
            if (searchString != "" && searchString != null)
            {
                Departments = _context.Departments.Where(p => p.DepartmentName.Contains(searchString)).ToList();
                return View(Departments);

            }
            else
            {
                Departments = _context.Departments.ToList();
                return View(Departments);

            }
        }
        }
    }

