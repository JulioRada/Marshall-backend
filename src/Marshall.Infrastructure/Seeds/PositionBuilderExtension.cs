using Marshall.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Infrastructure.Seeds
{
    public static class PositionBuilderExtension
    {
        public static void SeedPosition(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>()
                .HasData(
                    new Position { Id = 1, Name = "Cargo manager" },
                    new Position { Id = 2, Name = "Head manager" },
                    new Position { Id = 3, Name = "Cargo assistant" },
                    new Position { Id = 4, Name = "Sales manager" },
                    new Position { Id = 5, Name = "Account executive" },
                    new Position { Id = 6, Name = "Marketing assistant" },
                    new Position { Id = 7, Name = "Customer director" },
                    new Position { Id = 8, Name = "Customer assistant" }
                );
        }
    }
}
