using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class Sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSfarsit",
                table: "tProdus",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "'2078-12-31 00:00:00.0000000'",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "'2078-12-31 00:00:00.0000000'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInceput",
                table: "tProdus",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getdate()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataSfarsit",
                table: "tProdus",
                type: "datetime",
                nullable: false,
                defaultValueSql: "'2078-12-31 00:00:00.0000000'",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "'2078-12-31 00:00:00.0000000'");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInceput",
                table: "tProdus",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");
        }
    }
}
