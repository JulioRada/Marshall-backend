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
        Task<Salary> SaveAsync();
    }
}
