using Microsoft.AspNetCore.Mvc;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProfileController: ControllerBase
{
    [HttpGet("{id:Guid}")]
    public IActionResult GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{name}")]
    public IActionResult GetByName(string name)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id:Guid}")]
    public IActionResult Update(Guid id)
    {
        throw new NotImplementedException();
    }
}
