using Marshall.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Infrastructure.Seeds
{
    public static class DivisionBuilderExtension
    {
        public static void SeedDivision(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>()
                .HasData(
                    new Division { Id = 1, Name = "Operation" },
                    new Division { Id = 2, Name = "Sales" },
                    new Division { Id = 3, Name = "Marketing" },
                    new Division { Id = 4, Name = "Customer care" }
                );
        }
    }
}
