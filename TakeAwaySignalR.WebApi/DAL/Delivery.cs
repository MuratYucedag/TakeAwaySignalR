namespace TakeAwaySignalR.WebApi.DAL
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string Product { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}