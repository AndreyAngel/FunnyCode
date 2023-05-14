using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class ProjecteRepository : IProjectRepository
{
    private bool disposedValue;

    public List<Project> GetAll()
    {
        return new List<Project>()
        {
            new Project()
            {
                Name = "FunnyCode",
                Description ="Description",
                Id = new Guid()

            },
            new Project()
            {
                Name = "For-A-Donation",
                Description ="Description",
                Id = new Guid()

            },
            new Project()
            {
                Name = "E-commerce system",
                Description ="Description",
                Id = new Guid()

            }
        };
    }

    public Project? GetById(Guid Id)
    {
        return new Project()
        {
         
            Name = "FunneCode",
            Description ="Description",
            Id = new Guid()
            

        };
    }

    public List<Project> Include(params Expression<Func<Project, object>>[] includeProperties)
    {
        return new List<Project>()
        {
            new Project()
            {
                Name = "FunnyCode",
                Description ="Description",
                Id = new Guid(),
                StartDate = new DateOnly(),
                EndDate = new DateOnly(),
                

            },
            new Project()
            {
                Name = "For-A-Donation",
                Description ="Description",
                Id = new Guid(),
                StartDate = new DateOnly(),
                EndDate = new DateOnly(),

            },
            new Project()
            {
                Name = "E-commerce system",
                Description ="Description",
                Id = new Guid(),
                StartDate = new DateOnly(),
                EndDate = new DateOnly(),

            }


        };
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
    // ~ProjecteRepository()
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
