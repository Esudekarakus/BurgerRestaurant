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
    public class BeverageConfiguration : IEntityTypeConfiguration<Beverage>
    {
        public void Configure(EntityTypeBuilder<Beverage> builder)
        {
            builder.HasData(
                new Beverage{
                    Id = 1,
                    Name = "Cola",
                    Price = 35
                },
                new Beverage{
                    Id = 2,
                    Name = "Ayran",
                    Price = 25
                }
            );
        }
    }
}