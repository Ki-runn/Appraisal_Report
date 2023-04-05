using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class dateadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "AppraisalModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "AppraisalModel");
        }
    }
}
