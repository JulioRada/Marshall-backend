using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marshall.Infrastructure.Migrations
{
    public partial class SeedSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "BaseSalary", "BeginDate", "Birthday", "Commission", "CompensationBonus", "Contributions", "Created", "DivisionId", "EmployeeCode", "EmployeeName", "EmployeeSurname", "Grade", "IdentificationNumber", "Month", "OfficeId", "PositionId", "ProductionBonus", "Updated", "Year" },
                values: new object[,]
                {
                    { 1, 2799.4499999999998, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3215.6300000000001, 1000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10001222", "Mike", "James", 18, "4564132", 10, 2, 1, 50.5, null, 2020 },
                    { 16, 2799.4499999999998, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1944.22, 998.45000000000005, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "10001001", "Ann", "Whitaker", 14, "8563217", 7, 3, 7, 0.0, null, 2020 },
                    { 15, 3200.0, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1845.6600000000001, 998.45000000000005, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "10001001", "Ann", "Whitaker", 14, "8563217", 8, 3, 7, 0.0, null, 2020 },
                    { 14, 5000.0, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2677.8800000000001, 3200.0, 1000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "10001001", "Ann", "Whitaker", 18, "8563217", 9, 3, 7, 0.0, null, 2020 },
                    { 13, 5000.0, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2478.96, 3200.0, 1000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "10001001", "Ann", "Whitaker", 18, "8563217", 10, 3, 7, 0.0, null, 2020 },
                    { 12, 2799.4499999999998, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2365.7399999999998, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "10023001", "Jane", "Doe", 11, "1989863", 5, 4, 6, 2666.0, null, 2020 },
                    { 11, 2799.4499999999998, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2365.7399999999998, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "10023001", "Jane", "Doe", 11, "1989863", 6, 4, 6, 2666.0, null, 2020 },
                    { 10, 2799.4499999999998, new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2365.7399999999998, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "10023001", "Jane", "Doe", 12, "1989863", 7, 4, 5, 3950.0, null, 2020 },
                    { 9, 3000.0, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "10023001", "Jane", "Doe", 12, "1989863", 10, 4, 5, 4000.0, null, 2020 },
                    { 8, 2995.0, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3200.0, 2340.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "10023001", "Kali", "Prasad", 18, "14598756", 9, 4, 4, 3200.0, null, 2020 },
                    { 7, 2995.0, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3200.0, 2100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "10023001", "Kali", "Prasad", 18, "14598756", 10, 4, 4, 3000.0, null, 2020 },
                    { 6, 2799.4499999999998, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000.0, 1500.0, 1600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10001222", "Mike", "James", 6, "4564132", 5, 1, 3, 1800.0, null, 2020 },
                    { 5, 2799.4499999999998, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4500.0, 1500.0, 1450.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10001222", "Mike", "James", 6, "4564132", 6, 1, 3, 2000.0, null, 2020 },
                    { 4, 2799.4499999999998, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 998.45000000000005, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10001222", "Mike", "James", 12, "4564132", 7, 3, 2, 50.5, null, 2020 },
                    { 3, 2799.4499999999998, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 998.45000000000005, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10001222", "Mike", "James", 12, "4564132", 8, 3, 2, 50.5, null, 2020 },
                    { 2, 2799.4499999999998, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3263.9899999999998, 1000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "10001222", "Mike", "James", 18, "4564132", 9, 2, 1, 50.5, null, 2020 },
                    { 17, 2799.4499999999998, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 896.22000000000003, 2475.54, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "10001001", "Ann", "Whitaker", 6, "8563217", 6, 1, 8, 1899.0, null, 2020 },
                    { 18, 2799.4499999999998, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 801.85000000000002, 2475.54, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "10001001", "Ann", "Whitaker", 6, "8563217", 5, 1, 8, 1852.21, null, 2020 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
