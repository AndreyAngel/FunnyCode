using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

public class ProjecteRepository : IProjectRepository
{
    private bool disposedValue;

    public System.Threading.Tasks.Task AddAsync(Project entity)
    {
        throw new NotImplementedException();
    }

    public List<Project> GetAll()
    {
        return new List<Project>()
        {
            new Project()
            {
                Name = "ProjectName1",
                Description ="Description",
                Id = new Guid()

            },
            new Project()
            {
                Name = "ProjectName2",
                Description ="Description",
                Id = new Guid()

            },
            new Project()
            {
                Name = "ProjectName3",
                Description ="Description",
                Id = new Guid()

            }


        };
    }

    public Project? GetById(Guid Id)
    {
        return new Project()
        {
         
            Name = "ProjectName",
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
                Name = "ProjectName1",
                Description ="Description",
                Id = new Guid(),
                StartDate = new DateOnly(),
                EndDate = new DateOnly(),
                

            },
            new Project()
            {
                Name = "ProjectName2",
                Description ="Description",
                Id = new Guid(),
                StartDate = new DateOnly(),
                EndDate = new DateOnly(),

            },
            new Project()
            {
                Name = "ProjectName3",
                Description ="Description",
                Id = new Guid(),
                StartDate = new DateOnly(),
                EndDate = new DateOnly(),

            }


        };
    }

    public System.Threading.Tasks.Task RemoveAsync(Project entity)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateAsync(Project entity)
    {
        throw new NotImplementedException();
    }

    internal class ProjectRepository
    {
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
