﻿using System;
using System.Linq;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Infra.Quantity
{
    public class MeasuresRepository : UniqueEntityRepository<Measure, MeasureData>, IMeasuresRepository
    {
        public MeasuresRepository(QuantityDbContext c) : base(c, c.Measures) { }

        protected internal override Measure ToDomainObject(MeasureData d) => new Measure(d);
        
    }
}
