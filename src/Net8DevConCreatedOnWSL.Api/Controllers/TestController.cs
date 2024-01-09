using Microsoft.AspNetCore.Mvc;

namespace Net8DevConCreatedOnWSL.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        var result = "Hello Test .NET 8";

        return Ok(result);
    }
}