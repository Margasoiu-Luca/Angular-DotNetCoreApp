using ConsoleApp5.Data;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.CRUD
{
    public class ProdusStocCRUD : IDBCrud<ProdusStoc, int>
    {
        public async Task Create(ProdusStoc entity)
        {
            using (EFContext ctx = new EFContext())
            {
                await ctx.ProduseStoc.AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var current = await ctx.ProduseStoc.FirstOrDefaultAsync(x=>x.ProdusStocId==id);
                if (current != null)
                {
                    ctx.ProduseStoc.Remove(current);
                    await ctx.SaveChangesAsync();
                }
            }
        }

        public async Task<ProdusStoc> Get(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.ProduseStoc.FirstOrDefaultAsync(x=>x.ProdusStocId==id);
            }
        }

        public async Task<List<ProdusStoc>> GetAll()
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.ProduseStoc.ToListAsync();
            }
        }

        public async Task Update(ProdusStoc entity, int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var current = ctx.ProduseStoc.FirstOrDefault();
                if (current is not null)
                {
                    current.Stoc = entity.Stoc;
                }
                else throw new Exception("Id Not Found!");
            }
        }
    }
}
