using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Abc.Facade;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft
{
    public class CreateModel : MeasuresPage
    {
        public CreateModel(IMeasuresRepository r) : base(r) { }

        public IActionResult OnGet() => Page();


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await data.Add(MeasureViewFactory.Create(MeasureView));

            return RedirectToPage("./Index");
        }

    }
}
