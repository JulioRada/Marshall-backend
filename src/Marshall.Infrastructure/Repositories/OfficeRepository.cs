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
    public class OfficeRepository : BaseRepository<Office>, IOfficeRepository
    {
        public OfficeRepository(MarshallContext context)
            : base(context)
        {
        }

        public async Task<IEnumerable<Office>> GetAllAsync()
        {
            var result = await _marshallContext.Office.AsNoTracking().ToListAsync();
            return result;
        }
    }
}
