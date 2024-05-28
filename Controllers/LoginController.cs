using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace login.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetLogin")]
    public IActionResult Get()
    {
        return Ok("This is the login GET response");
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        ArrayList list = new ArrayList();
        list.Add(id);
        return Ok(list);
    }
}
