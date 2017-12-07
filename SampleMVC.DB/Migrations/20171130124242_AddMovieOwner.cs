using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SampleMVC.DB.Migrations
{
    public partial class AddMovieOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_OwnerId",
                table: "Movies",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_AspNetUsers_OwnerId",
                table: "Movies",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_AspNetUsers_OwnerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_OwnerId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Movies");
        }
    }
}
