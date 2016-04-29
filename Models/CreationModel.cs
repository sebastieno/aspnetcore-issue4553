using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_issue4553.Models
{
    public class CreationModel
    {
        public string Name { get; set; }

        [ModelBinder(BinderType = typeof(ExtendedValuesModelBinder))]
        public Dictionary<string, string> ExtendedValues { get; set; }
    }
}
