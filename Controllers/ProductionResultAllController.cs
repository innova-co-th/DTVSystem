using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace DTVSystem.Controllers
{
    public class ProductionResultAllController : Controller
    {

        public IActionResult ProductionResultAll()
        {
            DTVSystem.ViewModels.PRA0010ViewModels model = new ViewModels.PRA0010ViewModels();

            //Filter ----(+)

            List<SelectListItem> ProductionResultMode = new()
            {
                new SelectListItem { Value = "1", Text = "Real-Time Monitoring" },
                new SelectListItem { Value = "2", Text = "History" },

            };
            model.ddlProductionResultMode = ProductionResultMode;

            List<SelectListItem> Shift = new()
            {
                new SelectListItem { Value = "0", Text = "All" },
                new SelectListItem { Value = "1", Text = "A" },
                new SelectListItem { Value = "2", Text = "B" },

            };
            model.ddlShift = Shift;
            //Filter ----(-)






            List<SelectListItem> FactoryList = new List<SelectListItem>();
            SelectListItem item0 = new SelectListItem
            {
                Text = "Factory",
                Value = "0",
            };
            FactoryList.Add(item0);
            SelectListItem item1 = new SelectListItem
            {
                Text = "Factory1",
                Value = "5",
            };
            FactoryList.Add(item1);
            SelectListItem item2 = new SelectListItem
            {
                Text = "Factory2",
                Value = "2",
            };
            FactoryList.Add(item2);
            model.GridHeader = FactoryList;

            DTVSystem.ViewModels.GridBody AllLine = new ViewModels.GridBody();
            AllLine.HeadColumn = new List<string> { "Line (Assembly)", "Plan", "Actual", "Diff", "A.Diff", "Line out", "Line in", "Throughput", "Progress" };
            AllLine.line =  new List<string> { "R1","R1B","R4", "R6", "F1", "R5A", "F2"};
            AllLine.Plan = new List<Int16> { 100, 100, 100, 100, 100, 100, 100 };
            AllLine.Actual = new List<Int16> {  100, 100, 100, 100, 100, 100, 100 };
            AllLine.Diff = new List<Int16> { 0, 0, 50, 0, 0, 0, 0 };
            AllLine.ADiff = new List<Int16> {  55, 60, 75, 60, 55, 60, 70 };
            AllLine.LineOut = new List<Int16> {  2, 3, 3, 0, 0, 2, 2 };
            AllLine.LineIn = new List<Int16> {  2, 2, 2, 0, 0, 1, 0 };
            AllLine.Throghput = new List<Int16> {  103, 103, 52, 100, 100, 104, 102 };
            AllLine.Progress = new List<Int16> {  100, 100, 50, 100, 100, 100, 100 };


            //model.GBody = new List<ViewModels.GridBody>();
            //model.GBody.Add( AllLine);
            model.GBody = new ViewModels.GridBody();
            model.GBody = AllLine;
            return View(model);
        }
        //    public IActionResult ProductionResultAll()
        //{

        //    //Creating the List of SelectListItem, this list you can bind from the database.
        //    List<SelectListItem> ProductionResultMode = new()
        //    {
        //        new SelectListItem { Value = "1", Text = "Real-Time Monitoring" },
        //        new SelectListItem { Value = "2", Text = "History" },
             
        //    };

        //    List<SelectListItem> Shift = new()
        //    {
        //        new SelectListItem { Value = "1", Text = "All" },
        //        new SelectListItem { Value = "2", Text = "A" },
        //        new SelectListItem { Value = "3", Text = "B" },

        //    };

        //    //assigning SelectListItem to view Bag
        //    ViewBag.ProductionResultMode = ProductionResultMode;
        //    ViewBag.shift = Shift;

                       
        //    // create datatable//-------------------(+)
        //    var ds = new DataSet();
        //    var dt = new DataTable();
        //    DataRow dr;
        //    var dtLine = new DataTable();
        //    DataRow drLine;
            
            
        //    dtLine.Columns.Add("FactoryID", typeof(string));
        //    dtLine.Columns.Add("FactoryName", typeof(string));
        //    dtLine.Columns.Add("LineID" , typeof(string));
        //    dtLine.Columns.Add("LineName" , typeof(string));

        //    dtLine.Columns.Add("Plan", typeof(Int16));
        //    dtLine.Columns.Add("Actual" , typeof(Int16));
        //    dtLine.Columns.Add("Diff" , typeof(Int16));
        //    dtLine.Columns.Add("ADiff" , typeof(Int16));
        //    dtLine.Columns.Add("Lineout" , typeof(Int16));
        //    dtLine.Columns.Add("Linein", typeof(Int16));
        //    dtLine.Columns.Add("Throughput", typeof(Int16));
        //    dtLine.Columns.Add("Progress", typeof(string));
        //    dtLine.Columns.Add(new DataColumn("OT"));
        //    dtLine.Columns.Add(new DataColumn("STATUS"));


        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "01";
        //    drLine["FactoryName"] = "Factory1";
        //    drLine["LineID"] = "01";
        //    drLine["LineName"] = "R1";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 100;
        //    drLine["Diff"] = 0;
        //    drLine["ADiff"] = 55;
        //    drLine["Lineout"] = 2;
        //    drLine["Linein"] = 2;
        //    drLine["Throughput"] = 103;
        //    drLine["Progress"] = "100%";

        //    dtLine.Rows.Add(drLine);

        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "01";
        //    drLine["FactoryName"] = "Factory1";
        //    drLine["LineID"] = "02";
        //    drLine["LineName"] = "R1B";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 100;
        //    drLine["Diff"] = 0;
        //    drLine["ADiff"] = 60;
        //    drLine["Lineout"] = 3;
        //    drLine["Linein"] = 2;
        //    drLine["Throughput"] = 103;
        //    drLine["Progress"] = "100%";

        //    dtLine.Rows.Add(drLine);

        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "01";
        //    drLine["FactoryName"] = "Factory1";
        //    drLine["LineID"] = "03";
        //    drLine["LineName"] = "R4";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 50;
        //    drLine["Diff"] = 50;
        //    drLine["ADiff"] = 75;
        //    drLine["Lineout"] = 3;
        //    drLine["Linein"] = 2;
        //    drLine["Throughput"] = 52;
        //    drLine["Progress"] = "50%";

        //    dtLine.Rows.Add(drLine);

        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "01";
        //    drLine["FactoryName"] = "Factory1";
        //    drLine["LineID"] = "04";
        //    drLine["LineName"] = "R6";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 100;
        //    drLine["Diff"] = 0;
        //    drLine["ADiff"] = 60;
        //    drLine["Lineout"] = 0;
        //    drLine["Linein"] = 0;
        //    drLine["Throughput"] = 100;
        //    drLine["Progress"] = "100%";

        //    dtLine.Rows.Add(drLine);

        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "01";
        //    drLine["FactoryName"] = "Factory1";
        //    drLine["LineID"] = "05";
        //    drLine["LineName"] = "F1";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 100;
        //    drLine["Diff"] = 0;
        //    drLine["ADiff"] = 55;
        //    drLine["Lineout"] = 0;
        //    drLine["Linein"] = 0;
        //    drLine["Throughput"] = 100;
        //    drLine["Progress"] = "100%";

        //    dtLine.Rows.Add(drLine);

        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "02";
        //    drLine["FactoryName"] = "Factory2";
        //    drLine["LineID"] = "06";
        //    drLine["LineName"] = "R5A";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 100;
        //    drLine["Diff"] = 0;
        //    drLine["ADiff"] = 60;
        //    drLine["Lineout"] = 2;
        //    drLine["Linein"] = 1;
        //    drLine["Throughput"] = 104;
        //    drLine["Progress"] = "100%";

        //    dtLine.Rows.Add(drLine);

        //    drLine = dtLine.NewRow();
        //    drLine["FactoryID"] = "02";
        //    drLine["FactoryName"] = "Factory2";
        //    drLine["LineID"] = "07";
        //    drLine["LineName"] = "F2";
        //    drLine["Plan"] = 100;
        //    drLine["Actual"] = 100;
        //    drLine["Diff"] = 0;
        //    drLine["ADiff"] = 70;
        //    drLine["Lineout"] = 2;
        //    drLine["Linein"] = 0;
        //    drLine["Throughput"] = 102;
        //    drLine["Progress"] = "100%";

        //    dtLine.Rows.Add(drLine);

          
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            dt.Columns.Add(new DataColumn("0"));
        //        }
        //        else
        //        {                    
        //            dt.Columns.Add(new DataColumn(i.ToString()));
        //        }
        //    }

        //    //1.Factory
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count +1); i++)
        //    {               
        //        if (i == 0 )
        //        {
        //            //Columns Name                   
        //            dr[i] = "Factory";
        //        }
        //       else
        //        {
        //            dr[i] = dtLine.Rows[i-1]["FactoryName"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    //2.Line
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Line(Assembly)";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["LineName"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    //3.Plan
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Plan";
        //        }
        //        else
        //        {
        //            dr[i] = Int16.Parse(dtLine.Rows[i - 1]["Plan"].ToString());  
        //        }
        //    }
        //    dt.Rows.Add(dr);


        //    //4.Actual
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Actual";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["Actual"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    //5.Diff
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Diff";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["Diff"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    //6.ADiff
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "ADiff";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["ADiff"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    //7.Lineout
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Line out";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["Lineout"];
        //        }
        //    }
        //    dt.Rows.Add(dr);


        //    //8.Linein
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Line in";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["Linein"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    //9.Throughput
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Throughput";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["Throughput"];
        //        }
        //    }
        //    dt.Rows.Add(dr);


        //    //9.Progress
        //    dr = dt.NewRow();
        //    for (int i = 0; i < (dtLine.Rows.Count + 1); i++)
        //    {
        //        if (i == 0)
        //        {
        //            //Columns Name                   
        //            dr[i] = "Progress";
        //        }
        //        else
        //        {
        //            dr[i] = dtLine.Rows[i - 1]["Progress"];
        //        }
        //    }
        //    dt.Rows.Add(dr);

        //    ds.Tables.Add(dt);

        //    // create datatable//-------------------(-)


        //    return View(ds);
        //}

       
    }
}
