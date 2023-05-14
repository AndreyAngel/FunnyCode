using AutoMapper;
using FunnyCode.Models.DTO.Requests;
using FunnyCode.Models.DTO.Responses.UserProfile;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;
using FunnyCode.Services.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly IUserProfileService _userProfileService;

    private readonly IMapper _mapper;

    public ProfileController(IUserProfileService userProfileService, IMapper mapper)
    {
        _userProfileService = userProfileService;
        _mapper = mapper;
    }

    /// <summary>
    /// Get User Profile by Id
    /// </summary>
    /// <param name="id"> User Profile Id </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> User profile with this Id wasn't founded </response>
    [HttpGet("{id:Guid}")]
    [ProducesResponseType(typeof(UserProfileDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetById(Guid id)
    {
        try
        {
            var result = _userProfileService.GetById(id);
            var response = _mapper.Map<UserProfileDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    /// <summary>
    /// Get User Profile by name
    /// </summary>
    /// <param name="name"> User Profile name </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    /// <response code="404"> User profile with this name wasn't founded </response>
    [HttpGet("{name}")]
    [ProducesResponseType(typeof(List<UserProfileListDTOResponse>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetByName(string name)
    {
        try
        {
            var result = _userProfileService.GetByName(name);
            var response = _mapper.Map<List<UserProfileListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    /// <summary>
    /// Get User Profiles by filters
    /// </summary>
    /// <param name="request"> User Profiles filter </param>
    /// <returns></returns>
    /// <response code="200"> Successful completion </response>
    /// <response code="401"> Unauthorized </response>
    [HttpPost]
    [ProducesResponseType(typeof(UserProfileDTOResponse), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(string), (int)HttpStatusCode.NotFound)]
    public IActionResult GetByFilters(UsersFilterDTORequest request)
    {
        try
        {
            var filters = _mapper.Map<UserFiltersModel>(request);
            var result = _userProfileService.GetByFilters(filters);
            var response = _mapper.Map<List<UserProfileListDTOResponse>>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
