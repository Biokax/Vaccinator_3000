using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatonsBDD_B31.Migrations
{
    public partial class VaccinatorV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lot",
                table: "Injection",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lot",
                table: "Injection");
        }
    }
}
