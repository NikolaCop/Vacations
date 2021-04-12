
namespace Vacations.Models
{
    public abstract class Vacation
    {
        protected Vacation(string destination, int date, string type)
        {
            Destination = destination;
            Date = date;
            Type = type;
        }

        public string Destination { get; set; }
        public int Date { get; set; }
        public string Type { get; set; }

    }
}