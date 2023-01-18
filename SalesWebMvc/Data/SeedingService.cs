using SalesWebMvc.Models.Enuns;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public  class SeedingService
    {
        private SalesWebMvcContext _context;



        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed() 
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been Seeded
            }
            
        }
    }
}
