using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace co2app.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    ExternalId = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true),
                    Unit = table.Column<string>(type: "TEXT", nullable: false),
                    EmissionAgriculture = table.Column<float>(type: "REAL", nullable: false),
                    EmissionILUC = table.Column<float>(type: "REAL", nullable: false),
                    EmissionFoodProcessing = table.Column<float>(type: "REAL", nullable: false),
                    EmissionPackaging = table.Column<float>(type: "REAL", nullable: false),
                    EmissionTransport = table.Column<float>(type: "REAL", nullable: false),
                    EmissionRetail = table.Column<float>(type: "REAL", nullable: false),
                    EmissionTotal = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_FoodCategories_CategoryName",
                        column: x => x.CategoryName,
                        principalTable: "FoodCategories",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryName",
                table: "Foods",
                column: "CategoryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "FoodCategories");
        }
    }
}
