using Microsoft.AspNetCore.Mvc.Rendering;


namespace DTVSystem.ViewModels
{
    public class PRA0010ViewModels
    {
        public List<SelectListItem> ddlProductionResultMode { get; set; }
        public List<SelectListItem> ddlShift { get; set; }
        public List<SelectListItem> GridHeader { get; set; }
        public List<GridBody>  GBody { get; set; }


    }

    public class GridBody
    {
        public List<string> line { get; set; }
        public List<string> Plan { get; set; }
        public List<string> Actual { get; set; }
        public List<string> Diff { get; set; }
    }
}
