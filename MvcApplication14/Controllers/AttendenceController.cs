using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication14.Models;

namespace MvcApplication14.Controllers
{
    public class AttendenceController : Controller
    {
        //
        // GET: /Attendence/
        AttendenceContainer db = new AttendenceContainer();

        public ActionResult Index()
        {
            var batchname = db.Batches.ToList();
            return View(batchname);
        }
        public ActionResult Search(string drop)
        {
            var db = new AttendenceContainer();
            
            var batch = db.Students.Where(b => b.Batch.Name.ToLower().Contains(drop.ToLower()));
            return PartialView(batch);
        }
    }
}
