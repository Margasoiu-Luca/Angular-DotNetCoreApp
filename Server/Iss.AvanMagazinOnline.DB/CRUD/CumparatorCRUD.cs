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
    public class CumparatorCRUD : IDBCrud<Cumparator, int>
    {
        public async Task Create(Cumparator entity)
        {
            using (EFContext ctx = new EFContext())
            {
                await ctx.Cumparator.AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var toBeDeleted = await ctx.Cumparator.FirstOrDefaultAsync(x => x.CumparatorId == id);
                if (toBeDeleted != null)
                {
                    ctx.Cumparator.Remove(toBeDeleted);
                    await ctx.SaveChangesAsync();

                }
                else throw new Exception("Id Not Found");
            }
        }

        public async Task<Cumparator> Get(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Cumparator.FirstOrDefaultAsync(x => x.CumparatorId == id);
            }
        }

        public async Task<List<Cumparator>> GetAll()
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Cumparator.ToListAsync();
            }
        }

        public async Task Update(Cumparator entity, int id)
        {
            using (EFContext ctx = new EFContext())
            {
                var current = await ctx.Cumparator.FirstOrDefaultAsync(x=>x.CumparatorId==id);
                if (current != null)
                {
                    current.Nume = entity.Nume ?? current.Nume;
                    current.Prenume = entity.Prenume ?? current.Prenume;
                    current.DataNastere = entity.DataNastere;
                    current.TipPersoana = entity.TipPersoana;
                    current.DataNastere = entity.DataNastere;
                    current.Email = entity.Email;
                    current.MMId = entity.MMId;
                    current.CNP = entity.CNP;
                    current.TelefonMobil = entity.TelefonMobil;
                    await ctx.SaveChangesAsync();
                }
                else throw new Exception("Id Not Found!");
            }
        }
    }
}
