using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VolunteerX.Migrations
{
    public partial class new_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_SectionOfProjects_SectionOfProjectId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_TypeOfProjects_TypeOfProjectId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_UserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_SectionOfProjectId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TypeOfProjectId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SectionOfProjectId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TypeOfProjectId",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SectionOfProject",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfProject",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ApplicationUserId",
                table: "Projects",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_ApplicationUserId",
                table: "Projects",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_ApplicationUserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ApplicationUserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "SectionOfProject",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TypeOfProject",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionOfProjectId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfProjectId",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SectionOfProjectId",
                table: "Projects",
                column: "SectionOfProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TypeOfProjectId",
                table: "Projects",
                column: "TypeOfProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_SectionOfProjects_SectionOfProjectId",
                table: "Projects",
                column: "SectionOfProjectId",
                principalTable: "SectionOfProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_TypeOfProjects_TypeOfProjectId",
                table: "Projects",
                column: "TypeOfProjectId",
                principalTable: "TypeOfProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
