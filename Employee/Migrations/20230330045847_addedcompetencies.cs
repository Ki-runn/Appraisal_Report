using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class addedcompetencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BehaviouralCompetency",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechCompetency",
                table: "AppraisalModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BehaviouralCompetency",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "TechCompetency",
                table: "AppraisalModel");
        }
    }
}
