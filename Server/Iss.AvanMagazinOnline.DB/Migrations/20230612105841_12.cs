using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iss.AvanMagazinOnline.DB.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create trigger ProducatorIdCtUpdate
	on [Iss.AvanMagazinOnline]..tProducator after insert
	as
	begin
		update p
		set p.ProducatorIdCt=p.ProducatorId
		from tProducator p
		join inserted i  on i.ProducatorId=p.ProducatorId
		where isnull(i.ProducatorIdCt,-1)=-1
	end");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop trigger ProducatorIdCtUpdate");
        }
    }
}
