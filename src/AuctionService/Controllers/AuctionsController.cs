using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers;

[ApiController]
[Route("api/auctions")]
public class AuctionsController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> GetAllAuctions()
    {
        return "All auctions";
    }
}
