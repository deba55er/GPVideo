using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions
{
    public static class EditControlsForHtmlExtension
    {


        public static IHtmlContent EditControlsFor<TClassType, TPropertyType>(
            this IHtmlHelper<TClassType> htmlHelper, Expression<Func<TClassType, TPropertyType>> expression)
        {

            //<div class="form-group">
            //    <label asp-for="Item.Code" class="control-label"></label>
            //    <input asp-for="Item.Code" class="form-control" />
            //    <span asp-validation-for="Item.Code" class="text-danger"></span>
            //</div>

            var htmlStrings = new List<object>
            {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.EditorFor(expression,
                    new {htmlAttributes = new {@class = "form-control"}}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };

            return new HtmlContentBuilder(htmlStrings);
        }
    }
}
