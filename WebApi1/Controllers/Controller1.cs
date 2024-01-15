using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller1 : ControllerBase
{

    [HttpGet(Name = "GetHello")]
    public IActionResult Get()
    {
        return new OkObjectResult(@"Hello!");
    }
}