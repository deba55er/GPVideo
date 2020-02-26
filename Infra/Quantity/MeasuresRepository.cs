using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Infra.Quantity
{
    public class MeasuresRepository : IMeasuresRepository
    {
        private readonly QuantityDbContext db;
        public MeasuresRepository(QuantityDbContext c)
        {
            db = c;
        }
        public Task<List<Measure>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Measure> Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Add(Measure obj)
        {
            db.Measures.Add(obj.Data);
            await db.SaveChangesAsync();
        }

        public Task Update(Measure obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
