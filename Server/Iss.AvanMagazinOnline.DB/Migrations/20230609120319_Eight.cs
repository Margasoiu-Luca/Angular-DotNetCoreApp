using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class Eight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tCumparator",
                columns: table => new
                {
                    CumparatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(32)", nullable: true),
                    TelefonMobil = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    TipPersoana = table.Column<byte>(type: "tinyint", nullable: false),
                    DataNastere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CNP = table.Column<string>(type: "nvarchar(32)", nullable: true),
                    DataInceput = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    DataSfarsit = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "'2078-12-31 00:00:00.0000000'"),
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
                    table.PrimaryKey("PK_tCumparator", x => x.CumparatorId);
                });

            migrationBuilder.CreateTable(
                name: "tProdusStoc",
                columns: table => new
                {
                    ProdusStocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdusIdCt = table.Column<int>(type: "int", nullable: false),
                    Stoc = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
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
                    table.PrimaryKey("PK_tProdusStoc", x => x.ProdusStocId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tCumparator");

            migrationBuilder.DropTable(
                name: "tProdusStoc");
        }
    }
}
