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
    public class ComandaCRUD : IDBCrud<Comanda, int>
    {
        public async Task Create(Comanda entity)
        {
            using (EFContext ctx = new EFContext())
            {
                await ctx.Comenzi.AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var current = ctx.Comenzi.FirstOrDefault(x =>x.ComandaId == id);
                if (current != null)
                {
                    ctx.Comenzi.Remove(current);
                }
                else throw new Exception("Id not found!!!!!!");
            }
        }

        public async Task<Comanda> Get(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Comenzi.FirstOrDefaultAsync(x=>x.ComandaId==id);
            }
        }

        public async Task<List<Comanda>> GetAll()
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Comenzi.ToListAsync();
            }
        }

        public async Task Update(Comanda entity, int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var current = ctx.Comenzi.FirstOrDefault(x=>x.ComandaId==id);
                if (current != null)
                {
                    current.Numar=entity.Numar;
                    current.DataComanda=entity.DataComanda;
                    current.CostLivrare=entity.CostLivrare;
                    current.CostTotalProduse=entity.CostTotalProduse;
                }
                else throw new Exception("Not Found");
            }
        }
    }
}
