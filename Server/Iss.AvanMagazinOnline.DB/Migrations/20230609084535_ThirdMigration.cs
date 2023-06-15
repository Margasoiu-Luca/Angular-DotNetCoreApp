using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tnCategorieProdus",
                columns: table => new
                {
                    CategorieProdusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireCategorieProdus = table.Column<string>(type: "nvarchar(128)", nullable: false),
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
                    table.PrimaryKey("PK_tnCategorieProdus", x => x.CategorieProdusId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tnCategorieProdus");
        }
    }
}
