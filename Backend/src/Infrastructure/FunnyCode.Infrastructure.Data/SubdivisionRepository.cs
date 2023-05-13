using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

public class SubdivisionRepository: ISubdivisionRepository
{
    private bool disposedValue;

    public System.Threading.Tasks.Task AddAsync(Subdivision entity)
    {
        throw new NotImplementedException();
    }

    public List<Subdivision> GetAll()
    {
        return new List<Subdivision>()
        {
            new Subdivision()
            {
                Id = new Guid(),
                Name = "SubdivisionName",
                Description = "Description",
                DivisionId = new Guid(),
              
            },
            new Subdivision()
            {
                Id = new Guid(),
                Name = "SubdivisionName",
                Description = "Description",
                DivisionId = new Guid(),

            },
            new Subdivision()
            {
                Id = new Guid(),
                Name = "SubdivisionName",
                Description = "Description",
                DivisionId = new Guid(),

            }


        };
    }

    public Subdivision? GetById(Guid Id)
    {
        return new Subdivision()
        {
           
            Id = new Guid(),
            Name = "SubdivisionName",
            Description = "Description",
            DivisionId = new Guid(),  
           
        };
    }

    public List<Subdivision> Include(params Expression<Func<Subdivision, object>>[] includeProperties)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task RemoveAsync(Subdivision entity)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateAsync(Subdivision entity)
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
    // ~SubdivisionRepository()
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
