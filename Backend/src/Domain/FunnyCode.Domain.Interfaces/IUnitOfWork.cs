namespace FunnyCode.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public IDivisionRepository Divisions { get; }

    public IProfileRepository Profiles { get; }

    public IProjectRepository Projects { get; }

    public ISubdivisionRepository Subdivisions { get; }

    public ITeamRepository Teams { get; }

    public Task SaveChangesAsync();
}
