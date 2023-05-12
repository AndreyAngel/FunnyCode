using Microsoft.AspNetCore.Mvc;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CompanyStructureController : ControllerBase
{
    [HttpGet]
    public IActionResult GetDivisions()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{divisionId:Guid}")]
    public IActionResult GetSubdivisions(Guid divisionsId)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{subdivisionId:Guid}")]
    public IActionResult GetTeams(Guid subdivisionsId)
    {
        throw new NotImplementedException();
    }
}
