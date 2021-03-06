﻿using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage: BasePage<IMeasuresRepository, Measure, MeasureView, MeasureData >
    {

        protected internal MeasuresPage(IMeasuresRepository r): base(r)
        { 
            PageTitle = "Measures";
        }

        public override string ItemId => Item?.Id??string.Empty;

        protected internal override string GetPageUrl() => "/Quantity/Measures";


        protected internal override Measure ToObject(MeasureView view)
        {
            return MeasureViewFactory.Create(view);
        }

        protected internal override MeasureView ToView(Measure obj)
        {
            return MeasureViewFactory.Create(obj);
        }
    }
}
