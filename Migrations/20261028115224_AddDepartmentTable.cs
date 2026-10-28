using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DepartmentCode",
                table: "Employees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DepName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepCode);
                });

            // Seed any existing employee department codes into the new table before establishing Foreign Key
            migrationBuilder.Sql(@"
                INSERT INTO Departments (DepCode, DepName)
                SELECT DISTINCT DepartmentCode, DepartmentCode 
                FROM Employees 
                WHERE DepartmentCode IS NOT NULL 
                  AND DepartmentCode <> '' 
                  AND DepartmentCode NOT IN (SELECT DepCode FROM Departments);
            ");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentCode",
                table: "Employees",
                column: "DepartmentCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentCode",
                table: "Employees",
                column: "DepartmentCode",
                principalTable: "Departments",
                principalColumn: "DepCode",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentCode",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentCode",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }
    }
}