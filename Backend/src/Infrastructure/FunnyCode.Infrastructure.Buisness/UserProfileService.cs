using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;
using FunnyCode.Services.Interfaces.Models;

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
                                        x => x.Vacations).FirstOrDefault(x => x.Id == id);

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
            user = user.Where(x => x.WorkSpace.WorkAddress == filters.WorkAddress).ToList();
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
