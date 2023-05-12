using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitopiaQuest.Migrations
{
    /// <inheritdoc />
    public partial class AddImageParameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageOfMovie",
                table: "Games",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageOfBook",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageOfMovie",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ImageOfBook",
                table: "Books");
        }
    }
}
