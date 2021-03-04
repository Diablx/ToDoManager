using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoManager.Migrations
{
    public partial class persontodorelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoTasks_People_AssignedUserID",
                table: "TodoTasks");

            migrationBuilder.DropIndex(
                name: "IX_TodoTasks_AssignedUserID",
                table: "TodoTasks");

            migrationBuilder.DropColumn(
                name: "AssignedUserID",
                table: "TodoTasks");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "TodoTasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "TodoTasks");

            migrationBuilder.AddColumn<int>(
                name: "AssignedUserID",
                table: "TodoTasks",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoTasks_AssignedUserID",
                table: "TodoTasks",
                column: "AssignedUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoTasks_People_AssignedUserID",
                table: "TodoTasks",
                column: "AssignedUserID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
