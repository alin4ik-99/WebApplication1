using System.Runtime.Serialization;

namespace WebApplication1.Models
{

    public class Depozit1
    {

        public IMounthlyDepozitReport mounthlyDepozitReport;
        public Depozit1(IMounthlyDepozitReport mounthlyDepozitReport)
        { 
            this.mounthlyDepozitReport = mounthlyDepozitReport;
        }


        public double StartDepozit { get; set; }
        public double MounthPlus { get; set; }
        public double YearProcent { get; set; }
        public int TerminInMounth { get; set; }


        public double MounthProcent(double yearprocent)
        {
            return (double)(Math.Pow((1.0 + (double)yearprocent / 100.0), 1 / 12D) - 1) * 100;
        }


        public string[] DifficultProcent()
        {

            string[] depozit = new string[TerminInMounth];

            for (int i = 0; i < TerminInMounth; i++)

            {
                double MounthlyIncm = StartDepozit * (MounthProcent(YearProcent) / 100);
                StartDepozit = StartDepozit + MounthlyIncm;
                StartDepozit += MounthPlus;

                mounthlyDepozitReport.Mounth = i + 1;
                mounthlyDepozitReport.MounthDepozit = StartDepozit;
                mounthlyDepozitReport.MounthlyIncome = MounthlyIncm;
                mounthlyDepozitReport.MounthlyPlus = MounthPlus;

                string json = System.Text.Json.JsonSerializer.Serialize(mounthlyDepozitReport);

                depozit[i] = json;

            }

            return depozit;
        }

    }
}
