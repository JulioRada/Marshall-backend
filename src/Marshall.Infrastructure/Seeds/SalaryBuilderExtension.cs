using Marshall.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marshall.Infrastructure.Seeds
{
    public static class SalaryBuilderExtension
    {
        public static void SeedSalary(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salary>()
                .HasData(
                    /* 1 */ new Salary { Id = 1, Year = 2020, Month = 10, OfficeId = 2, EmployeeCode = "10001222", EmployeeName = "Mike", EmployeeSurname = "James", DivisionId = 1, PositionId = 1, Grade = 18, BeginDate = new DateTime(2020, 5, 11), Birthday = new DateTime(1990, 3, 15), IdentificationNumber = "4564132", BaseSalary = 2799.45, ProductionBonus = 50.5, CompensationBonus = 3215.63, Commission = 0, Contributions = 1000 },
                    /* 2 */ new Salary { Id = 2, Year = 2020, Month = 9, OfficeId = 2, EmployeeCode = "10001222", EmployeeName = "Mike", EmployeeSurname = "James", DivisionId = 1, PositionId = 1, Grade = 18, BeginDate = new DateTime(2020, 5, 11), Birthday = new DateTime(1990, 3, 15), IdentificationNumber = "4564132", BaseSalary = 2799.45, ProductionBonus = 50.5, CompensationBonus = 3263.99, Commission = 0, Contributions = 1000 },
                    /* 3 */ new Salary { Id = 3, Year = 2020, Month = 8, OfficeId = 3, EmployeeCode = "10001222", EmployeeName = "Mike", EmployeeSurname = "James", DivisionId = 1, PositionId = 2, Grade = 12, BeginDate = new DateTime(2020, 5, 11), Birthday = new DateTime(1990, 3, 15), IdentificationNumber = "4564132", BaseSalary = 2799.45, ProductionBonus = 50.5, CompensationBonus = 998.45, Commission = 0, Contributions = 600 },
                    /* 4 */ new Salary { Id = 4, Year = 2020, Month = 7, OfficeId = 3, EmployeeCode = "10001222", EmployeeName = "Mike", EmployeeSurname = "James", DivisionId = 1, PositionId = 2, Grade = 12, BeginDate = new DateTime(2020, 5, 11), Birthday = new DateTime(1990, 3, 15), IdentificationNumber = "4564132", BaseSalary = 2799.45, ProductionBonus = 50.5, CompensationBonus = 998.45, Commission = 0, Contributions = 600 },
                    /* 5 */ new Salary { Id = 5, Year = 2020, Month = 6, OfficeId = 1, EmployeeCode = "10001222", EmployeeName = "Mike", EmployeeSurname = "James", DivisionId = 1, PositionId = 3, Grade = 6, BeginDate = new DateTime(2020, 5, 11), Birthday = new DateTime(1990, 3, 15), IdentificationNumber = "4564132", BaseSalary = 2799.45, ProductionBonus = 2000, CompensationBonus = 1500, Commission = 4500, Contributions = 1450 },
                    /* 6 */ new Salary { Id = 6, Year = 2020, Month = 5, OfficeId = 1, EmployeeCode = "10001222", EmployeeName = "Mike", EmployeeSurname = "James", DivisionId = 1, PositionId = 3, Grade = 6, BeginDate = new DateTime(2020, 5, 11), Birthday = new DateTime(1990, 3, 15), IdentificationNumber = "4564132", BaseSalary = 2799.45, ProductionBonus = 1800, CompensationBonus = 1500, Commission = 5000, Contributions = 1600 },
                    /* 7 */ new Salary { Id = 7, Year = 2020, Month = 10, OfficeId = 4, EmployeeCode = "10023001", EmployeeName = "Kali", EmployeeSurname = "Prasad", DivisionId = 2, PositionId = 4, Grade = 18, BeginDate = new DateTime(2020, 9, 9), Birthday = new DateTime(1980, 1, 25), IdentificationNumber = "14598756", BaseSalary = 2995, ProductionBonus = 3000, CompensationBonus = 3200, Commission = 0, Contributions = 2100 },
                    /* 8 */ new Salary { Id = 8, Year = 2020, Month = 9, OfficeId = 4, EmployeeCode = "10023001", EmployeeName = "Kali", EmployeeSurname = "Prasad", DivisionId = 2, PositionId = 4, Grade = 18, BeginDate = new DateTime(2020, 9, 9), Birthday = new DateTime(1980, 1, 25), IdentificationNumber = "14598756", BaseSalary = 2995, ProductionBonus = 3200, CompensationBonus = 3200, Commission = 0, Contributions = 2340 },
                    /* 9 */ new Salary { Id = 9, Year = 2020, Month = 10, OfficeId = 4, EmployeeCode = "10023001", EmployeeName = "Jane", EmployeeSurname = "Doe", DivisionId = 2, PositionId = 5, Grade = 12, BeginDate = new DateTime(2020, 10, 10), Birthday = new DateTime(1978, 11, 18), IdentificationNumber = "1989863", BaseSalary = 3000, ProductionBonus = 4000, CompensationBonus = 0, Commission = 0, Contributions = 600 },
                    /* 10 */ new Salary { Id = 10, Year = 2020, Month = 7, OfficeId = 4, EmployeeCode = "10023001", EmployeeName = "Jane", EmployeeSurname = "Doe", DivisionId = 2, PositionId = 5, Grade = 12, BeginDate = new DateTime(2020, 5, 2), Birthday = new DateTime(1978, 11, 18), IdentificationNumber = "1989863", BaseSalary = 2799.45, ProductionBonus = 3950, CompensationBonus = 2365.74, Commission = 0, Contributions = 600 },
                    /* 11 */ new Salary { Id = 11, Year = 2020, Month = 6, OfficeId = 4, EmployeeCode = "10023001", EmployeeName = "Jane", EmployeeSurname = "Doe", DivisionId = 3, PositionId = 6, Grade = 11, BeginDate = new DateTime(2020, 5, 2), Birthday = new DateTime(1978, 11, 18), IdentificationNumber = "1989863", BaseSalary = 2799.45, ProductionBonus = 2666, CompensationBonus = 2365.74, Commission = 0, Contributions = 0 },
                    /* 12 */ new Salary { Id = 12, Year = 2020, Month = 5, OfficeId = 4, EmployeeCode = "10023001", EmployeeName = "Jane", EmployeeSurname = "Doe", DivisionId = 3, PositionId = 6, Grade = 11, BeginDate = new DateTime(2020, 5, 2), Birthday = new DateTime(1978, 11, 18), IdentificationNumber = "1989863", BaseSalary = 2799.45, ProductionBonus = 2666, CompensationBonus = 2365.74, Commission = 0, Contributions = 0 },
                    /* 13 */ new Salary { Id = 13, Year = 2020, Month = 10, OfficeId = 3, EmployeeCode = "10001001", EmployeeName = "Ann", EmployeeSurname = "Whitaker", DivisionId = 4, PositionId = 7, Grade = 18, BeginDate = new DateTime(2020, 5, 16), Birthday = new DateTime(1992, 6, 21), IdentificationNumber = "8563217", BaseSalary = 5000, ProductionBonus = 0, CompensationBonus = 3200, Commission = 2478.96, Contributions = 1000 },
                    /* 14 */ new Salary { Id = 14, Year = 2020, Month = 9, OfficeId = 3, EmployeeCode = "10001001", EmployeeName = "Ann", EmployeeSurname = "Whitaker", DivisionId = 4, PositionId = 7, Grade = 18, BeginDate = new DateTime(2020, 5, 16), Birthday = new DateTime(1992, 6, 21), IdentificationNumber = "8563217", BaseSalary = 5000, ProductionBonus = 0, CompensationBonus = 3200, Commission = 2677.88, Contributions = 1000 },
                    /* 15 */ new Salary { Id = 15, Year = 2020, Month = 8, OfficeId = 3, EmployeeCode = "10001001", EmployeeName = "Ann", EmployeeSurname = "Whitaker", DivisionId = 4, PositionId = 7, Grade = 14, BeginDate = new DateTime(2020, 5, 16), Birthday = new DateTime(1992, 6, 21), IdentificationNumber = "8563217", BaseSalary = 3200, ProductionBonus = 0, CompensationBonus = 998.45, Commission = 1845.66, Contributions = 600 },
                    /* 16 */ new Salary { Id = 16, Year = 2020, Month = 7, OfficeId = 3, EmployeeCode = "10001001", EmployeeName = "Ann", EmployeeSurname = "Whitaker", DivisionId = 4, PositionId = 7, Grade = 14, BeginDate = new DateTime(2020, 5, 16), Birthday = new DateTime(1992, 6, 21), IdentificationNumber = "8563217", BaseSalary = 2799.45, ProductionBonus = 0, CompensationBonus = 998.45, Commission = 1944.22, Contributions = 600 },
                    /* 17 */ new Salary { Id = 17, Year = 2020, Month = 6, OfficeId = 1, EmployeeCode = "10001001", EmployeeName = "Ann", EmployeeSurname = "Whitaker", DivisionId = 4, PositionId = 8, Grade = 6, BeginDate = new DateTime(2020, 5, 16), Birthday = new DateTime(1992, 6, 21), IdentificationNumber = "8563217", BaseSalary = 2799.45, ProductionBonus = 1899, CompensationBonus = 2475.54, Commission = 896.22, Contributions = 0 },
                    /* 18 */ new Salary { Id = 18, Year = 2020, Month = 5, OfficeId = 1, EmployeeCode = "10001001", EmployeeName = "Ann", EmployeeSurname = "Whitaker", DivisionId = 4, PositionId = 8, Grade = 6, BeginDate = new DateTime(2020, 5, 16), Birthday = new DateTime(1992, 6, 21), IdentificationNumber = "8563217", BaseSalary = 2799.45, ProductionBonus = 1852.21, CompensationBonus = 2475.54, Commission = 801.85, Contributions = 0 }
                );
            /*
             year
month
officeId
employeeCode
employeeName
employeeSurname
divisionId
positionId
grade
beginDate
birthday
identificationNumber
baseSalary
productionBonus
compensationBonus
commission
contributions
            */
        }
    }
}
