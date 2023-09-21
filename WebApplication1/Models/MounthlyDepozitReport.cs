using System.Runtime.Serialization;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    
    public class MounthlyDepozitReport : IMounthlyDepozitReport
    {
    
        public int Mounth { get; set; }
        public double MounthDepozit { get; set;}
        public double MounthlyIncome { get; set; }
        public double MounthlyPlus { get; set; }

    }
}
