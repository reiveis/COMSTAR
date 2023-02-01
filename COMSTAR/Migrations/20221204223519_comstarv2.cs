using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMSTAR.Migrations
{
    public partial class comstarv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<string>(maxLength: 7, nullable: false),
                    EventName = table.Column<string>(maxLength: 50, nullable: false),
                    EventDate = table.Column<DateTime>(type: "date", nullable: false),
                    EventTarget = table.Column<string>(maxLength: 10, nullable: false),
                    EventDescription = table.Column<string>(maxLength: 280, nullable: false),
                    EventImage = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Events__7944C8108C94A8CC", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
