using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class BurgerConfiguration : IEntityTypeConfiguration<Burger>
    {
        public void Configure(EntityTypeBuilder<Burger> builder)
        {
            builder.HasData(
                
                new Burger{
                    Id = 1,
                    Name = "BigKing",
                    Price = 142,
                    ImagePath = "https://images.app.goo.gl/CNJmYmziEcGkdYp87"
                },
                new Burger{
                    Id = 2,
                    Name = "BigChicken",
                    Price = 127,
                    ImagePath = "https://images.app.goo.gl/wb6RjiudG6SvjNgL6"
                }
            );
        }
    }
}