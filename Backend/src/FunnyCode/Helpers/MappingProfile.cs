using AutoMapper;
using FunnyCode.Domain.Core.Entities;
using FunnyCode.Models.DTO.Responses;
using FunnyCode.Models.DTO.Responses.CompanyStructure;

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
    }
}
