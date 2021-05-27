using System;
using System.Collections.Generic;
using System.Text;
using Marshall.Core.Commands;

namespace Marshall.Domain.Commands.Salary
{
    public class CreateSalaryCommand: CommandBase
    {
        public int Office { get; set; }
        public string EmployeeCode { get; set; }
        protected string _employeeName;
        public string EmployeeName { 
            get { return this._employeeName;  } 
            set { this._employeeName = (value == null ? value : value.Trim().ToUpper()); } 
        }
        protected string _employeeSurname;
        public string EmployeeSurname
        {
            get { return this._employeeSurname; }
            set { this._employeeSurname = (value == null ? value : value.Trim().ToUpper()); }
        }
        public int Division { get; set; }
        public int Position { get; set; }
        public int Grade { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public List<DetailSalaryCommand> detailSalary { get; set; }
        
    }
    public class DetailSalaryCommand {
        public int Year { get; set; }
        public int Month { get; set; }
        public double BaseSalary { get; set; }
        public double ProductionBonus { get; set; }
        public double CompensationBonus { get; set; }
        public double Comission { get; set; }
        public double Contributions { get; set; }
    }
}
