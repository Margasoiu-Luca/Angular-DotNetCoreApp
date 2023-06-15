using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tProdus",
                columns: table => new
                {
                    ProdusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdusIdCt = table.Column<int>(type: "int", nullable: true),
                    DenumireProdus = table.Column<string>(type: "varchar(256)", nullable: true),
                    CostProdus = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    DescriereProdus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInceput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    DataSfarsit = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'2078-12-31 00:00:00.0000000'"),
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
                    table.PrimaryKey("PK_tProdus", x => x.ProdusId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tProdus");
        }
    }
}
