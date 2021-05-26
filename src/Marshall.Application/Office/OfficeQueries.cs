using Marshall.Application.AutoMapper;
using Marshall.Domain.DTO;
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
        public async Task<IEnumerable<OfficeDTO>> GetAllAsync()
        {
            var result = await _officeRepository.GetAllAsync();
            
            var office = Mapper<Marshall.Domain.Entities.Office, OfficeDTO>.EntityToDTO(result);
            return office;
        }
    }
    public interface IOfficeQueries
    {
        Task<IEnumerable<OfficeDTO>> GetAllAsync();
    }
}
