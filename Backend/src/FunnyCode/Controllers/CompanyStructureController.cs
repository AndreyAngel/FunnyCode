using FunnyCode.Models.DTO.Responses;
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
    [ProducesResponseType(typeof(List<DivisionListDTOResponse>), (int)HttpStatusCode.OK)]
    public IActionResult GetDivisions()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get division by Id
    /// </summary>
    /// <param name="id"> Division Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Division with this Id wasn't founded </response>
    [HttpGet("{id:Guid}")]
    [ProducesResponseType(typeof(DivisionDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetDivisionById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get division by name
    /// </summary>
    /// <param name="name"> Division name </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Division with this name wasn't founded </response>
    [HttpGet("{name}")]
    [ProducesResponseType(typeof(DivisionDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetDivisionByName(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all subdivisions by division Id
    /// </summary>
    /// <param name="divisionId"> Division Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    [HttpGet("{divisionId:Guid}")]
    [ProducesResponseType(typeof(List<SubdivisionListDTOResponse>), (int)HttpStatusCode.OK)]
    public IActionResult GetSubdivisions(Guid divisionId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get subdivision by Id
    /// </summary>
    /// <param name="id"> Subdivision Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Subivision with this Id wasn't founded </response>
    [HttpGet("{id:Guid}")]
    [ProducesResponseType(typeof(SubdivisionDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetSubdivisionById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get subdivision by name
    /// </summary>
    /// <param name="name"> Subdivision name </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Subivision with this name wasn't founded </response>
    [HttpGet("{name}")]
    [ProducesResponseType(typeof(SubdivisionDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetSubdivisionByName(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get all teams by subdivision Id
    /// </summary>
    /// <param name="subdivisionId"> Subdivision Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    [HttpGet("{subdivisionId:Guid}")]
    [ProducesResponseType(typeof(List<TeamListDTOResponse>), (int)HttpStatusCode.OK)]
    public IActionResult GetTeams(Guid subdivisionId)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Get team by Id
    /// </summary>
    /// <param name="id"> Team Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Team with this Id wasn't founded </response>
    [HttpGet("{id:Guid}")]
    [ProducesResponseType(typeof(TeamDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetTeamById(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Get team by name
    /// </summary>
    /// <param name="name"> Team name </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Team with this name wasn't founded </response>
    [HttpGet("{name}")]
    [ProducesResponseType(typeof(TeamDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetTeamByName(string name)
    {
        throw new NotImplementedException();
    }
}
