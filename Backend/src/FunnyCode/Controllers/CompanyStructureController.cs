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

    [HttpGet("{id:Guid}")]
    public IActionResult GetDivisionById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{name}")]
    public IActionResult GetDivisionByName(string name)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{divisionId:Guid}")]
    public IActionResult GetSubdivisions(Guid divisionsId)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:Guid}")]
    public IActionResult GetSubdivisionById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{name}")]
    public IActionResult GetSubdivisionByName(string name)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{subdivisionId:Guid}")]
    public IActionResult GetTeams(Guid subdivisionsId)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:Guid}")]
    public IActionResult GetTeamById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{name}")]
    public IActionResult GetTeamByName(string name)
    {
        throw new NotImplementedException();
    }
}
