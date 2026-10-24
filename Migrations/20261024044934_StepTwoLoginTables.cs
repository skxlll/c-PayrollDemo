using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayrollDemo.Migrations
{
    /// <inheritdoc />
    public partial class StepTwoLoginTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CatCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CatCode);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    ComCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ComName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.ComCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
