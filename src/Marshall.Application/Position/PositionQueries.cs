using Marshall.Application.AutoMapper;
using Marshall.Domain.DTO;
using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Application.Position
{
    public class PositionQueries : IPositionQueries
    {
        private readonly IPositionRepository _positionRepository;

        /*
        public async Task<IEnumerable<OfficeDTO>> GetAllAsync()
        {
            var result = await _officeRepository.GetAllAsync();

            var office = Mapper<Marshall.Domain.Entities.Office, OfficeDTO>.EntityToDTO(result);
            return office;
        }*/
        public PositionQueries(IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }
        public async Task<IEnumerable<PositionDTO>> GetAllAsync()
        {
            var result = await  _positionRepository.GetAllAsync();

            var position = Mapper<Marshall.Domain.Entities.Position, PositionDTO>.EntityToDTO(result);
            return position;
        }
    }
    public interface IPositionQueries
    {
        Task<IEnumerable<PositionDTO>> GetAllAsync();
    }
}
