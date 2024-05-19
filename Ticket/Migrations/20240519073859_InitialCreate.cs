using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ticket.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "ActorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ActorId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
