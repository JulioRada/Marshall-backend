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
    public class DivisionRepository : BaseRepository<Division>, IDivisionRepository
    {
        public DivisionRepository(MarshallContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Division>> GetAllAsync()
        {
            var result = await _marshallContext.Division.AsNoTracking().ToListAsync();
            return result;
        }
    }
}
