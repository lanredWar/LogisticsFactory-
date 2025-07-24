using LogisticsApp.Models;

namespace LogisticsApp.Services
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
