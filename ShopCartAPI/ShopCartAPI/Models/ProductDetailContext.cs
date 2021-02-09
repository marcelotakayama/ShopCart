using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCartAPI.Models {
    public class ProductDetailContext : DbContext {
        public ProductDetailContext(DbContextOptions<ProductDetailContext> options):base(options) {

        }

        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
