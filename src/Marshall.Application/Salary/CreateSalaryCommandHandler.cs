﻿using System;
using System.Collections.Generic;
using System.Text;
using Marshall.Core.Commands;
using Marshall.Core.Interfaces;
using Marshall.Domain.Commands.Salary;
using FluentValidation;
using Marshall.Domain.Interfaces.Repositories;
using Marshall.Application.AutoMapper;

namespace Marshall.Application.Salary
{
    public class CreateSalaryCommandHandler : CommandHandlerBase, ICommandHandler<CreateSalaryCommand>
    {

        
        private readonly IValidator<CreateSalaryCommand> _createSalaryCommandValidator;
        private readonly ISalaryRepository _salaryRepository;

        public CreateSalaryCommandHandler(
            IValidator<CreateSalaryCommand> salaryCommandValidator,
            ISalaryRepository salaryRepository
            )
        {
            _createSalaryCommandValidator = salaryCommandValidator;
            _salaryRepository = salaryRepository;
        }

        public Result Handle(CreateSalaryCommand command)
        {
            var validationResult = Validate(command, _createSalaryCommandValidator);

            if (validationResult.IsValid)
            {
                var listSalary = SalaryMapper.CommandToListEntity(command);
   
                _salaryRepository.Add(listSalary);
                _salaryRepository.SaveChanges();
            }

            return Return();
        }
    }
}
