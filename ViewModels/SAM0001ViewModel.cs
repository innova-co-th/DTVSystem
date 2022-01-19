using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTVSystem.ViewModels
{
    public class SAM0001ViewModel
    {
        public string? Title { get; set; }
        public string? Mode { get; set; }
        public string? CreateInfo { get; set; }
        public string? UpdateInfo { get; set; }
        public List<SelectListItem> CustomerListItem { get; set; }
    }
}
