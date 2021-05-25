using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Application.Office
{
    public class OfficeQueries : IOfficeQueries
    {
        private readonly IOfficeRepository _officeRepository;
        public OfficeQueries(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }
        public async Task<IEnumerable<Marshall.Domain.Entities.Office>> GetAllAsync()
        {
            return await _officeRepository.GetAllAsync();
        }
    }
    public interface IOfficeQueries
    {
        Task<IEnumerable<Marshall.Domain.Entities.Office>> GetAllAsync();
    }
}
