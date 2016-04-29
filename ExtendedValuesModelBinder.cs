using Microsoft.AspNet.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspnetcore_issue4553
{
    public class ExtendedValuesModelBinder : IModelBinder
    {
        public async Task<ModelBindingResult> BindModelAsync(ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue("company");
            if (string.IsNullOrEmpty(value.FirstValue))
            {
                bindingContext.ModelState.AddModelError("company", "Value is mandatory");
            }


            return ModelBindingResult.Success(bindingContext.ModelName, new Dictionary<string, string>
            {
                { "company", value.FirstValue }
            });
        }
    }
}
