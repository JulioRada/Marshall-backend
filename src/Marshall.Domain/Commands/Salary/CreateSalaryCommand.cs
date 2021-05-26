using System;
using System.Collections.Generic;
using System.Text;
using Marshall.Core.Commands;

namespace Marshall.Domain.Commands.Salary
{
    public class CreateSalaryCommand: CommandBase
    {
        public int OfficeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int DivisionId { get; set; }
        public int PositionId { get; set; }
        public int Grade { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public List<DetailSalary> detailSalary { get; set; }
        
    }
    public class DetailSalary {
        public int Year { get; set; }
        public int Month { get; set; }
        public double BaseSalary { get; set; }
        public double ProductionBonus { get; set; }
        public double CompensationBonus { get; set; }
        public double Commission { get; set; }
        public double Contributions { get; set; }
    }
}
