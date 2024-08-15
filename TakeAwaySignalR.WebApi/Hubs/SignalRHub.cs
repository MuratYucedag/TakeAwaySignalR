using Microsoft.AspNetCore.SignalR;
using TakeAwaySignalR.WebApi.DAL;

namespace TakeAwaySignalR.WebApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly Context _context;
        public SignalRHub(Context context)
        {
            _context = context;
        }
        public async Task TotalDeliveryCount()
        {
            var value1 = _context.Deliveries.Count();
            await Clients.All.SendAsync("ReceiveTotalDeliveryCount", value1);
        }
        public async Task TotalDeliveryCountStatusByYolda()
        {
            var value2 = _context.Deliveries.Where(x => x.Status == "Yolda").Count();
            await Clients.All.SendAsync("ReceiveTotalDeliveryCountStatusByYolda", value2);
        }
        public async Task TotalDeliveryCountStatusByHazirlaniyor()
        {
            var value3 = _context.Deliveries.Where(x => x.Status == "Hazirlaniyor").Count();
            await Clients.All.SendAsync("ReceiveTotalDeliveryCountStatusByHazirlaniyor", value3);
        }
    }
}
