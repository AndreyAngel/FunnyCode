using FunnyCode.Domain.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CompanyStructureController : ControllerBase
{
    /// <summary>
    /// Get all divisions
    /// </summary>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    [HttpGet]
    [Authorize(Policy = "ChangingOfCatalog")]
    [ProducesResponseType(typeof(), (int)HttpStatusCode.Created)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.Conflict)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetDivisions()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get division by Id
    /// </summary>
    /// <param name="id"> Division Id </param>
    /// <returns></returns>
    [HttpGet("{id:Guid}")]
    public IActionResult GetDivisionById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get division by name
    /// </summary>
    /// <param name="name"> Division name </param>
    /// <returns></returns>
    [HttpGet("{name}")]
    public IActionResult GetDivisionByName(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all subdivisions by division Id
    /// </summary>
    /// <param name="divisionId"> Division Id </param>
    /// <returns></returns>
    [HttpGet("{divisionId:Guid}")]
    public IActionResult GetSubdivisions(Guid divisionId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get subdivision by Id
    /// </summary>
    /// <param name="id"> Subdivision Id </param>
    /// <returns></returns>
    [HttpGet("{id:Guid}")]
    public IActionResult GetSubdivisionById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get subdivision by name
    /// </summary>
    /// <param name="name"> Subdivision name </param>
    /// <returns></returns>
    [HttpGet("{name}")]
    public IActionResult GetSubdivisionByName(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all teams by subdivision Id
    /// </summary>
    /// <param name="subdivisionId"> Subdivision Id </param>
    /// <returns></returns>
    [HttpGet("{subdivisionId:Guid}")]
    public IActionResult GetTeams(Guid subdivisionId)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Get team by Id
    /// </summary>
    /// <param name="id"> Team Id </param>
    /// <returns></returns>
    [HttpGet("{id:Guid}")]
    public IActionResult GetTeamById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get team by name
    /// </summary>
    /// <param name="name"> Team name </param>
    /// <returns></returns>
    [HttpGet("{name}")]
    public IActionResult GetTeamByName(string name)
    {
        throw new NotImplementedException();
    }
}
