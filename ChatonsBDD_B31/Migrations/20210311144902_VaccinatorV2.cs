using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatonsBDD_B31.Migrations
{
    public partial class VaccinatorV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "recall",
                table: "Injection",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "recall",
                table: "Injection");
        }
    }
}
