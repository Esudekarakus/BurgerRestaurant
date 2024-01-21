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
                new Product { Id=1, CategoryId=4, Name = "Gurme Patates", Price = 100.00, ImagePath = "img/GuncelResimler/patates1.png" },
                new Product { Id=2, CategoryId=4,Name="Gurme Soğan Halkası", Price=85.00, ImagePath = "img/GuncelResimler/onion.png" },
                new Product { Id=3,CategoryId=4,Name="Gurme Nugget",Price=30, ImagePath = "img/GuncelResimler/Nugget1.png" }
                );

                
        }
    }
}
