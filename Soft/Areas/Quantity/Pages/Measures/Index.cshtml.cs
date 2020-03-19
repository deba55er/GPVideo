using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {

        public IndexModel(IMeasuresRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            await GetList(sortOrder, currentFilter, searchString, pageIndex);
        }


    }
}
