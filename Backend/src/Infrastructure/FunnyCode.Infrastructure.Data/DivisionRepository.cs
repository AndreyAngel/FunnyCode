using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class DivisionRepository : IDivisionRepository
{
    private bool disposedValue;

    public List<Division> GetAll()
    {
        throw new NotImplementedException();
    }

    public Division? GetById(Guid Id)
    {
        throw new NotImplementedException();
    }

    public List<Division> Include(params Expression<Func<Division, object>>[] includeProperties)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task AddAsync(Division entity)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateAsync(Division entity)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task RemoveAsync(Division entity)
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
    // ~DivisionRepository()
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
