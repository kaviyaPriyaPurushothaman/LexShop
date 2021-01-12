using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LexShop.Core.Models;

namespace LexShop.DataAccessSQL
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories{ get; set; }

    }
}
