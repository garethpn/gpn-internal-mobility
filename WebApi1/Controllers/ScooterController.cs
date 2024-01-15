using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers;

[ApiController]
[Route("[controller]")]
public class ScooterController : ControllerBase
{

    [HttpGet(Name = "GetHello")]
    public IActionResult Get()
    {
        var scooterCode = Guid.NewGuid();
        
        return new OkObjectResult(@scooterCode);
    }
    
    
}