using ECommerce.DAL.Configurations;
using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DAL.Context
{
    public class EcommerceContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {

        public EcommerceContext(DbContextOptions<EcommerceContext> options):base(options) { }
        

        //DbSets

        //Category DbSet
        public DbSet<Category> Categories { get; set; }

        //Product DbSet
        public DbSet<Product> Products { get; set; }

        //SupplierDbSet
        public DbSet<Supplier> Suppliers { get; set; }

        //Order DbSet

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }









        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseSqlServer("server=DESKTOP-J4PTH70;database=Yzl3172Project;uid=sa;pwd=123;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //CategoryConfiguration
            builder.ApplyConfiguration(new CategoryConfiguration());
            //ProductConfiguration
            builder.ApplyConfiguration(new ProductConfiguration());
            //SupplierConfiguration
            builder.ApplyConfiguration(new SupplierConfiguration());
            //OrderConfiguration
            builder.ApplyConfiguration(new OrderConfiguration());
            //OrderDetailConfiguration

            builder.ApplyConfiguration(new OrderDetailConfiguration());
         


            base.OnModelCreating(builder);
        }
    }
}
