using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class empIdAddedInEmpTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpId",
                table: "EmpTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "EmpTable");
        }
    }
}
