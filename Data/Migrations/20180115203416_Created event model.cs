using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MicrosoftLaboratoryCms.Data.Migrations
{
    public partial class Createdeventmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AuthorId = table.Column<string>(nullable: false),
                    Corpus = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    EventDateTime = table.Column<DateTime>(nullable: false),
                    Tags = table.Column<List<string>>(nullable: true),
                    ThumbnailImage = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_AuthorId",
                table: "Events",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
