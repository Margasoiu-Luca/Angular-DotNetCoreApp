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
    public class CategorieProdusCrud : IDBCrud<CategorieProdus, int>
    {
        public async Task Create(CategorieProdus entity)
        {

            using (EFContext ctx = new EFContext())
            {
                await ctx.CategoriiProdus.AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var x = await ctx.CategoriiProdus.FirstOrDefaultAsync(x => x.CategorieProdusId == id);
                if (x != null)
                {
                    ctx.CategoriiProdus.Remove(x);
                    await ctx.SaveChangesAsync();
                }
            }
        }

        public async Task<CategorieProdus> Get(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.CategoriiProdus.FirstOrDefaultAsync(x => x.CategorieProdusId == id);
            }
        }

        public async Task<List<CategorieProdus>> GetAll()
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.CategoriiProdus.ToListAsync();
            }
        }

        public async Task Update(CategorieProdus entity, int id)
        {
            using (EFContext ctx = new EFContext())
            {

                CategorieProdus current = await ctx.CategoriiProdus.FirstOrDefaultAsync(x => x.CategorieProdusId == id);
                if (current is null)
                {
                    throw new Exception("Id Not Found");
                }
                else
                {
                    current.DenumireCategorieProdus = entity.DenumireCategorieProdus;
                    await ctx.SaveChangesAsync();
                }
            }
        }
    }
  
}
