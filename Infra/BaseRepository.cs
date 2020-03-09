using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abc.Data.Common;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public class BaseRepository<TDomain, TData> : ICrudMethods<TDomain> 
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()
    {
        protected internal DbContext db;
        protected internal DbSet<TData> dbSet;
        public BaseRepository(DbContext c, DbSet<TData> s)
        {
            db = c;
            dbSet = s;
        }
        public Task<List<TDomain>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<TDomain> Get(string id)
        {
            if (id is null) return new TDomain();

            var d = await dbSet.FirstOrDefaultAsync(m => m.Id == id);

            var obj = new TDomain {Data = d};

            return obj;
        }

        public async Task Delete(string id)
        {
            if (id is null) return;
            var v = await dbSet.FindAsync(id);

            if (v is null) return;
            dbSet.Remove(v);
            await db.SaveChangesAsync();

        }

        public async Task Add(TDomain obj)
        {
            if (obj?.Data is null) return;
            dbSet.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public async Task Update(TDomain obj)
        {
            db.Attach(obj.Data).State = EntityState.Modified;

            try { await db.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MeasureViewExists(MeasureView.Id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                throw;
                //}
            }

        }
    }
}