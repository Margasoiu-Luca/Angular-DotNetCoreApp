using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class Ninght : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tComanda",
                columns: table => new
                {
                    ComandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numar = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    DataComanda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostTotalProduse = table.Column<decimal>(type: "decimal(28,4)", nullable: false),
                    CostLivrare = table.Column<decimal>(type: "decimal(28,4)", nullable: false),
                    CumparatorId = table.Column<int>(type: "int", nullable: false),
                    IData = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    ICalculator = table.Column<string>(type: "nvarchar(32)", nullable: true, defaultValueSql: "host_name()"),
                    IUtilizator = table.Column<string>(type: "nvarchar(32)", nullable: true, defaultValueSql: "suser_sname()"),
                    UData = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    UCalculator = table.Column<string>(type: "nvarchar(32)", nullable: true, defaultValueSql: "host_name()"),
                    UUtilizator = table.Column<string>(type: "nvarchar(32)", nullable: true, defaultValueSql: "suser_sname()"),
                    Rv = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tComanda", x => x.ComandaId);
                    table.ForeignKey(
                        name: "FK_AvnLeanring_tComanda_CumparatorId",
                        column: x => x.CumparatorId,
                        principalTable: "tCumparator",
                        principalColumn: "CumparatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tComanda_CumparatorId",
                table: "tComanda",
                column: "CumparatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tComanda");
        }
    }
}
