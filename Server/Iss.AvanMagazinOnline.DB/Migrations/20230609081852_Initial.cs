using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tProducator",
                columns: table => new
                {
                    ProducatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducatorIdCt = table.Column<int>(type: "int", nullable: true),
                    DataInceput = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getdate()"),
                    DataSfarsit = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "'2078-12-31 00:00:00.0000000'"),
                    Nume = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(32)", nullable: false),
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
                    table.PrimaryKey("PK_tProducator", x => x.ProducatorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tProducator");
        }
    }
}
