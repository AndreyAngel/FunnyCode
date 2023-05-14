using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Core.Enums;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class ProfileRepository : IProfileRepository
{
    private bool disposedValue;

    public System.Threading.Tasks.Task AddAsync(UserProfile entity)
    {
        throw new NotImplementedException();
    }

    public List<UserProfile> GetAll()
    {
        return new List<UserProfile>()
        {
            new UserProfile()
            { 
                Name = "Mike",
                Id = Guid.NewGuid(),
                WorkSpaceId = Guid.NewGuid(),
                ContactsId = Guid.NewGuid(),
                               
            },
            new UserProfile()
            {
                Name = "John",
                Id = Guid.NewGuid(),
                WorkSpaceId = Guid.NewGuid(),
                ContactsId = Guid.NewGuid(),

            },
            new UserProfile()
            {
                Name = "Andrey",
                Id = Guid.NewGuid(),
                WorkSpaceId = Guid.NewGuid(),
                ContactsId = Guid.NewGuid(),

            }

        };
    }

    public UserProfile? GetById(Guid Id)
    {
        return new UserProfile()
        {
            Name = "Mike",
            Id = Guid.NewGuid(),
            WorkSpaceId = Guid.NewGuid(),
            ContactsId = Guid.NewGuid()
        };
    }

    public List<UserProfile> Include(params Expression<Func<UserProfile, object>>[] includeProperties)
    {
        return new List<UserProfile>()
        {
            new UserProfile()
            {
                Name = "Mike",
                BirthDate = new DateOnly(),
                Contacts = new Contacts
                {
                    Email = "",
                    Id = new Guid(),
                    MobilePhoneNumber = "",
                    RocketChatLogin = "",
                    WorkPhoneNumber = ""
                },
                ContactsId = new Guid(),
                Id = new Guid(),
                Schedule = new Schedule{Id = new Guid(),Schedules = null},
                ScheduleId = new Guid(),
                WorkSpaceId= new Guid(),
                WorkSpace=new WorkSpace
                {
                    Id = new Guid(),
                    Address = new Address
                    {
                        Id= new Guid(),
                        City = "City",
                        Region = "Tomsker",
                        NumberOfHome = "12",
                        PostalCode = "PScode",
                        Street = "Street"
                    },
                    AddressId= new Guid(),
                    Division = new Division { 
                        Id = new Guid(),
                        Description="",
                        LeaderId= new Guid(),
                        Name = "DivisionName",
                       
                    },
                    Subdivision = new Subdivision
                    {
                        Id =new Guid(),
                        LeaderId = new Guid(),
                        DivisionId = new Guid(),
                        Name = "SubdivisionName",
                    },
                    DivisionId= new Guid(),
                    SubdivisionId= new Guid(),
                    Team = new Team
                    {
                        Id = new Guid(),
                        ProjectId = new Guid(),
                        SubdivisionId = new Guid(),
                        Name = "TeamName",
                    }
                    
                },

            },
            new UserProfile()
            {
                Name = "Mike",
                BirthDate = new DateOnly(),
                Contacts = new Contacts
                {
                    Email = "",
                    Id = new Guid(),
                    MobilePhoneNumber = "",
                    RocketChatLogin = "",
                    WorkPhoneNumber = ""
                },
                ContactsId = new Guid(),
                Id = new Guid(),
                Schedule = new Schedule{Id = new Guid(),Schedules = null},
                ScheduleId = new Guid(),
                WorkSpaceId= new Guid(),
                WorkSpace=new WorkSpace
                {
                    Id = new Guid(),
                    Address = new Address
                    {
                        Id= new Guid(),
                        City = "City",
                        Region = "Tomsker",
                        NumberOfHome = "12",
                        PostalCode = "PScode",
                        Street = "Street"
                    },
                    AddressId= new Guid(),
                    Division = new Division {
                        Id = new Guid(),Description="",
                        Leader = new UserProfile()
                        {
                            Name = "John",
                            ContactsId = new Guid(),
                            WorkSpaceId = new Guid(),
                            Id = new Guid(),
                            ScheduleId = new Guid()
                        },
                        LeaderId= new Guid(),
                        Name = "DivisionName",

                    },
                    Subdivision = new Subdivision
                    {
                        Id =new Guid(),
                        LeaderId = new Guid(),
                        DivisionId = new Guid(),
                        Name = "SubdivisionName",
                    },
                    DivisionId= new Guid(),
                    SubdivisionId= new Guid(),
                    Team = new Team
                    {
                        Id = new Guid(),
                        ProjectId = new Guid(),
                        SubdivisionId = new Guid(),
                        Name = "TeamName",
                    }

                },

            },
            new UserProfile()
            {
                Name = "Mike",
                BirthDate = new DateOnly(),
                Contacts = new Contacts
                {
                    Email = "",
                    Id = new Guid(),
                    MobilePhoneNumber = "",
                    RocketChatLogin = "",
                    WorkPhoneNumber = ""
                },
                ContactsId = new Guid(),
                Id = new Guid(),
                Schedule = new Schedule{Id = new Guid(),Schedules = null},
                ScheduleId = new Guid(),
                WorkSpaceId= new Guid(),
                WorkSpace=new WorkSpace
                {
                    Id = new Guid(),
                    Address = new Address
                    {
                        Id= new Guid(),
                        City = "City",
                        Region = "Tomsker",
                        NumberOfHome = "12",
                        PostalCode = "PScode",
                        Street = "Street"
                    },
                    AddressId= new Guid(),
                    Division = new Division {
                        Id = new Guid(),Description="",
                        Leader = new UserProfile()
                        {
                            Name = "John",
                            ContactsId = new Guid(),
                            WorkSpaceId = new Guid(),
                            Id = new Guid(),
                            ScheduleId = new Guid()
                        },
                        LeaderId= new Guid(),
                        Name = "DivisionName",

                    },
                    Subdivision = new Subdivision
                    {
                        Id =new Guid(),
                        LeaderId = new Guid(),
                        DivisionId = new Guid(),
                        Name = "SubdivisionName",
                    },
                    DivisionId= new Guid(),
                    SubdivisionId= new Guid(),
                    Team = new Team
                    {
                        Id = new Guid(),
                        ProjectId = new Guid(),
                        SubdivisionId = new Guid(),
                        Name = "TeamName",
                    },
                    TeamId= new Guid(),  

                },

            },

        };
    }

    public System.Threading.Tasks.Task RemoveAsync(UserProfile entity)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateAsync(UserProfile entity)
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
    // ~ProfileRepository()
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
