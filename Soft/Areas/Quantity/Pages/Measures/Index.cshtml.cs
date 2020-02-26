using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Facade;
using Abc.Facade.Quantity;
using Abc.Pages.Quantity;
using Abc.Soft.Data;

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
