using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTVSystem.Controllers
{
    public class CTMasterController : Controller
    {
        public IActionResult MAS0010()
        {
            List<SelectListItem> ddlFactoryName = new()
            {
                new SelectListItem { Value = "1", Text = "Factory1" },
                new SelectListItem { Value = "2", Text = "Factory2" },

            };
            List<SelectListItem> ddlLine = new()
            {
                new SelectListItem { Value = "1", Text = "Line name 1" },
                new SelectListItem { Value = "2", Text = "Line name 2" },
                new SelectListItem { Value = "3", Text = "Line name 3" },

            };

            ViewBag.DDlFactory = ddlFactoryName;
            ViewBag.DDlLine = ddlLine;

            return View();
        }
    }
}
