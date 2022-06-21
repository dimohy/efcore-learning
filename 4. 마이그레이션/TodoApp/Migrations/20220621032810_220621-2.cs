using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class _2206212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoChangedHistory_TodoInfo_TodoSeq",
                table: "TodoChangedHistory");

            migrationBuilder.AddColumn<int>(
                name: "TodoInfoSeq",
                table: "TodoChangedHistory",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoChangedHistory_TodoInfoSeq",
                table: "TodoChangedHistory",
                column: "TodoInfoSeq");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoChangedHistory_TodoInfo_TodoInfoSeq",
                table: "TodoChangedHistory",
                column: "TodoInfoSeq",
                principalTable: "TodoInfo",
                principalColumn: "Seq");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoChangedHistory_TodoInfo_TodoInfoSeq",
                table: "TodoChangedHistory");

            migrationBuilder.DropIndex(
                name: "IX_TodoChangedHistory_TodoInfoSeq",
                table: "TodoChangedHistory");

            migrationBuilder.DropColumn(
                name: "TodoInfoSeq",
                table: "TodoChangedHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoChangedHistory_TodoInfo_TodoSeq",
                table: "TodoChangedHistory",
                column: "TodoSeq",
                principalTable: "TodoInfo",
                principalColumn: "Seq",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
