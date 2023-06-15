using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class _10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tProdusStoc_ProdusIdCt",
                table: "tProdusStoc",
                column: "ProdusIdCt",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tProdusStoc_ProdusIdCt",
                table: "tProdusStoc");
        }
    }
}
