using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitopiaQuest.Migrations.DigitopiaQuest
{
    /// <inheritdoc />
    public partial class AddFirstLastNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstNameOfUser",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastNameOfUser",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstNameOfUser",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastNameOfUser",
                table: "AspNetUsers");
        }
    }
}
