using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoManager.Migrations
{
    public partial class newmigrationtypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TodoTasks_PersonID",
                table: "TodoTasks",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoTasks_People_PersonID",
                table: "TodoTasks",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoTasks_People_PersonID",
                table: "TodoTasks");

            migrationBuilder.DropIndex(
                name: "IX_TodoTasks_PersonID",
                table: "TodoTasks");
        }
    }
}
