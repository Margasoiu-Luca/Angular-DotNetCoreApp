using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class Seventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DenumireProdus",
                table: "tProdus",
                type: "nvarchar(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProducatorId",
                table: "tProdus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tProdus_ProducatorId",
                table: "tProdus",
                column: "ProducatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvnLeanring_tProdus_ProdusId",
                table: "tProdus",
                column: "ProducatorId",
                principalTable: "tProducator",
                principalColumn: "ProducatorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AvnLeanring_tProdus_ProdusId",
                table: "tProdus");

            migrationBuilder.DropIndex(
                name: "IX_tProdus_ProducatorId",
                table: "tProdus");

            migrationBuilder.DropColumn(
                name: "ProducatorId",
                table: "tProdus");

            migrationBuilder.AlterColumn<string>(
                name: "DenumireProdus",
                table: "tProdus",
                type: "varchar(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldNullable: true);
        }
    }
}
