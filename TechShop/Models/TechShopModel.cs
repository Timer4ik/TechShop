 using System;
using System.Data.Entity;
using System.Linq;

namespace TechShop.Models
{
    public class TechShopModel : DbContext
    {
        public TechShopModel()
            : base("name=TechShopModel")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }
        public virtual DbSet<ComputerComponent> ComputerComponents { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}