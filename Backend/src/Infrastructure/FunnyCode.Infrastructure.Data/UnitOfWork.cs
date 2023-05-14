using FunnyCode.Domain.Interfaces;

namespace FunnyCode.Infrastructure.Data;

public class UnitOfWork : IUnitOfWork
{
    private bool disposedValue;

    public IDivisionRepository Divisions { get; }

    public IProfileRepository Profiles { get; }

    public IProjectRepository Projects { get; }

    public ISubdivisionRepository Subdivisions { get; }

    public ITeamRepository Teams { get; }

    public UnitOfWork()
    {
        Divisions = new DivisionRepository();
        Profiles = new ProfileRepository();
        Projects = new ProjecteRepository();
        Subdivisions = new SubdivisionRepository();
        Teams = new TeamRepository();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                Divisions.Dispose();
                Subdivisions.Dispose();
                Profiles.Dispose();
                Projects.Dispose();
                Teams.Dispose();
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
