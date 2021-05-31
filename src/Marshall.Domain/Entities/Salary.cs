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
        public Salary(Salary salary)
        {
            Id = salary.Id;
            Year = salary.Year;
            Month = salary.Month;
            OfficeId = salary.OfficeId;
            Office = salary.Office;
            EmployeeCode = salary.EmployeeCode;
            EmployeeName = salary.EmployeeName;
            EmployeeSurname = salary.EmployeeSurname;
            DivisionId = salary.DivisionId;
            Division = salary.Division;
            PositionId = salary.PositionId;
            Position = salary.Position;
            Grade = salary.Grade;
            BeginDate = salary.BeginDate;
            Birthday = salary.Birthday;
            IdentificationNumber = salary.IdentificationNumber;
            BaseSalary = salary.BaseSalary;
            ProductionBonus = salary.ProductionBonus;
            CompensationBonus = salary.CompensationBonus;
            Comission = salary.Comission;
            Contributions = salary.Contributions;
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int OfficeId { get; set; }
        public virtual Office Office { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int DivisionId { get; set; }
        public virtual Division Division { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public int Grade { get; set; }
        [DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public double BaseSalary { get; set; }
        public double ProductionBonus { get; set; }
        public double CompensationBonus { get; set; }
        public double Comission { get; set; }
        public double Contributions { get; set; }
        
        [NotMapped]
        public double TotalSalary
        {
            get
            {
                // Other Income = (Base Salary + Commission) *8 % +Commission
                double salaryComission = BaseSalary + Comission;

                double otherIncome = (salaryComission) * ((8 / 100) * salaryComission) + Comission;
                // Total Salary = Base Salary + Production Bonus + (Compensation Bonus * 75%) + Other Income - Contributions
                return BaseSalary + ProductionBonus + (CompensationBonus * ((75 / 100) * CompensationBonus)) + otherIncome - Contributions;
            }
        }

        [NotMapped]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string EmployeeFullName
        {
            get { return EmployeeName + " " + EmployeeSurname; }
        }
    }
}
