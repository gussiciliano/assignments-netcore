using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentsNetcore.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobRole_Tech_TechId",
                table: "JobRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Office_OfficeId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "Person",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TechId",
                table: "JobRole",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRole_Tech_TechId",
                table: "JobRole",
                column: "TechId",
                principalTable: "Tech",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Office_OfficeId",
                table: "Person",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobRole_Tech_TechId",
                table: "JobRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Office_OfficeId",
                table: "Person");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "Person",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TechId",
                table: "JobRole",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_JobRole_Tech_TechId",
                table: "JobRole",
                column: "TechId",
                principalTable: "Tech",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Office_OfficeId",
                table: "Person",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
