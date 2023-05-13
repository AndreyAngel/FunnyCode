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
                // TODO: освободить управляемое состояние (управляемые объекты)
            }

            // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
            // TODO: установить значение NULL для больших полей
            disposedValue = true;
        }
    }

    // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
    // ~UnitOfWork()
    // {
    //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
