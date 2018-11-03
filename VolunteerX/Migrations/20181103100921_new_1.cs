using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VolunteerX.Migrations
{
    public partial class new_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_LocationOfProjects_LocationOfProjectId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "LocationOfProjects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_LocationOfProjectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PaymentOfAccommodation",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "PaymentOfFood",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "PaymentOfRoad",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Reward",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "LocationOfProjectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "MaxOfVolunteers",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Promotions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationOfProject",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountOfVolunteers",
                table: "Groups",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxOfVolunteers",
                table: "Groups",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "LocationOfProject",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CountOfVolunteers",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "MaxOfVolunteers",
                table: "Groups");

            migrationBuilder.AddColumn<bool>(
                name: "PaymentOfAccommodation",
                table: "Promotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PaymentOfFood",
                table: "Promotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PaymentOfRoad",
                table: "Promotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Reward",
                table: "Promotions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LocationOfProjectId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxOfVolunteers",
                table: "Projects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LocationOfProjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationOfProjects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_LocationOfProjectId",
                table: "Projects",
                column: "LocationOfProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_LocationOfProjects_LocationOfProjectId",
                table: "Projects",
                column: "LocationOfProjectId",
                principalTable: "LocationOfProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
