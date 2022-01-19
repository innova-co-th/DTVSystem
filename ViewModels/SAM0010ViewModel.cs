using Microsoft.AspNetCore.Mvc.Rendering;

namespace DTVSystem.ViewModels
{
    public class SAM0010ViewModel
    {
        public string? Title { get; set; }
        public string? Mode { get; set; }
        public string? CreateInfo { get; set; }
        public string? UpdateInfo { get; set; }
        public Models.CompanyModel CompanyModel { get; set; }
        public List<Models.CompanyModel> CompanyModelList { get; set; }
    }
}
