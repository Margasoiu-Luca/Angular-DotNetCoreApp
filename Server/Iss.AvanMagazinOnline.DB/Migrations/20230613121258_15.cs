using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class _15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE FUNCTION CheckIfItemExists(@ProdusIdCt int) RETURNS INT\r\n\t\tAS\r\n\t\tBEGIN\r\n\t\t\tRETURN isnull((select top 1 1 from  tProdus where @ProdusIdCt=ProdusIdCt and MMId!=2),0)\r\n\t\tEND");
            migrationBuilder.Sql("alter table tProdusStoc\r\nadd constraint CHK_Iss_AvanMagazinOnline_tProdusStoc_ProdusIdCt  CHECK (dbo.CheckIfItemExists(ProdusIdCt)=1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("alter table tProdusStoc\r\ndrop constraint CHK_Iss_AvanMagazinOnline_tProdusStoc_ProdusIdCt");
            migrationBuilder.Sql("drop function CheckIfItemExists");
        }
    }
}
