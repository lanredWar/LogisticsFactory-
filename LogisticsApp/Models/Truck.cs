namespace LogisticsApp.Models
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Delivering cago by land in a truck.";
        }
    }
}
