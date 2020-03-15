using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage: PageModel
    {
        protected internal readonly IMeasuresRepository db;

        protected internal MeasuresPage(IMeasuresRepository r)
        {
            db = r;
            PageTitle = "Measures";
        }

        [BindProperty]
        public MeasureView Item { get; set; }
        public IList<MeasureView> Items { get; set; }


        public string PageTitle { get; set; }
        public string ItemId => Item.Id;
        public string PageSubTitle { get; set; } = "";
        public string CurrentSort { get; set; } = "Current Filter";
        public string CurrentFilter { get; set; } = "Current filter";
        public int PageIndex { get; set; } = 3;
        public int TotalPages { get; set; } = 10;

        protected internal async Task<bool> AddObject()
        {
            if (!ModelState.IsValid) return false;
            try
            {
                await db.Add(MeasureViewFactory.Create(Item));
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
