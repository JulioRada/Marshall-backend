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
        public static List<Domain.Entities.Salary> CommandToListEntity(CreateSalaryCommand command)
        {
            
            var config = new MapperConfiguration(configure =>
            {
                
                configure.CreateMap<DetailSalaryCommand, Domain.Entities.Salary>()
                    .ForMember(d => d.Commission, o => o.MapFrom(s => s.Comission));
                configure.CreateMap<CreateSalaryCommand, Domain.Entities.Salary>();

            });
             
            var mapper = config.CreateMapper();

            var map = mapper.Map<List<Domain.Entities.Salary>>(command.detailSalary);

            map.ForEach(i =>
            {
                i.OfficeId = command.Office;
                i.EmployeeCode = command.EmployeeCode;
                i.EmployeeName = command.EmployeeName;
                i.EmployeeSurname = command.EmployeeSurname;
                i.DivisionId = command.Division;
                i.PositionId = command.Position;
                i.Grade = command.Grade;
                i.BeginDate = command.BeginDate;
                i.Birthday = command.Birthday;
                i.IdentificationNumber = command.IdentificationNumber;
            });

            return map;
        }
    }
}
