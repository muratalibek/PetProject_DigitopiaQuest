using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitopiaQuest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfBook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionOfBook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorOfBook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelieseDateOfBook = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatingOfBook = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionOfGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserScore = table.Column<double>(type: "float", nullable: false),
                    ReleaseDateOfGame = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreOfGame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevCompany = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "List<string>",
                columns: table => new
                {
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfMovie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeOfRating = table.Column<int>(type: "int", nullable: false),
                    ImdbRating = table.Column<double>(type: "float", nullable: false),
                    GenreOfMovie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionOfMovie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDateOfMovie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ImageOfMovie = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    RatingOfMovie = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "List<string>");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
