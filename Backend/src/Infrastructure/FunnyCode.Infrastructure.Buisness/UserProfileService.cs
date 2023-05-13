using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;
using FunnyCode.Services.Interfaces.Models;
using System.Security.Cryptography.X509Certificates;

namespace FunnyCode.Infrastructure.Buisness;

public class UserProfileService : IUserProfileService
{
    private readonly IUnitOfWork _db;

    private bool disposedValue;

    public UserProfileService(IUnitOfWork unitOfWork)
    {
        _db = unitOfWork;
    }

    public UserProfile GetById(Guid id)
    {
        var user = _db.Profiles.Include(x => x.Contacts,
                                        x => x.WorkSpace,
                                        x => x.Schedule,
                                        x => x.Vacations).SingleOrDefault(x => x.Id == id);

        if (user == null)
        {
            throw new NotFoundException();
        }
        
        return user;
    }

    public List<UserProfile> GetByName(string name)
    {
        return _db.Profiles.GetAll().Where(x => x.Name == name).ToList();
    }

    public List<UserProfile> GetByFilters(UserFiltersModel filters)
    {
        var user = _db.Profiles.Include(x => x.WorkSpace);

        if (filters.DivisionName != null)
        {
            user = user.Where(x => x.WorkSpace.Division.Name == filters.DivisionName).ToList();
        }

        if (filters.SubdivisionName != null)
        {
            user = user.Where(x => x.WorkSpace.Subdivision.Name == filters.SubdivisionName).ToList();
        }

        if (filters.TeamName != null)
        {
            user = user.Where(x => x.WorkSpace.Team.Name == filters.TeamName).ToList();
        }

        if (filters.WorkAddress != null)
        {
            user = user.Where(x => x.WorkSpace.Address == filters.WorkAddress).ToList();
        }

        if (filters.JobTitle != null)
        {
            user = user.Where(x => x.WorkSpace.JobTitle == filters.JobTitle).ToList();
        }

        if (filters.RoleInProject != null)
        {
            user = user.Where(x => x.WorkSpace.Role == filters.RoleInProject).ToList();
        }

        return user;
    }

    public UserProfile Update(UserProfile user)
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
    // ~UserProfileService()
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
