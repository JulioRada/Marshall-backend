using Marshall.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Infrastructure.Seeds
{
    public static class SalaryBuilderExtension
    {
        public static void SeedSalary(this ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Salary>()
                .HasData(
                    new Salary { Id = 1, Name = "Cargo manager" },
                    new Salary { Id = 2, Name = "Head manager" },
                    new Salary { Id = 3, Name = "Cargo assistant" },
                    new Salary { Id = 4, Name = "Sales manager" },
                    new Salary { Id = 5, Name = "Account executive" },
                    new Salary { Id = 6, Name = "Marketing assistant" },
                    new Salary { Id = 7, Name = "Customer director" },
                    new Salary { Id = 8, Name = "Customer assistant" }
                );*/
        }
    }
}
