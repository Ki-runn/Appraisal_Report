using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class addedcompt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             

            migrationBuilder.AddColumn<string>(
                name: "Tcompetency",
                table: "Status",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             
            migrationBuilder.AddColumn<string>(
                name: "TCompetency",
                table: "Status",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
