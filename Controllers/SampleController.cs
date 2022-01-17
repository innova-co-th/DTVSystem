using Microsoft.AspNetCore.Mvc;

namespace DTVSystem.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult PatternList()
        {
            return View();
        }
    }
}
