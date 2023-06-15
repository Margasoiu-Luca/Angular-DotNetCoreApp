using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class _14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create trigger CumparatorIdCtUpdate
	on [Iss.AvanMagazinOnline]..tCumparator after insert
	as
	begin
		update p
		set p.CumparatorIdCt=p.CumparatorId
		from tCumparator p
		join inserted i  on i.CumparatorId=p.CumparatorId
		where isnull(i.CumparatorIdCt,-1)=-1
	end");
            migrationBuilder.Sql(@"create trigger ProdusIdCtUpdate
	on [Iss.AvanMagazinOnline]..tProdus after insert
	as
	begin
		update p
		set p.ProdusIdCt=p.ProdusId
		from tProdus p
		join inserted i  on i.ProdusId=p.ProdusId
		where isnull(i.ProdusIdCt,-1)=-1
	end");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop trigger CumparatorIdCtUpdate");
            migrationBuilder.Sql("drop trigger ProdusIdCtUpdate");
        }
    }
}
