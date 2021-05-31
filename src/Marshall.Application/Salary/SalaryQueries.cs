using Marshall.Application.AutoMapper;
using Marshall.Domain.DTO;
using Marshall.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Application.Salary
{
    public class SalaryQueries : ISalaryQueries
    {
        private readonly ISalaryRepository _salaryRepository;

        public SalaryQueries(ISalaryRepository positionRepository)
        {
            _salaryRepository = positionRepository;
        }
        public async Task<IEnumerable<SalaryDTO>> GetAllAsync()
        {
            var result = await _salaryRepository.GetAllAsync();

            var salary = SalaryMapper.EntityToDTO(result);
            return salary;
        }
        public async Task<IEnumerable<SalaryDTO>> GetSalaryByEmployeeCodeAsync(string employeeCode, int records)
        {
            var result = await _salaryRepository.GetSalaryByEmployeeCodeAsync(employeeCode, records);

            var salary = SalaryMapper.EntityToDTO(result);

            return salary;
        }
    }
    public interface ISalaryQueries
    {
        Task<IEnumerable<SalaryDTO>> GetAllAsync();
        Task<IEnumerable<SalaryDTO>> GetSalaryByEmployeeCodeAsync(string employeeCode, int records);
    }
}