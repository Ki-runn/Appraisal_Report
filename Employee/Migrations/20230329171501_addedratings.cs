using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class addedratings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "E_Comment1",
                table: "AppraisalModel",
                nullable: true);

/*            migrationBuilder.AddColumn<string>(
                name: "E_Comment2",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "E_Comment3",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "E_Comment4",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "E_Comment5",
                table: "AppraisalModel",
                nullable: true);*/

            migrationBuilder.AddColumn<string>(
                name: "M_Comment1",
                table: "AppraisalModel",
                nullable: true);

/*            migrationBuilder.AddColumn<string>(
                name: "M_Comment2",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M_Comment3",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M_Comment4",
                table: "AppraisalModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "M_Comment5",
                table: "AppraisalModel",
                nullable: true);
*/
            migrationBuilder.AddColumn<int>(
                name: "Rating1",
                table: "AppraisalModel",
                nullable: false,
                defaultValue: 0);

            /*migrationBuilder.AddColumn<int>(
                name: "Rating2",
                table: "AppraisalModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating3",
                table: "AppraisalModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating4",
                table: "AppraisalModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating5",
                table: "AppraisalModel",
                nullable: false,
                defaultValue: 0);*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "E_Comment1",
                table: "AppraisalModel");

     /*       migrationBuilder.DropColumn(
                name: "E_Comment2",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "E_Comment3",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "E_Comment4",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "E_Comment5",
                table: "AppraisalModel");*/

            migrationBuilder.DropColumn(
                name: "M_Comment1",
                table: "AppraisalModel");

     /*       migrationBuilder.DropColumn(
                name: "M_Comment2",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "M_Comment3",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "M_Comment4",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "M_Comment5",
                table: "AppraisalModel");*/

            migrationBuilder.DropColumn(
                name: "Rating1",
                table: "AppraisalModel");

            /*migrationBuilder.DropColumn(
                name: "Rating2",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "Rating3",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "Rating4",
                table: "AppraisalModel");

            migrationBuilder.DropColumn(
                name: "Rating5",
                table: "AppraisalModel");*/
        }
    }
}
