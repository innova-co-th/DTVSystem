using Microsoft.AspNetCore.Mvc.Rendering;


namespace DTVSystem.ViewModels
{
    public class PRA0010ViewModels
    {
        public List<SelectListItem> ddlProductionResultMode { get; set; }
        public List<SelectListItem> ddlShift { get; set; }
        public List<SelectListItem> GridHeader { get; set; }
        //public List<GridBody>  GBody { get; set; }
        public GridBody GBody { get; set; }

    }

    public class GridBody
    {
        public List<string> HeadColumn { get; set; }
        public List<string> line { get; set; }
        public List<Int16> Plan { get; set; }
        public List<Int16> Actual { get; set; }
        public List<Int16> Diff { get; set; }
        public List<Int16> ADiff { get; set; }
        public List<Int16> LineOut { get; set; }
        public List<Int16> LineIn { get; set; }
        public List<Int16> Throghput { get; set; }
        public List<Int16> Progress { get; set; }
        public List<string> OT { get; set; }
        public List<string> Status { get; set; }
    }
}
