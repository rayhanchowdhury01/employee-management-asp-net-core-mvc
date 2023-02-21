using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employ_management.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Emain",
                table: "Employees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "BirthOfDate",
                table: "Employees",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "Emain");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Employees",
                newName: "BirthOfDate");
        }
    }
}
