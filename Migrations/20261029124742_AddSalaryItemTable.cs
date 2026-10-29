using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddSalaryItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaryItems",
                columns: table => new
                {
                    TxnCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryItems", x => x.TxnCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaryItems");
        }
    }
}
