using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using u19253738_HW06.Models;

namespace u19253738_HW06.Controllers
{
    public class HomeController : Controller
    {
        BikeStoresEntities db = new BikeStoresEntities();

        //public JsonResult BarChartDataEF()
        //{
        //    var data = db.SelectChartTest().ToList();
        //    Chart _chart = new Chart();
        //    _chart.labels = data.Select(x => x.Month).ToArray();
        //    _chart.datasets = new List<Datasets>();
        //    List<Datasets> _dataSet = new List<Datasets>();
        //    _dataSet.Add(new Datasets()
        //    {
        //        label = "Current Year",
        //        data = data.Select(x => x.Amount.Value).ToArray(),
        //        backgroundColor = new string[] { "#FFFFFF", "#000000", "#FF00000" },
        //        borderColor = new string[] { "#FFFFFF", "#000000", "#FF00000" },
        //        borderWidth = "1"

        //    });
        //    _chart.datasets = _dataSet;
        //    return Json(_chart, JsonRequestBehavior.AllowGet);


        }
}