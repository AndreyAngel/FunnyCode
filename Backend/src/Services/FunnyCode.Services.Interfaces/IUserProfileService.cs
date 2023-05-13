using FunnyCode.Domain.Core.Entities;
using FunnyCode.Services.Interfaces.Models;

namespace FunnyCode.Services.Interfaces;

public interface IUserProfileService : IDisposable
{
    UserProfile GetById(Guid id);

    List<UserProfile> GetByName(string name);

    List<UserProfile> GetByFilters(UserFiltersModel filters);
}
