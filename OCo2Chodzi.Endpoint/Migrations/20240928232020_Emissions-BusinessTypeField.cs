using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    /// <inheritdoc />
    public partial class EmissionsBusinessTypeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MassEmissions_EmissionGroups_GroupId",
                table: "MassEmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SingularEmissions_EmissionGroups_GroupId",
                table: "SingularEmissions");

            migrationBuilder.DropTable(
                name: "EmissionGroups");

            migrationBuilder.DropIndex(
                name: "IX_SingularEmissions_GroupId",
                table: "SingularEmissions");

            migrationBuilder.DropIndex(
                name: "IX_MassEmissions_GroupId",
                table: "MassEmissions");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "SingularEmissions");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "MassEmissions");

            migrationBuilder.AddColumn<string>(
                name: "BusinessType",
                table: "SingularEmissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "SingularEmissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessType",
                table: "MassEmissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "MassEmissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessType",
                table: "LinearEmissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "LinearEmissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessType",
                table: "SingularEmissions");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "SingularEmissions");

            migrationBuilder.DropColumn(
                name: "BusinessType",
                table: "MassEmissions");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "MassEmissions");

            migrationBuilder.DropColumn(
                name: "BusinessType",
                table: "LinearEmissions");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "LinearEmissions");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "SingularEmissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "MassEmissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmissionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionGroups", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SingularEmissions_GroupId",
                table: "SingularEmissions",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MassEmissions_GroupId",
                table: "MassEmissions",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_MassEmissions_EmissionGroups_GroupId",
                table: "MassEmissions",
                column: "GroupId",
                principalTable: "EmissionGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SingularEmissions_EmissionGroups_GroupId",
                table: "SingularEmissions",
                column: "GroupId",
                principalTable: "EmissionGroups",
                principalColumn: "Id");
        }
    }
}
