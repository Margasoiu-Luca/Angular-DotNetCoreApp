using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class Fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieProdusId",
                table: "tProdus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tProdus_CategorieProdusId",
                table: "tProdus",
                column: "CategorieProdusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvnLeanring_tProdus_CategorieProdus",
                table: "tProdus",
                column: "CategorieProdusId",
                principalTable: "tnCategorieProdus",
                principalColumn: "CategorieProdusId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvnLeanring_tProdus_CategorieProdus",
                table: "tProdus");

            migrationBuilder.DropIndex(
                name: "IX_tProdus_CategorieProdusId",
                table: "tProdus");

            migrationBuilder.DropColumn(
                name: "CategorieProdusId",
                table: "tProdus");
        }
    }
}
