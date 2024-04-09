using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel9.Migrations
{
    /// <inheritdoc />
    public partial class sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Bookings2");

            migrationBuilder.AddColumn<string>(
                name: "ClientUsername",
                table: "Bookings2",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientUsername",
                table: "Bookings2");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Bookings2",
                type: "int",
                nullable: true);
        }
    }
}
