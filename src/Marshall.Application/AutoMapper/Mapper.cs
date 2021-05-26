using AutoMapper;
using Marshall.Core.Commands;
using Marshall.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Application.AutoMapper
{
    public static class Mapper<TEntity, TCommand>
        where TEntity : Entity
        where TCommand : CommandBase
    {

        public static TCommand EntityToDTO(TEntity entity)
        {
            var config = new MapperConfiguration(c => c.CreateMap<TEntity, TCommand>());

            var mapper = config.CreateMapper();
            return mapper.Map<TCommand>(entity);
        }
        public static IEnumerable<TCommand> EntityToDTO(IEnumerable<TEntity> entity)
        {
            var config = new MapperConfiguration(c => c.CreateMap<TEntity, TCommand>());

            var mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<TCommand>>(entity);
        }
    }
}
