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
            float baseSalary,
            float productionBonus,
            float compensationBonus,
            float commission,
            float contributions
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
            Commission = commission;
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
        public float BaseSalary { get; set; }
        public float ProductionBonus { get; set; }
        public float CompensationBonus { get; set; }
        public float Commission { get; set; }
        public float Contributions { get; set; }
    }
}
