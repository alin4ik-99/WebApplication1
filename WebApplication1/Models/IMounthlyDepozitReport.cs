namespace WebApplication1.Models
{
    public interface IMounthlyDepozitReport
    {
        public int Mounth { get; set; }
        public double MounthDepozit { get; set; }
        public double MounthlyIncome { get; set; }
        public double MounthlyPlus { get; set; }

    }
}
