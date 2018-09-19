using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace aspnetapp.Controllers
{
    public class PlaceOrderController : OrdersBaseApiController
    {
        /// <summary>
        /// Add an order
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OrderModel order)
        {
            await Task.Delay(0); // Placeholder for code that also awaits

            return new NoContentResult();
        }
    }

    public class OrderModel
    {
        public string OrderId { get; set; }
    }

    /// <summary>
    /// The base controller for everything in the Orders Service Domain
    /// </summary>
    [Route("orders/[controller]", Name = "default-orders-[controller]")]
    public abstract class OrdersBaseApiController : BaseApiController
    {
        /// <summary>
        /// The swagger area that the operations belong to
        /// </summary>
        public const string SwaggerArea = "Orders Area";
    }

    /// <summary>
    /// The base controller used by all mover controllers
    /// </summary>
    [Produces("application/json")]
    [Route("/[controller]", Name = "default-[controller]")]
    public abstract class BaseApiController : Controller
    { }
}
