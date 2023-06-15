using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CumparatorIdCt",
                table: "tCumparator",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CumparatorIdCt",
                table: "tCumparator");
        }
    }
}
