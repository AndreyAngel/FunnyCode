using Microsoft.AspNetCore.Mvc;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProjectController : ControllerBase
{
    /// <summary>
    /// Get all projects
    /// </summary>
    /// <returns>List of all projects</returns>
    /// <response code = "201">Successful completion</response>
    [HttpGet]
    public IActionResult GetAllProjects()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{teamId:Guid}")]
    public IActionResult GetProjectByTeamId(Guid teamId)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{divisionId:Guid}")]
    public IActionResult GetProjectsByDivisionId(Guid divisionId)
    {
        throw new NotImplementedException();
    }
}
