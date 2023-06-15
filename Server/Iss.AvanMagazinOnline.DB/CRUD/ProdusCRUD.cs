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
    public class ProdusCRUD : IDBCrud<Produs, int>
    {
        public async Task Create(Produs entity)
        {
            using (EFContext ctx = new EFContext())
            {
                await ctx.Produse.AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var toBeDeleted = await ctx.Produse.FirstOrDefaultAsync(x => x.ProdusId == id);
                if (toBeDeleted != null)
                {
                    ctx.Produse.Remove(toBeDeleted);
                    await ctx.SaveChangesAsync();

                }
                else throw new Exception("Id Not Found");
            }
        }

        public async Task<Produs> Get(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Produse.FirstOrDefaultAsync(x=>x.ProdusId==id);
            }
        }

        public async Task<List<Produs>> GetAll()
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Produse.ToListAsync();
            }
        }

        public async Task Update(Produs entity, int id)
        {
            using (EFContext ctx = new EFContext())
            {
                Produs current = await ctx.Produse.FirstOrDefaultAsync(x => x.ProdusId == id);
                if (current is null)
                {
                    throw new Exception("Id Not Found");
                }
                else
                {
                    current.DenumireProdus=entity.DenumireProdus?? current.DenumireProdus;
                    current.CostProdus=entity.CostProdus;
                    current.DescriereProdus=entity.DescriereProdus;
                    current.DataInceput = entity.DataInceput;
                    current.DataSfarsit=entity.DataSfarsit;
                    current.CategorieProdusId=entity.CategorieProdusId;
                    current.ProducatorId=entity.ProducatorId;
                    await ctx.SaveChangesAsync();
                }
            }
        }
    }
}
