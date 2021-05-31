using DelegateDecompiler;
using Marshall.Domain.Entities;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Infrastructure.Repositories
{
    public class SalaryRepository: BaseRepository<Salary>, ISalaryRepository
    {
        public SalaryRepository(MarshallContext context)
            : base(context)
        {
        }
        public void Add(List<Salary> entity) => entity.ForEach(i => { _marshallContext.Add(i); });

        public async Task<bool> ExistEmployeeAsync(string employeeName, string employeeSurname)
        {
            return await _marshallContext.Salary.AnyAsync(
                s => s.EmployeeName.Equals(employeeName) && s.EmployeeSurname.Equals(employeeSurname)
            );
        }
        public async Task<List<Salary>> GetSalaryByEmployeeCodeAsync(string employeeCode)
        {
            return await _marshallContext.Salary.AsNoTracking()
                    .Where(s => s.EmployeeCode == employeeCode).ToListAsync();   
        }
        public async Task<List<Salary>> GetSalaryByEmployeeCodeAsync(string employeeCode, int records)
        {
            var result = await _marshallContext.Salary.AsNoTracking()
                    .Include(s => s.Office)
                    .Include(s => s.Division)
                    .Include(s => s.Position)
                    .Where(s => s.EmployeeCode == employeeCode)
                    .Take(records)
                    .ToListAsync();

            return OrderSalary(result);
        }
        public async Task<IEnumerable<Salary>> GetAllAsync()
        {
            var result = await _marshallContext.Salary
                    .Include(s => s.Office)
                    .Include(s => s.Division)
                    .Include(s => s.Position)
                    .AsNoTracking()
                    .ToListAsync();

            return OrderSalary(result);
        }
        private List<Salary> OrderSalary(List<Salary> salary)
        {
            return salary
                    .Select(s => new Salary(s))
                    .OrderByDescending(s => s.Year)
                    .ThenByDescending(s => s.Month)
                    .ThenByDescending(s => s.EmployeeCode)
                    .ThenByDescending(s => s.EmployeeFullName)
                    .ThenByDescending(s => s.Division)
                    .ThenByDescending(s => s.Position)
                    .ThenByDescending(s => s.BeginDate)
                    .ThenByDescending(s => s.Birthday)
                    .ThenByDescending(s => s.IdentificationNumber)
                    .ToList();
        }
    }
}
