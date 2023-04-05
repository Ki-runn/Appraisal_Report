using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class kirancommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpTable",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Pass = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<int>(maxLength: 12, nullable: false),
                    MID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTable", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpTable");
        }
    }
}
