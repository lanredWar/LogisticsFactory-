namespace LogisticsApp.Models
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Delivering cargo by sea in a ship.";
        }
    }
}
