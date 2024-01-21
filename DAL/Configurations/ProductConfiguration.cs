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
                new Product { Id=1, CategoryId=4, Name = "Gurme Patates", Price = 100.00, ImagePath = "GuncelResimler/patates1.png" },
                new Product { Id=2, CategoryId=4,Name="Gurme Soğan Halkası", Price=85.00, ImagePath = "GuncelResimler/onion.png" },
                new Product { Id=3,CategoryId=4,Name="Gurme Nugget",Price=30, ImagePath = "GuncelResimler/Nugget1.png" },
                new Product { Id=4, CategoryId=5, Name="Sufle", Price=25, ImagePath= "GuncelResimler/sufle.png" },
                new Product { Id = 5, CategoryId = 5, Name = "Çilekli Dondurma", Price = 20, ImagePath = "GuncelResimler/Sundae1.png" },
                 new Product { Id = 6, CategoryId = 5, Name = "Elmalı Çıtır", Price = 20, ImagePath = "GuncelResimler/tatlıelma.png" }
                );

                
        }
    }
}
