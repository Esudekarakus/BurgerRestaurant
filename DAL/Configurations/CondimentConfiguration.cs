using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class CondimentConfiguration : IEntityTypeConfiguration<Condiment>
    {
        public void Configure(EntityTypeBuilder<Condiment> builder)
        {
            builder.HasData(
                new Condiment{
                    Id = 1,
                    Name = "Ketcap",
                    Price = 4
                },
                new Condiment{
                    Id = 2,
                    Name = "Mayonez",
                    Price = 4
                }
            );
        }
    }
}