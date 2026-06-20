using System;
using System.Linq;
using System.Web.Mvc;
using MedicoreHospital.Models;

namespace MedicoreHospital.Controllers
{
    public class HomeController : Controller
    {
        private HospitalContext db = new HospitalContext();

        public ActionResult Index()
        {
            // 1. GCN 4 Stat: Total Discharged Patients
            ViewBag.DischargedCount = db.Admissions.Count(a => a.DischargeDate != null);

            // 2. GCN 4 Stat: Emergency Admissions (Ward named Emergency)
            ViewBag.EmergencyCount = db.Admissions.Count(a => a.WardName.ToLower() == "emergency");

            // 3. GCN 4 Stat: Active Patients
            ViewBag.ActivePatients = db.Admissions.Count(a => a.DischargeDate == null);

            // 4. Registration-Based Component (Derived from last 2 digits of ID 58326 -> 26)
            ViewBag.AuditCapacityScore = 26 + db.Patients.Count();

            return View();
        }
    }
    }