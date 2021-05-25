using Marshall.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Infrastructure.Seeds
{
    public static class OfficeBuilderExtension
    {
        public static void SeedOffice(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Office>()
               .HasData(
                   new Office { Id = 1, Name = "A" },
                   new Office { Id = 2, Name = "C" },
                   new Office { Id = 3, Name = "D" },
                   new Office { Id = 4, Name = "ZZ" }
               );
        }
    }
}
