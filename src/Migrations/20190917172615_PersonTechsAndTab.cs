using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AssignmentsNetcore.Migrations
{
    public partial class PersonTechsAndTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Persons_PersonId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_ProjectComponents_ProjectComponentId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonTech_Persons_PersonId",
                table: "PersonTech");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonTech_Techs_TechId",
                table: "PersonTech");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonTech",
                table: "PersonTech");

            migrationBuilder.DropColumn(
                name: "ProjectStatus",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Individual",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Remote",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TrainingStatus",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "PersonTech",
                newName: "PersonTechs");

            migrationBuilder.RenameColumn(
                name: "ProjectComponentId",
                table: "Assignments",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_ProjectComponentId",
                table: "Assignments",
                newName: "IX_Assignments_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonTech_TechId",
                table: "PersonTechs",
                newName: "IX_PersonTechs_TechId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Projects",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "TabId",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechId",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Assignments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PersonTechId",
                table: "Assignments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonTechPersonId",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonTechTechId",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonTechs",
                table: "PersonTechs",
                columns: new[] { "PersonId", "TechId" });

            migrationBuilder.CreateTable(
                name: "Tabs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    ProjectStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    Discriminator = table.Column<string>(nullable: false),
                    Individual = table.Column<bool>(nullable: true),
                    Remote = table.Column<bool>(nullable: true),
                    TrainingStatus = table.Column<int>(nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tabs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tabs_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TabId",
                table: "Projects",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TechId",
                table: "Projects",
                column: "TechId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_PersonTechPersonId_PersonTechTechId",
                table: "Assignments",
                columns: new[] { "PersonTechPersonId", "PersonTechTechId" });

            migrationBuilder.CreateIndex(
                name: "IX_Tabs_ClientId",
                table: "Tabs",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Persons_PersonId",
                table: "Assignments",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_PersonTechs_PersonTechPersonId_PersonTechTechId",
                table: "Assignments",
                columns: new[] { "PersonTechPersonId", "PersonTechTechId" },
                principalTable: "PersonTechs",
                principalColumns: new[] { "PersonId", "TechId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonTechs_Persons_PersonId",
                table: "PersonTechs",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonTechs_Techs_TechId",
                table: "PersonTechs",
                column: "TechId",
                principalTable: "Techs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Tabs_TabId",
                table: "Projects",
                column: "TabId",
                principalTable: "Tabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Techs_TechId",
                table: "Projects",
                column: "TechId",
                principalTable: "Techs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Persons_PersonId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_PersonTechs_PersonTechPersonId_PersonTechTechId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonTechs_Persons_PersonId",
                table: "PersonTechs");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonTechs_Techs_TechId",
                table: "PersonTechs");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Tabs_TabId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Techs_TechId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Tabs");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TabId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TechId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_PersonTechPersonId_PersonTechTechId",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonTechs",
                table: "PersonTechs");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TabId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TechId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PersonTechId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "PersonTechPersonId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "PersonTechTechId",
                table: "Assignments");

            migrationBuilder.RenameTable(
                name: "PersonTechs",
                newName: "PersonTech");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Assignments",
                newName: "ProjectComponentId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                newName: "IX_Assignments_ProjectComponentId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonTechs_TechId",
                table: "PersonTech",
                newName: "IX_PersonTech_TechId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectStatus",
                table: "Projects",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "Individual",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Remote",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingStatus",
                table: "Projects",
                nullable: true,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Assignments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonTech",
                table: "PersonTech",
                columns: new[] { "PersonId", "TechId" });

            migrationBuilder.CreateTable(
                name: "ProjectComponents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1),
                    TechId = table.Column<int>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectComponents_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectComponents_Techs_TechId",
                        column: x => x.TechId,
                        principalTable: "Techs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectComponents_ProjectId",
                table: "ProjectComponents",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectComponents_TechId",
                table: "ProjectComponents",
                column: "TechId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Persons_PersonId",
                table: "Assignments",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_ProjectComponents_ProjectComponentId",
                table: "Assignments",
                column: "ProjectComponentId",
                principalTable: "ProjectComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonTech_Persons_PersonId",
                table: "PersonTech",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonTech_Techs_TechId",
                table: "PersonTech",
                column: "TechId",
                principalTable: "Techs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
