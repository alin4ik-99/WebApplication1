using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Runtime.Serialization.Json;
using WebApplication1.Models;
using System.Text.Json;

namespace WebApplication1.Controllers
{
     

    public class DepozitController : Controller
    {
        // [HttpGet, Route("depozit")] depozit?startdepozit=100&mounthplus=10&yearprocent=10&termininmounth=3

        [HttpGet(template: "/depozit")]

        public string[] Depozit(double StartDepozit, double MounthPlus, double YearProcent, int TerminInMounth)
        {

            Depozit1 Dep = new Depozit1(new MounthlyDepozitReport());
            Dep.StartDepozit = StartDepozit;
            Dep.MounthPlus = MounthPlus;
            Dep.YearProcent = YearProcent;
            Dep.TerminInMounth = TerminInMounth;

            return Dep.DifficultProcent();

        }
    }
}
