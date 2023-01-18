﻿using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;

namespace SalesWebMvc.Models.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }


       public List<Seller> FindAll()
            => _context.Seller.ToList();

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
            => _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);


        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        
    }
}
