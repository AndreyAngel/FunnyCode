using AutoMapper;
using FunnyCode.Models.DTO.Requests;
using FunnyCode.Models.DTO.Responses.UserProfile;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;
using FunnyCode.Services.Interfaces.Models;
using Microsoft.AspNetCore.Mvc;

namespace FunnyCode.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProfileController: ControllerBase
{
    private readonly IUserProfileService _userProfileService;

    private readonly IMapper _mapper;

    public ProfileController(IUserProfileService userProfileService, IMapper mapper)
    {
        _userProfileService = userProfileService;
        _mapper = mapper;
    }

    [HttpGet("{id:Guid}")]
    public IActionResult GetById(Guid id)
    {
        try
        {
            var  result = _userProfileService.GetById(id);
            var response = _mapper.Map<UserProfileDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet("{name}")]
    public IActionResult GetByName(string name)
    {
        try
        {
            var result = _userProfileService.GetByName(name);
            var response = _mapper.Map<UserProfileDTOResponse>(result);

            return Ok(response);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpPost]
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

    [HttpPut("{id:Guid}")]
    public IActionResult Update(Guid id)
    {
        throw new NotImplementedException();
    }
}
