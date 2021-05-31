using Marshall.Core.DTO;
using Marshall.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Domain.DTO
{
    public class SalaryDTO : BaseDTO
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public virtual OfficeDTO Office { get; private set; }
        public string EmployeeCode { get; set; }
        public virtual DivisionDTO Division { get; private set; }
        public virtual PositionDTO Position { get; private set; }
        public int Grade { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }

        public double TotalSalary { get; private set; }
        public string EmployeeFullName { get; private set; }
    }
}