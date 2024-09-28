using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    /// <inheritdoc />
    public partial class EmissionGroupReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "EmissionGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionGroup", x => x.Id);
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
                name: "FK_MassEmissions_EmissionGroup_GroupId",
                table: "MassEmissions",
                column: "GroupId",
                principalTable: "EmissionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SingularEmissions_EmissionGroup_GroupId",
                table: "SingularEmissions",
                column: "GroupId",
                principalTable: "EmissionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MassEmissions_EmissionGroup_GroupId",
                table: "MassEmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SingularEmissions_EmissionGroup_GroupId",
                table: "SingularEmissions");

            migrationBuilder.DropTable(
                name: "EmissionGroup");

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
        }
    }
}
