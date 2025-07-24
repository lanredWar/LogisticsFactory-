using LogisticsApp.Models;

namespace LogisticsApp.Services
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();

        public string PlanDelivery()
        {
            var transport = CreateTransport();
            return transport.Deliver();
        }
    }
}
