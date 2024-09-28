using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCo2Chodzi.Endpoint.Migrations
{
    /// <inheritdoc />
    public partial class EmissionGroupReferenceOnDeleteaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MassEmissions_EmissionGroup_GroupId",
                table: "MassEmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SingularEmissions_EmissionGroup_GroupId",
                table: "SingularEmissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmissionGroup",
                table: "EmissionGroup");

            migrationBuilder.RenameTable(
                name: "EmissionGroup",
                newName: "EmissionGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmissionGroups",
                table: "EmissionGroups",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MassEmissions_EmissionGroups_GroupId",
                table: "MassEmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_SingularEmissions_EmissionGroups_GroupId",
                table: "SingularEmissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmissionGroups",
                table: "EmissionGroups");

            migrationBuilder.RenameTable(
                name: "EmissionGroups",
                newName: "EmissionGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmissionGroup",
                table: "EmissionGroup",
                column: "Id");

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
    }
}
