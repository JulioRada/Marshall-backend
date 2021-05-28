using Marshall.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Marshall.Domain.Entities
{
    public class Salary : Entity
    {
        public Salary()
        {
        }
        public Salary(
            int year,
            int month,
            int officeId,
            string employeeCode,
            string employeeName,
            string employeeSurname,
            int divisionId,
            int positionId,
            int grade,
            DateTime beginDate,
            DateTime birthday,
            string identificationNumber,
            double baseSalary,
            double productionBonus,
            double compensationBonus,
            double Comission,
            double contributions
        )
        {
            Year = year;
            Month = month;
            OfficeId = officeId;
            EmployeeCode = employeeCode;
            EmployeeName = employeeName;
            EmployeeSurname = employeeSurname;
            DivisionId = divisionId;
            PositionId = positionId;
            Grade = grade;
            BeginDate = beginDate;
            Birthday = birthday;
            IdentificationNumber = identificationNumber;
            BaseSalary = baseSalary;
            ProductionBonus = productionBonus;
            CompensationBonus = compensationBonus;
            Comission = Comission;
            Contributions = contributions;
        }
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int OfficeId { get; set; }
        public virtual Office Office { get; private set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int DivisionId { get; set; }
        public virtual Division Division { get; private set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; private set; }
        public int Grade { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public double BaseSalary { get; set; }
        public double ProductionBonus { get; set; }
        public double CompensationBonus { get; set; }
        public double Comission { get; set; }
        public double Contributions { get; set; }
    }
}
