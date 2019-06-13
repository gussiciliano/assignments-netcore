using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentsNetcore.Migrations
{
    public partial class ProjectAndProjectComponent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectComponents_Projects_ProjectId",
                table: "ProjectComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectComponents_Techs_TechId",
                table: "ProjectComponents");

            migrationBuilder.AlterColumn<int>(
                name: "TechId",
                table: "ProjectComponents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectComponents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProjectComponents",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectComponents_Projects_ProjectId",
                table: "ProjectComponents",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectComponents_Techs_TechId",
                table: "ProjectComponents",
                column: "TechId",
                principalTable: "Techs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectComponents_Projects_ProjectId",
                table: "ProjectComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectComponents_Techs_TechId",
                table: "ProjectComponents");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProjectComponents");

            migrationBuilder.AlterColumn<int>(
                name: "TechId",
                table: "ProjectComponents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectComponents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectComponents_Projects_ProjectId",
                table: "ProjectComponents",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectComponents_Techs_TechId",
                table: "ProjectComponents",
                column: "TechId",
                principalTable: "Techs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
