using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace DTVSystem.Controllers
{
    public class ProductionResultAllController : Controller
    {
        public IActionResult ProductionResultAll()
        {

            //Creating the List of SelectListItem, this list you can bind from the database.
            List<SelectListItem> ProductionResultMode = new()
            {
                new SelectListItem { Value = "1", Text = "Real-Time Monitoring" },
                new SelectListItem { Value = "2", Text = "History" },
             
            };

            List<SelectListItem> Shift = new()
            {
                new SelectListItem { Value = "1", Text = "All" },
                new SelectListItem { Value = "2", Text = "A" },
                new SelectListItem { Value = "3", Text = "B" },

            };

            //assigning SelectListItem to view Bag
            ViewBag.ProductionResultMode = ProductionResultMode;
            ViewBag.shift = Shift;

            return View();
        }
    }
}
