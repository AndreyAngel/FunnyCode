using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;

namespace FunnyCode.Infrastructure.Buisness;

public class ProjectService : IProjectService
{
    private readonly IUnitOfWork _db;
    private bool disposedValue;

    public ProjectService(IUnitOfWork db)
    {
        _db = db;
    }

    public List<Project> GetAll()
    {
        return _db.Projects.GetAll();
    }

    public List<Division> GetDivisionsByProjectId(Guid projectId)
    {
        var project = _db.Projects.Include(x => x.Divisions).FirstOrDefault(x => x.Id == projectId);

        if (project == null)
        {
            throw new NotFoundException();
        }

        return project.Divisions;
    }

    public List<Project> GetProjectsByDivisionId(Guid divisionId)
    {
        var division = _db.Divisions.Include(x => x.Projects).FirstOrDefault(x => x.Id == divisionId);

        if (division == null)
        {
            throw new NotFoundException();
        }

        return division.Projects;
    }

    public List<Project> GetProjectsBySubdivisionId(Guid subdivisionId)
    {
        var subdivision = _db.Subdivisions.Include(x => x.Projects).FirstOrDefault(x => x.Id == subdivisionId);

        if (subdivision == null)
        {
            throw new NotFoundException();
        }

        return subdivision.Projects;
    }

    public List<Project> GetProjectsByTeamId(Guid teamId)
    {
        var team = _db.Teams.Include(x => x.Projects).FirstOrDefault(x => x.Id == teamId);

        if (team == null)
        {
            throw new NotFoundException();
        }

        return team.Projects;
    }

    public Project GetProjectByUserProfileId(Guid userProfileId)
    {
        var user = _db.Profiles.Include(x => x.WorkSpace.Project)
                               .FirstOrDefault(x => x.Id == userProfileId);

        if (user == null)
        {
            throw new NotFoundException();
        }

        return user.WorkSpace.Project;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                _db.Dispose();
            }

            disposedValue = true;
        }
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
