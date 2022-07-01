using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LazyLoadingSample.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    DeptId = table.Column<string>(type: "TEXT", nullable: false),
                    DeptName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "DeptUser",
                columns: table => new
                {
                    DeptsDeptId = table.Column<string>(type: "TEXT", nullable: false),
                    UsersUserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptUser", x => new { x.DeptsDeptId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_DeptUser_Dept_DeptsDeptId",
                        column: x => x.DeptsDeptId,
                        principalTable: "Dept",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeptUser_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeptUser_UsersUserId",
                table: "DeptUser",
                column: "UsersUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeptUser");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
