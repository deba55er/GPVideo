using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
namespace Abc.Soft
{
    public class DetailsModel : MeasuresPage
    {
        public DetailsModel(IMeasuresRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();
            
            Item = MeasureViewFactory.Create(await data.Get(id));

            if (Item == null) return NotFound();
            
            return Page();
        }
    }
}
