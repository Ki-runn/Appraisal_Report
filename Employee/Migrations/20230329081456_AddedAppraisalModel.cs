using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class AddedAppraisalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppraisalModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MID = table.Column<int>(nullable: false),
                    EmpId = table.Column<int>(nullable: false),
                    Obj1 = table.Column<string>(nullable: true),
                    Obj2 = table.Column<string>(nullable: true),
                    Obj3 = table.Column<string>(nullable: true),
                    Obj4 = table.Column<string>(nullable: true),
                    Obj5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppraisalModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppraisalModel");
        }
    }
}
