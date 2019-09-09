using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentsNetcore.Migrations
{
    public partial class AddNameToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Persons");
        }
    }
}
