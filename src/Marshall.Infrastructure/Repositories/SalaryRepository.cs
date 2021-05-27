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
    }
}
