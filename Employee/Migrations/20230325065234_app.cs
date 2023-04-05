using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class app : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pass",
                table: "EmpTable",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmpTable",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "appraisalDetails",
                columns: table => new
                {
                    Detailid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppraisalId = table.Column<int>(nullable: false),
                    Comptency = table.Column<int>(nullable: false),
                    EmpRating = table.Column<int>(maxLength: 5, nullable: false),
                    Emp_Comments = table.Column<string>(nullable: false),
                    MgrRating = table.Column<int>(maxLength: 5, nullable: false),
                    Mgr_Comment = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appraisalDetails", x => x.Detailid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appraisalDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Pass",
                table: "EmpTable",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmpTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
