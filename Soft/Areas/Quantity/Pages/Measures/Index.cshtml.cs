using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Facade;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft
{
    public class IndexModel : MeasuresPage
    {
        public IndexModel(IMeasuresRepository r) : base(r) { }


        public async Task OnGetAsync()
        {
            var l = await data.Get();
            Items = new List<MeasureView>();

            foreach (var e in l)
            {
                Items.Add(MeasureViewFactory.Create(e));
            }
        }
    }
}
