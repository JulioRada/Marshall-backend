using Marshall.Application.AutoMapper;
using Marshall.Domain.DTO;
using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Application.Division
{
    public class DivisionQueries : IDivisionQueries
    {
        private readonly IDivisionRepository _divisionRepository;
        public DivisionQueries(IDivisionRepository divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }
        public async Task<IEnumerable<DivisionDTO>> GetAllAsync()
        {
            var result = await _divisionRepository.GetAllAsync();

            var office = Mapper<Marshall.Domain.Entities.Division, DivisionDTO>.EntityToDTO(result);
            return office;
        }
    }
    public interface IDivisionQueries
    {
        Task<IEnumerable<DivisionDTO>> GetAllAsync();
    }
}
