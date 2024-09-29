using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    /// <inheritdoc />
    public partial class DecimalTypeBiggerPrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageDensityPerSquareMeter",
                table: "AbsorbionArea");

            migrationBuilder.AlterColumn<decimal>(
                name: "Emission",
                table: "SingularEmissions",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmissionPerKilo",
                table: "MassEmissions",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmissionPerKm",
                table: "LinearEmissions",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Absorbions",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "AbsorbionType",
                table: "Absorbions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "AbsorbionKilogramsPerGrowingSeason",
                table: "AbsorbionDefinition",
                type: "decimal(18,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageDensityPerAre",
                table: "AbsorbionArea",
                type: "decimal(18,6)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageDensityPerAre",
                table: "AbsorbionArea");

            migrationBuilder.AlterColumn<decimal>(
                name: "Emission",
                table: "SingularEmissions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmissionPerKilo",
                table: "MassEmissions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "EmissionPerKm",
                table: "LinearEmissions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Absorbions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AlterColumn<int>(
                name: "AbsorbionType",
                table: "Absorbions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AbsorbionKilogramsPerGrowingSeason",
                table: "AbsorbionDefinition",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,6)");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageDensityPerSquareMeter",
                table: "AbsorbionArea",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
