using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using System.Data;

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

                       

            var ds = new DataSet();
            var dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("Subject"));
            dt.Columns.Add(new DataColumn("Line"));

            dr = dt.NewRow();
            dr["Subject"] = "Line(Assembly)";
            dr["Line"] = "R1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Subject"] = "Plan";
            dr["Line"] = "100";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Subject"] = "Actual";
            dr["Line"] = "100";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Subject"] = "Diff";
            dr["Line"] = "0";
            dt.Rows.Add(dr);

            ds.Tables.Add(dt);  
     

            return View(ds);
        }

       
    }
}
