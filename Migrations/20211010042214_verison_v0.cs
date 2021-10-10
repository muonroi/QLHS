using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_C_.Migrations
{
    public partial class verison_v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameClass = table.Column<string>(name: "Name Class", type: "nvarchar(450)", nullable: false),
                    NumberofClass = table.Column<int>(name: "Number of Class", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentsCode = table.Column<string>(name: "Students Code", type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "ntext", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classroom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoreMath = table.Column<double>(type: "float", nullable: false),
                    ScoreChemical = table.Column<double>(type: "float", nullable: false),
                    ScorePhysics = table.Column<double>(type: "float", nullable: false),
                    ScoreAverage = table.Column<double>(type: "float", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentsCode);
                    table.ForeignKey(
                        name: "FK_Students_Teacher_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teacher",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Students Code",
                table: "Students",
                column: "Students Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherID",
                table: "Students",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Name Class",
                table: "Teacher",
                column: "Name Class",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
