using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Homies.Data.Migrations
{
    public partial class changeEventIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventsParticipants",
                table: "EventsParticipants");

            migrationBuilder.DropIndex(
                name: "IX_EventsParticipants_EventId",
                table: "EventsParticipants");

            migrationBuilder.DropColumn(
                name: "EvenId",
                table: "EventsParticipants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventsParticipants",
                table: "EventsParticipants",
                columns: new[] { "EventId", "HelperId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EventsParticipants",
                table: "EventsParticipants");

            migrationBuilder.AddColumn<int>(
                name: "EvenId",
                table: "EventsParticipants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventsParticipants",
                table: "EventsParticipants",
                columns: new[] { "EvenId", "HelperId" });

            migrationBuilder.CreateIndex(
                name: "IX_EventsParticipants_EventId",
                table: "EventsParticipants",
                column: "EventId");
        }
    }
}
