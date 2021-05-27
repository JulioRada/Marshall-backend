using Marshall.Core.Interfaces;
using Marshall.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marshall.Domain.Interfaces.Repositories
{
    public interface ISalaryRepository : IRepository<Salary>
    {
        public void Add(List<Salary> entity);

        public Task<bool> ExistEmployeeAsync(string employeeName, string employeeSurname);
    }
}
