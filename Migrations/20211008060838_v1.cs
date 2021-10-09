using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_C_.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teacher_Name Class",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Students_Students Code",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Name Class",
                table: "Teacher",
                column: "Name Class",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Students Code",
                table: "Students",
                column: "Students Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teacher_Name Class",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Students_Students Code",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Name Class",
                table: "Teacher",
                column: "Name Class");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Students Code",
                table: "Students",
                column: "Students Code");
        }
    }
}
