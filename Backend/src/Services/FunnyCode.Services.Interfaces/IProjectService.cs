using FunnyCode.Domain.Core.Entities;

namespace FunnyCode.Services.Interfaces;

public interface IProjectService
{
    List<Project> GetAll();

    List<Project> GetProjectsByDivisionId(Guid divisionId);

    List<Project> GetProjectsBySubdivisionId(Guid subdivisionId);

    List<Project> GetProjectsByTeamId(Guid teamId);

    List<Project> GetProjectsByUserProfileId(Guid userProfileId);

    List<Division> GetDivisionsByProjectId(Guid projectId);
}
