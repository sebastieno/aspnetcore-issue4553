using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using aspnetcore_issue4553.Models;

namespace aspnetcore_issue4553.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("")]
        public ActionResult Index([FromBody]CreationModel model)
        {
            return new ObjectResult(new
            {
                IsValid = ModelState.IsValid,
                Model = model
            });
        }

        [HttpPost]
        [Route("2")]
        public ActionResult Index2(CreationModel model)
        {
            return new ObjectResult(new
            {
                IsValid = ModelState.IsValid,
                Model = model
            });
        }

        [HttpPost]
        [Route("3")]
        public ActionResult Index3(CreationModel2 model)
        {
            return new ObjectResult(new
            {
                IsValid = ModelState.IsValid,
                Model = model
            });
        }
    }
}
