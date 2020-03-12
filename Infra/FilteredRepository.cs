using System;
using System.Linq;
using System.Linq.Expressions;
using Abc.Data.Common;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, ISearching
        where TData : PeriodData, new()
        where TDomain : Entity<TData>, new()
    {
        public string SearchString { get; set; }

        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s)
        {
        }

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query = base.createSqlQuery();
            query = AddFiltering(query);

            return query;
        }

        internal IQueryable<TData> AddFiltering(IQueryable<TData> query)
        {
            if (string.IsNullOrEmpty(SearchString)) return query;
            {


                //           s => s.Name.Contains(SearchString)
                //                  || s.Code.Contains(SearchString)
                //                  || s.Id.Contains(SearchString)
                //                  || s.Definition.Contains(SearchString)
                //                  || s.ValidFrom.ToString().Contains(SearchString)
                //                  || s.ValidTo.ToString().Contains(SearchString));
                var expression = CreateWhereExpression();

                return query.Where(expression);
            }


        }

        internal Expression<Func<TData, bool>> CreateWhereExpression()
        {
            var param = Expression.Parameter(typeof(TData), "s");
            Expression predicate = null;

            foreach (var p in typeof(TData).GetProperties())
            {
                var body = Expression.Property(param, p);
            }

            return Expression.Lambda<Func<TData, bool>>(predicate, param);
        }
    }
}
