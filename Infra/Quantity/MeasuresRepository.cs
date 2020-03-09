﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra.Quantity
{
    public class MeasuresRepository : PaginatedRepository<Measure>, IMeasuresRepository
    {
        
        public async Task<List<Measure>> Get()
        {

            var list = await createPaged (createFiltered(createSorted()));

            HasNextPage = list.HasNextPage;
            HasPreviousPage = list.HasPreviousPage;

            return list.Select(e => new Measure(e)).ToList();
        }

        private async Task <PaginatedList<MeasureData>> createPaged(IQueryable<MeasureData> dataSet)
        {
            return await PaginatedList<MeasureData>.CreateAsync(
                dataSet, PageIndex, PageSize);
        }

        private IQueryable<MeasureData> createFiltered(IQueryable<MeasureData> set)
        {
            if (String.IsNullOrEmpty(SearchString)) return set;
            {
               return set.Where(s => s.Name.Contains(SearchString)
                                                   || s.Code.Contains(SearchString)
                                                   || s.Id.Contains(SearchString)
                                                   || s.Definition.Contains(SearchString)
                                                   || s.ValidFrom.ToString().Contains(SearchString)
                                                   || s.ValidTo.ToString().Contains(SearchString));
            }
        }

        private IQueryable<MeasureData> createSorted()
        {
            IQueryable<MeasureData> measures = from s in db.Measures
                select s;

            switch (SortOrder)
            {
                case "name_desc":
                    measures = measures.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    measures = measures.OrderBy(s => s.ValidFrom);
                    break;
                case "date_desc":
                    measures = measures.OrderByDescending(s => s.ValidFrom);
                    break;
                default:
                    measures = measures.OrderBy(s => s.Name);
                    break;
            }

            return measures.AsNoTracking();
        }


    }
}
