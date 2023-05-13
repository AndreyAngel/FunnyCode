using AutoMapper;
using FunnyCode.Models.DTO.Responses.Project;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProjectController : ControllerBase
{
    private readonly IProjectService _projectService;

    private readonly IMapper _mapper;

    public ProjectController(IProjectService projectService, IMapper mapper)
    {
        _projectService = projectService;
        _mapper = mapper;
    }

    /// <summary>
    /// Get all projects
    /// </summary>
    /// <returns>List of all projects</returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    [HttpGet]
    [ProducesResponseType(typeof(List<ProjectListDTOResponse>), (int)HttpStatusCode.OK)]
    public IActionResult GetAllProjects()
    {
        var result =  _projectService.GetAll();
        var response = _mapper.Map <List<ProjectListDTOResponse>> (result);

        return Ok(response);
    }

    /// <summary>
    /// Get projects by user Id
    /// </summary>
    /// <param name="userProfileId"> User Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> User profile with this Id wasn't founded </response>
    [HttpGet("{userProfileId:Guid}")]
    [ProducesResponseType(typeof(List<ProjectListDTOResponse>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetProjectsByUserProfileId(Guid userProfileId)
    {
        try
        {
            var result = _projectService.GetProjectsByUserProfileId(userProfileId);
            var response = _mapper.Map<List<ProjectListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    /// <summary>
    /// Get projects by team Id
    /// </summary>
    /// <param name="teamId"> Team Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Team with this Id wasn't founded </response>
    [HttpGet("{teamId:Guid}")]
    [ProducesResponseType(typeof(List<ProjectListDTOResponse>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetProjectByTeamId(Guid teamId)
    {
        try
        {
            var result = _projectService.GetProjectsByTeamId(teamId);
            var response = _mapper.Map<List<ProjectListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    /// <summary>
    /// Get projects by subdivision Id
    /// </summary>
    /// <param name="subdivisionId"> Subdivision Id </param>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Subdivision with this Id wasn't founded </response>
    /// <returns></returns>
    [HttpGet("{subdivisionId:Guid}")]
    [ProducesResponseType(typeof(List<ProjectListDTOResponse>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetProjectsBySubdivisionId(Guid subdivisionId)
    {
        try
        {
            var result = _projectService.GetProjectsBySubdivisionId(subdivisionId);
            var response = _mapper.Map<List<ProjectListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    /// <summary>
    /// Get projects by division Id
    /// </summary>
    /// <param name="divisionId"> Division Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Subdivision with this Id wasn't founded </response>
    [HttpGet("{divisionId:Guid}")]
    [ProducesResponseType(typeof(List<ProjectListDTOResponse>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetProjectsByDivisionId(Guid divisionId)
    {
        try
        {
            var result = _projectService.GetProjectsByDivisionId(divisionId);
            var response = _mapper.Map<List<ProjectListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    /// <summary>
    /// Get divisions by project Id
    /// </summary>
    /// <param name="projectId"> Project Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> Project with this Id wasn't founded </response>
    [HttpGet("{projectId:Guid}")]
    [ProducesResponseType(typeof(List<ProjectDivisionsDTOResponse>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetDivisionsByProjectId(Guid projectId)
    {
        try
        {
            var result = _projectService.GetDivisionsByProjectId(projectId);
            var response = _mapper.Map<List<ProjectListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
