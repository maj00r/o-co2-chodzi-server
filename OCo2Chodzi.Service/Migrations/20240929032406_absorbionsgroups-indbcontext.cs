using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OCo2Chodzi.Service.Migrations
{
    /// <inheritdoc />
    public partial class absorbionsgroupsindbcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbsorbionArea_AbsorbionGroup_AbsorbionGroupId",
                table: "AbsorbionArea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Absorbions",
                table: "Absorbions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbsorbionGroup",
                table: "AbsorbionGroup");

            migrationBuilder.RenameTable(
                name: "Absorbions",
                newName: "PredefinedAbsorbionRates");

            migrationBuilder.RenameTable(
                name: "AbsorbionGroup",
                newName: "AbsorbionGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PredefinedAbsorbionRates",
                table: "PredefinedAbsorbionRates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbsorbionGroups",
                table: "AbsorbionGroups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbsorbionArea_AbsorbionGroups_AbsorbionGroupId",
                table: "AbsorbionArea",
                column: "AbsorbionGroupId",
                principalTable: "AbsorbionGroups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbsorbionArea_AbsorbionGroups_AbsorbionGroupId",
                table: "AbsorbionArea");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PredefinedAbsorbionRates",
                table: "PredefinedAbsorbionRates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbsorbionGroups",
                table: "AbsorbionGroups");

            migrationBuilder.RenameTable(
                name: "PredefinedAbsorbionRates",
                newName: "Absorbions");

            migrationBuilder.RenameTable(
                name: "AbsorbionGroups",
                newName: "AbsorbionGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Absorbions",
                table: "Absorbions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbsorbionGroup",
                table: "AbsorbionGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbsorbionArea_AbsorbionGroup_AbsorbionGroupId",
                table: "AbsorbionArea",
                column: "AbsorbionGroupId",
                principalTable: "AbsorbionGroup",
                principalColumn: "Id");
        }
    }
}
