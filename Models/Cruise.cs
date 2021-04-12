namespace Vacations.Models
{
    public class Cruise : Vacation
    {
        public Cruise(string destination, int date, string type) : base(destination, date, type)
        {
            Repositories = repositories;
        }
        public int Repositories { get; set; }
    }
}