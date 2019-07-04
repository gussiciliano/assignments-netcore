using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentsNetcore.Migrations
{
    public partial class PersonTechEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_ProjectComponents_ProjectComponentId",
                table: "Assignments");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectComponentId",
                table: "Assignments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PersonTech",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    TechId = table.Column<int>(nullable: false),
                    DeveloperRole = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTech", x => new { x.PersonId, x.TechId });
                    table.ForeignKey(
                        name: "FK_PersonTech_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonTech_Techs_TechId",
                        column: x => x.TechId,
                        principalTable: "Techs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonTech_TechId",
                table: "PersonTech",
                column: "TechId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_ProjectComponents_ProjectComponentId",
                table: "Assignments",
                column: "ProjectComponentId",
                principalTable: "ProjectComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_ProjectComponents_ProjectComponentId",
                table: "Assignments");

            migrationBuilder.DropTable(
                name: "PersonTech");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectComponentId",
                table: "Assignments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_ProjectComponents_ProjectComponentId",
                table: "Assignments",
                column: "ProjectComponentId",
                principalTable: "ProjectComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
