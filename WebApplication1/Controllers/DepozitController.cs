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
           
           double MounthProcent(double yearprocent)
           {
                   return (double)(Math.Pow((1.0 + (double)yearprocent / 100.0), 1 / 12D) - 1) * 100;
           }
 
       
            string[] depozit = new string[TerminInMounth];

            for (int i = 0; i < TerminInMounth; i++)
            {
                double MounthlyIncm = StartDepozit * (MounthProcent(YearProcent) / 100);
                StartDepozit = StartDepozit + MounthlyIncm;
                StartDepozit += MounthPlus;
            

                MounthlyDepozitReport MounthlyReport = new MounthlyDepozitReport(i+1, StartDepozit, MounthlyIncm, MounthPlus);

                string json = System.Text.Json.JsonSerializer.Serialize(MounthlyReport);

                depozit[i] = json;

            }

            return depozit;
            
        }
    }
}
