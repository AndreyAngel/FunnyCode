using AutoMapper;
using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Core.Enums;
using FunnyCode.Models.DTO;
using FunnyCode.Models.DTO.Enums;
using FunnyCode.Models.DTO.Requests;
using FunnyCode.Models.DTO.Responses;
using FunnyCode.Models.DTO.Responses.CompanyStructure;
using FunnyCode.Models.DTO.Responses.UserProfile;
using FunnyCode.Services.Interfaces.Models;
using TaskStatus = FunnyCode.Domain.Core.Enums.TaskStatus;

namespace FunnyCode.Helpers;

/// <summary>
/// Class for models mapping
/// </summary>
public class MappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of <see cref="MappingProfile"/>.
    /// </summary>
    public MappingProfile()
    {
        CreateMap<Division, DivisionDTOResponse>();

        CreateMap<Division, DivisionListDTOResponse>();

        CreateMap<Subdivision, SubdivisionDTOResponse>();

        CreateMap<Subdivision, SubdivisionListDTOResponse>();

        CreateMap<Team, TeamDTOResponse>();

        CreateMap<Team, TeamListDTOResponse>();

        CreateMap<UserProfile, UserProfileDTOResponse>();

        CreateMap<UsersFilterDTORequest, UserFiltersModel>();

        CreateMap<Division, UserProfileDivisionDTOResponse>();

        CreateMap<UserProfile, UserProfileListDTOResponse>();

        CreateMap<Address, AddressDTO>();

        CreateMap<WorkSpace, WorkSpaceDTOResponse>();

        CreateMap<Contacts, ContactsDTOResponse>();

        CreateMap<Schedule, ScheduleDTOResponse>();

        CreateMap<Vacation, VacationDTOResponse>();

        CreateMap<WorkDay, WorkDayDTOResponse>();

        CreateMap<JobTitle, JobTitleDTO>();

        CreateMap<RoleInProject, RoleInProjectDTO>();

        CreateMap<TaskStatus, TaskStatusDTO>();

        CreateMap<VacationType, VacationTypeDTO>();
    }
}
