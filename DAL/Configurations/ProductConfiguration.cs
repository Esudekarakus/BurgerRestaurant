using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Products");
            builder.HasData(
                new Product { Id = 1, CategoryId=1, Name = "Meat Burger", Price = 100.00,MenuId=1},
                new Product { Id=2, CategoryId=1,Name="Chicken Burger", Price=85.00,MenuId = 2},
                new Product { Id=3,CategoryId=5,Name="Çilekli Milkshake",Price=30,MenuId=3}
                );

                
        }
    }
}
