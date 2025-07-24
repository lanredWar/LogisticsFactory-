using LogisticsApp.Models;

namespace LogisticsApp.Services
{
    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
