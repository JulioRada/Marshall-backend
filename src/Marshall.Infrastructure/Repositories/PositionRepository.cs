using Marshall.Domain.Entities;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Infrastructure.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(MarshallContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Position>> GetAllAsync()
        {
            var result = await _marshallContext.Position.AsNoTracking().ToListAsync();
            return result;
        }
    }
}
