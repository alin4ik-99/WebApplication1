using System.Runtime.Serialization;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    
    public class MounthlyDepozitReport
    {
    
        public int Mounth { get; set; }
       
        public double MounthDepozit { get; set;}
        public double MounthlyIncome { get; set; }

        public double MounthlyPlus { get; set; }

        public MounthlyDepozitReport(int mounth, double mounthdepozit, double mounthlyincome, double mounthlyplus) 
        { 
            Mounth = mounth;
            MounthDepozit = mounthdepozit;
            MounthlyIncome = mounthlyincome;
            MounthlyPlus = mounthlyplus;
        }

    }
}
