using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class _220621 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoChangedHistory",
                columns: table => new
                {
                    TodoSeq = table.Column<int>(type: "INTEGER", nullable: false),
                    Seq = table.Column<int>(type: "INTEGER", nullable: false),
                    ChangedKind = table.Column<int>(type: "INTEGER", nullable: false),
                    Before = table.Column<string>(type: "TEXT", nullable: false),
                    After = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoChangedHistory", x => new { x.TodoSeq, x.Seq });
                    table.ForeignKey(
                        name: "FK_TodoChangedHistory_TodoInfo_TodoSeq",
                        column: x => x.TodoSeq,
                        principalTable: "TodoInfo",
                        principalColumn: "Seq",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TodoTagInfo",
                columns: table => new
                {
                    TagId = table.Column<string>(type: "TEXT", nullable: false),
                    Descption = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoTagInfo", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "TodoInfoTodoTagInfo",
                columns: table => new
                {
                    TagsTagId = table.Column<string>(type: "TEXT", nullable: false),
                    TodosSeq = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoInfoTodoTagInfo", x => new { x.TagsTagId, x.TodosSeq });
                    table.ForeignKey(
                        name: "FK_TodoInfoTodoTagInfo_TodoInfo_TodosSeq",
                        column: x => x.TodosSeq,
                        principalTable: "TodoInfo",
                        principalColumn: "Seq",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TodoInfoTodoTagInfo_TodoTagInfo_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "TodoTagInfo",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoInfoTodoTagInfo_TodosSeq",
                table: "TodoInfoTodoTagInfo",
                column: "TodosSeq");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoChangedHistory");

            migrationBuilder.DropTable(
                name: "TodoInfoTodoTagInfo");

            migrationBuilder.DropTable(
                name: "TodoTagInfo");
        }
    }
}
