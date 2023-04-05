using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class gui : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "EmpTable",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "EmpTable",
                type: "int",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
