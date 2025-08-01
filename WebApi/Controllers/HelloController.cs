using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Cambio mensaje para hacer commit");
}
