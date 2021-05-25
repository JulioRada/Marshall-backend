using Marshall.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Core.Interfaces
{
    public interface IRepository<in T> : IDisposable where T : IEntity
    {
        int SaveChanges();
        void Add(T entity);
    }
}
