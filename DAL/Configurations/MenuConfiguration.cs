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
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menus");
            builder.HasKey(x => x.Id);

          

            builder.HasData(
                    new Menu { Id = 1, Name = "Meat Burger", Price = 100.00, ImagePath = "img/burgers/hamburger1kofte.png" },
                    new Menu { Id = 2, Name = "Chicken Burger", Price = 85.00, ImagePath = "img/burgers/chickenburger.png" },
                    new Menu { Id = 3, Name = "Çilekli Milkshake", Price = 30, ImagePath = "img/beverages/milkshake.jpg" }
                );
        }
    }
}
