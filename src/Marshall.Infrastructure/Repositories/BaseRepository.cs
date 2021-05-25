using Marshall.Core.Entity;
using Marshall.Core.Interfaces;
using Marshall.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : IEntity
    {
        protected readonly MarshallContext _marshallContext;

        public BaseRepository(MarshallContext sampleLibraryContext)
        {
            _marshallContext = sampleLibraryContext;
        }

        public int SaveChanges() => _marshallContext.SaveChangesAsync().Result;

        public void Add(T entity) => _marshallContext.Add(entity);

        public void Dispose()
        {
            _marshallContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
