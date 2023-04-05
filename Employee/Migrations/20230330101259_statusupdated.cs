using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class statusupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TechCompetency",
                table: "Status",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TechCompetency",
                table: "Status");
        }
    }
}
