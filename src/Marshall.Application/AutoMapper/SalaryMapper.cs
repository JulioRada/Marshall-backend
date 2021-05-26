using AutoMapper;
using Marshall.Domain.Commands.Salary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Application.AutoMapper
{
    public static class SalaryMapper
    {
        public static Domain.Entities.Salary CommandToEntity(CreateSalaryCommand command)
        {
            var config = new MapperConfiguration(configure =>
            {
                configure.CreateMap<CreateSalaryCommand, Domain.Entities.Salary>();
            });

            var mapper = config.CreateMapper();
            return mapper.Map<Domain.Entities.Salary>(command);
        }
    }
}
