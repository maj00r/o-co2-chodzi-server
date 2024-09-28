using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    /// <inheritdoc />
    public partial class AbsorbionAreaDefinition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbsorbionDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeYears = table.Column<int>(type: "int", nullable: false),
                    HeightMeters = table.Column<int>(type: "int", nullable: false),
                    GrowingSeasonWeeks = table.Column<int>(type: "int", nullable: false),
                    AbsorbionKilogramsPerGrowingSeason = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsorbionDefinition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbsorbionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsorbionGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbsorbionArea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<Polygon>(type: "geography", nullable: false),
                    AbsorbionDefinitionId = table.Column<int>(type: "int", nullable: false),
                    AbsorbionGroupId = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsorbionArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbsorbionArea_AbsorbionDefinition_AbsorbionDefinitionId",
                        column: x => x.AbsorbionDefinitionId,
                        principalTable: "AbsorbionDefinition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbsorbionArea_AbsorbionGroup_AbsorbionGroupId",
                        column: x => x.AbsorbionGroupId,
                        principalTable: "AbsorbionGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbsorbionArea_AbsorbionDefinitionId",
                table: "AbsorbionArea",
                column: "AbsorbionDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_AbsorbionArea_AbsorbionGroupId",
                table: "AbsorbionArea",
                column: "AbsorbionGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbsorbionArea");

            migrationBuilder.DropTable(
                name: "AbsorbionDefinition");

            migrationBuilder.DropTable(
                name: "AbsorbionGroup");
        }
    }
}
