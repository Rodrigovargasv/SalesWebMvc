﻿using SalesWebMvc.Data;

namespace SalesWebMvc.Models.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }


        public List<Department> FindAll()
             => _context.Department.OrderBy(x => x.Name).ToList();  

       
    }
}