﻿using SalesWebMvc.Data;

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
       
    }
}