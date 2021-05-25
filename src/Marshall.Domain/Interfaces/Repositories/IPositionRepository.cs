using Marshall.Core.Interfaces;
using Marshall.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Domain.Interfaces.Repositories
{
    public interface IPositionRepository : IRepository<Position>
    {
        Task<IEnumerable<Position>> GetAllAsync();
    }
}
