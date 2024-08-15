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

            var value4 = _context.Deliveries.Where(x => x.Status == "Teslim Edildi").Count();
            await Clients.All.SendAsync("ReceiveTotalDeliveryCountStatusByTeslimEdildi", value4);
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
        public async Task GetDeliveryList()
        {
            var value = _context.Deliveries.ToList();
            await Clients.All.SendAsync("ReceiveDeliveryList", value);
        }
    }
}
