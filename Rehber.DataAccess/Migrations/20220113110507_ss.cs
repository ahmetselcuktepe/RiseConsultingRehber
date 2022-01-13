using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rehber.DataAccess.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "İd",
                table: "RehberKDetails",
                newName: "Id");

            migrationBuilder.AddColumn<Guid>(
                name: "RehberKId",
                table: "RehberKDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RehberKDetails_RehberKId",
                table: "RehberKDetails",
                column: "RehberKId");

            migrationBuilder.AddForeignKey(
                name: "FK_RehberKDetails_RehberKs_RehberKId",
                table: "RehberKDetails",
                column: "RehberKId",
                principalTable: "RehberKs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RehberKDetails_RehberKs_RehberKId",
                table: "RehberKDetails");

            migrationBuilder.DropIndex(
                name: "IX_RehberKDetails_RehberKId",
                table: "RehberKDetails");

            migrationBuilder.DropColumn(
                name: "RehberKId",
                table: "RehberKDetails");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RehberKDetails",
                newName: "İd");
        }
    }
}
