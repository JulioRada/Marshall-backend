using AutoMapper;
using Marshall.Core.Commands;
using Marshall.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Application.AutoMapper
{
    public static class Mapper<TEntity, TDTO>
        where TEntity : Entity
        where TDTO : BaseDTO
    {

        public static TDTO EntityToDTO(TEntity entity)
        {
            var config = new MapperConfiguration(c => c.CreateMap<TEntity, TDTO>());

            var mapper = config.CreateMapper();
            return mapper.Map<TDTO>(entity);
        }
        public static IEnumerable<TDTO> EntityToDTO(IEnumerable<TEntity> entity)
        {
            var config = new MapperConfiguration(c => c.CreateMap<TEntity, TDTO>());

            var mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<TDTO>>(entity);
        }
    }
}
