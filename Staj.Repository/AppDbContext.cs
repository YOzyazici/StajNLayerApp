using Microsoft.EntityFrameworkCore;
using Staj.Core.Entities;
using Staj.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Staj.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //var p = new Product() { ProductFeature = new ProductFeature() };
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //tek bir tanesine configuration uygulamak için
            //modelbuilder.ApplyConfiguration(new ProductConfiguration());

            modelbuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                ID=1,
                Color="Kırmızı",
                Height=100,
                Width=100,
                ProductID=1,
            },new ProductFeature()
            {
                ID=2,
                Color="Mavi",
                Height=200,
                Width=200,
                ProductID=2,
            });

            base.OnModelCreating(modelbuilder);
        }
    }
}
