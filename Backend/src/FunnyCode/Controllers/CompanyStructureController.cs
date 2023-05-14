using AutoMapper;
using FunnyCode.Models.DTO.Responses;
using FunnyCode.Models.DTO.Responses.CompanyStructure;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CompanyStructureController : ControllerBase
{
    private readonly ICompanyStructureService _companyStructureService;

    private readonly IMapper _mapper;

    public CompanyStructureController(ICompanyStructureService companyStructureService, IMapper mapper)
    {
        _companyStructureService = companyStructureService;
        _mapper = mapper;
    }

    /// <summary>
    /// Get all divisions
    /// </summary>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    [HttpGet]
    [ProducesResponseType(typeof(List<DivisionListDTOResponse>), (int)HttpStatusCode.OK)]
    public IActionResult GetDivisions()
    {
        var result = _companyStructureService.GetDivisions();
        var response = _mapper.Map<List<DivisionListDTOResponse>>(result);

        return Ok(response);
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
        try
        {
            var result = _companyStructureService.GetDivisionById(id);
            var response = _mapper.Map<DivisionDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetDivisionByName(name);
            var response = _mapper.Map<DivisionDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetSubdivisions(divisionId);
            var response = _mapper.Map<List<SubdivisionListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetSubdivisionById(id);
            var response = _mapper.Map<SubdivisionDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetSubdivisionByName(name);
            var response = _mapper.Map<SubdivisionDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetTeams(subdivisionId);
            var response = _mapper.Map<List<TeamListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetTeamById(id);
            var response = _mapper.Map<TeamDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
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
        try
        {
            var result = _companyStructureService.GetTeamByName(name);
            var response = _mapper.Map<TeamDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
