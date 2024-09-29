using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    /// <inheritdoc />
    public partial class areaofabsorbionregion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AreaInAres",
                table: "AbsorbionArea",
                type: "bigint",
                nullable: false,
                computedColumnSql: "Area.STArea() / 100");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaInAres",
                table: "AbsorbionArea");
        }
    }
}
