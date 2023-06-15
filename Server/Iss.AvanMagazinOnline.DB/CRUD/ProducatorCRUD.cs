using Azure.Core;
using ConsoleApp5.Data;
using Iss.AvanMagazinOnline.DB.Interfaces;
using Iss.AvanMagazinOnline.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.CRUD
{
    public class ProducatorCRUD : IDBCrud<Producator, int>
    {
        public async Task Create(Producator entity)
        {
            using (EFContext ctx = new EFContext())
            {
                await ctx.Producatori.AddAsync(entity);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (EFContext ctx = new EFContext())
            using (await ctx.Database.BeginTransactionAsync())
            {
                var toBeDeleted = await ctx.Producatori.FirstOrDefaultAsync(x => x.ProducatorId == id);
                if (toBeDeleted != null)
                {
                   
                    ctx.Producatori.Remove(toBeDeleted);
                    await ctx.SaveChangesAsync();
                    await ctx.Database.CommitTransactionAsync();
                }
                else
                {
                    throw new Exception("Id Not Found");
                    ctx.Database.RollbackTransaction();
                } 
                    
            }

        }

        public async Task<Producator> Get(int id)
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Producatori.FirstOrDefaultAsync(x=>x.ProducatorId==id) is not null? await ctx.Producatori.FirstOrDefaultAsync(x => x.ProducatorId == id) : throw new Exception("Nu a fost gasit Id-ul");
            }
        }

        public async Task<List<Producator>> GetAll()
        {
            using (EFContext ctx = new EFContext())
            {
                return await ctx.Producatori.ToListAsync();
            }

        }

        public async Task Update(Producator entity, int id)
        {
            using (EFContext ctx = new EFContext())
            {
                Producator current = await ctx.Producatori.FirstOrDefaultAsync(x => x.ProducatorId == id);
                if (current is null)
                {
                    throw new Exception("Id Not Found");
                }
                else
                {
                    current.DataInceput=entity.DataInceput;
                    current.DataSfarsit=entity.DataSfarsit;
                    current.Nume=entity.Nume;
                    current.Adresa=entity.Adresa;
                    current.ProducatorIdCt=entity.ProducatorIdCt;
                    await ctx.SaveChangesAsync();
                }
            }
        }
    }
    }
