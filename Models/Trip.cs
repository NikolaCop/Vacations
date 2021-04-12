namespace Vacations.Models
{
    public class Trip : Vacation
    {
        public Trip(string destination, int date, string type) : base(destination, date, type)
        {
            Repositories = repositories;
        }
        public int Repositories { get; set; }
    }
}