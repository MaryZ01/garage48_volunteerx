using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VolunteerX.Migrations
{
    public partial class update_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskOfVolunteers_Groups_GroupId",
                table: "TaskOfVolunteers");

            migrationBuilder.DropIndex(
                name: "IX_TaskOfVolunteers_GroupId",
                table: "TaskOfVolunteers");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "TaskOfVolunteers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "TaskOfVolunteers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_TaskOfVolunteers_GroupId",
                table: "TaskOfVolunteers",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskOfVolunteers_Groups_GroupId",
                table: "TaskOfVolunteers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
