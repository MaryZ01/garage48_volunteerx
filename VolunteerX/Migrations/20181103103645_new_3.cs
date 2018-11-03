using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VolunteerX.Migrations
{
    public partial class new_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfProject",
                table: "Projects",
                newName: "DateOfStartProject");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfEndProject",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfEndProject",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "DateOfStartProject",
                table: "Projects",
                newName: "DateOfProject");
        }
    }
}
