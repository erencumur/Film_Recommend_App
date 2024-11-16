using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmRecommendForm.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    MovieCategoryID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "longchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.MovieCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "MovieSubCategories",
                columns: table => new
                {
                    MovieSubCategoryID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "longchar", nullable: false),
                    MovieCategoryID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSubCategories", x => x.MovieSubCategoryID);
                    table.ForeignKey(
                        name: "FK_MovieSubCategories_MovieCategories_MovieCategoryID",
                        column: x => x.MovieCategoryID,
                        principalTable: "MovieCategories",
                        principalColumn: "MovieCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Jet:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "longchar", nullable: false),
                    LeadingActor = table.Column<string>(type: "longchar", nullable: false),
                    ReleaseYear = table.Column<int>(type: "integer", nullable: false),
                    Director = table.Column<string>(type: "longchar", nullable: false),
                    Rating = table.Column<double>(type: "double", nullable: false),
                    MovieSubCategoryID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movies_MovieSubCategories_MovieSubCategoryID",
                        column: x => x.MovieSubCategoryID,
                        principalTable: "MovieSubCategories",
                        principalColumn: "MovieSubCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieSubCategoryID",
                table: "Movies",
                column: "MovieSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSubCategories_MovieCategoryID",
                table: "MovieSubCategories",
                column: "MovieCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MovieSubCategories");

            migrationBuilder.DropTable(
                name: "MovieCategories");
        }
    }
}
