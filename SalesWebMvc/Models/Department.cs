namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
           
        }

        public void AddSales(Seller seller)
           => sellers.Add(seller);

        public double TotalSales(DateTime initial, DateTime final)
           => sellers.Sum(seller => seller.TotalSales(initial, final));
    }
}
