using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{

    [HttpGet]
    public IActionResult ParameterTest([FromQuery] string name)
    {
        return Ok(new { name });
    }
}