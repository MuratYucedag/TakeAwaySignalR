using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAwaySignalR.WebApi.DAL;

namespace TakeAwaySignalR.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly Context _context;
        public DefaultController(Context context)
        {
            _context = context;
        }

        [HttpGet("TotalDeliveryCount")]
        public IActionResult TotalDeliveryCount()
        {
            var value = _context.Deliveries.Count();
            return Ok(value);
        }

        [HttpGet("TotalDeliveryCountStatusByYolda")]
        public IActionResult TotalDeliveryCountStatusByYolda()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Yolda").Count();
            return Ok(value);
        }

        [HttpGet("TotalDeliveryCountStatusByHazirlaniyor")]
        public IActionResult TotalDeliveryCountStatusByHazirlaniyor()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Hazirlaniyor").Count();
            return Ok(value);
        }
    }
}
