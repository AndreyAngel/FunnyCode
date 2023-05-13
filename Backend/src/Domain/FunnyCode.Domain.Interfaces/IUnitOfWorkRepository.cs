namespace FunnyCode.Domain.Interfaces;

public interface IUnitOfWorkRepository
{
    public IDivisionRepository Divisions { get; }

    public IProfileRepository Profiles { get; }

    public IProjectRepository Projects { get; }

    public ISubdivisionRepository Subdivisions { get; }

    public ITeamRepository Teams { get; }

    public Task SaveChangesAsync();
}
