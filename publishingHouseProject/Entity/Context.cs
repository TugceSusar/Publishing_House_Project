using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace publishingHouseProject.Entity
{
    public class Context : DbContext
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<SubOffice> Suboffice { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public Context(): base("Context"){ }

       
    }
}
