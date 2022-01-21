using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTVSystem.Controllers
{
    public class MachineDownTimeAnalysisController : Controller
    {
        public IActionResult MCD0010()
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
            List<SelectListItem> ddlProcess = new()
            {
                new SelectListItem { Value = "1", Text = "Process name 1" },
                new SelectListItem { Value = "2", Text = "Process name 2" },
                new SelectListItem { Value = "3", Text = "Process name 3" },
                new SelectListItem { Value = "4", Text = "Process name 4" },

            };
            List<SelectListItem> ddlMachineG = new()
            {
                new SelectListItem { Value = "1", Text = "MachineG name 1" },
                new SelectListItem { Value = "2", Text = "MachineG name 2" },
                new SelectListItem { Value = "3", Text = "MachineG name 3" },
                new SelectListItem { Value = "4", Text = "MachineG name 4" },

            };
            List<SelectListItem> ddlMachine = new()
            {
                new SelectListItem { Value = "1", Text = "Machine name 1" },
                new SelectListItem { Value = "2", Text = "Machine name 2" },
                new SelectListItem { Value = "3", Text = "Machine name 3" },
                new SelectListItem { Value = "4", Text = "Machine name 4" },

            };

            ViewBag.DDlFactory = ddlFactoryName;
            ViewBag.DDlLine = ddlLine;
            ViewBag.DDlProcess = ddlProcess;
            ViewBag.DDlMachineG = ddlMachineG;
            ViewBag.DDlMachine = ddlMachine;

            return View();
        }

        [HttpPost]
        public ActionResult getSearch()
        {
            string lstdata = null;
            return Json(new { data = lstdata ,status = false});
        }
    }
}
