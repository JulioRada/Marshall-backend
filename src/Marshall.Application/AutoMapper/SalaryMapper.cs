﻿using AutoMapper;
using Marshall.Domain.Commands.Salary;
using Marshall.Domain.DTO;
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
                .ForMember(s => s.PositionId, o => o.MapFrom(s => s.Position ))
                .ForMember(s => s.DivisionId, o => o.MapFrom(s => s.Division ))
                .ForMember(s => s.OfficeId, o => o.MapFrom(s => s.Office ))
                .ForMember(s => s.Position, o => o.Ignore())
                .ForMember(s => s.Division, o => o.Ignore())
                .ForMember(s => s.Office, o => o.Ignore());
            });
             
            var mapper = config.CreateMapper();

            var map = mapper.Map<List<Domain.Entities.Salary>>(command.detailSalary);

            map.ForEach(i =>
            {
                i.EmployeeCode = command.EmployeeCode;
                i.EmployeeName = command.EmployeeName;
                i.EmployeeSurname = command.EmployeeSurname;
                i.BeginDate = command.BeginDate;
                i.Birthday = command.Birthday;
                i.IdentificationNumber = command.IdentificationNumber;
            });

            return map;
        }
        public static IEnumerable<SalaryDTO> EntityToDTO2(IEnumerable<Domain.Entities.Salary> entity)
        {
            var  config = new MapperConfiguration(c => 
                c.CreateMap<Domain.Entities.Salary, SalaryDTO>()
            );
                    
            var mapper = config.CreateMapper();

            return mapper.Map<IEnumerable<SalaryDTO>>(entity);
        }
        public static IEnumerable<SalaryDTO> EntityToDTO(IEnumerable<Domain.Entities.Salary> entity)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Domain.Entities.Salary, SalaryDTO>();
                c.CreateMap<Domain.Entities.Office, OfficeDTO>();
                c.CreateMap<Domain.Entities.Division, DivisionDTO>();
                c.CreateMap<Domain.Entities.Position, PositionDTO>();
            });

            var mapper = config.CreateMapper();
            
            return mapper.Map<IEnumerable<SalaryDTO>>(entity);
        }
    }
}
