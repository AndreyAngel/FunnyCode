using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Core.Enums;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class ProfileRepository : IProfileRepository
{
    private bool disposedValue;

    public List<UserProfile> GetAll()
    {
        return new List<UserProfile>()
        {
            new UserProfile()
            {
                Name = "Mike",
                Id = new Guid(),
                WorkSpaceId = new Guid(),
                ContactsId = new Guid(),
            },
            new UserProfile()
            {
                Name = "Andrey",
                Id = new Guid(),
                WorkSpaceId = new Guid(),
                ContactsId = new Guid(),
            },
            new UserProfile()
            {
                Name = "George",
                Id = new Guid(),
                WorkSpaceId = new Guid(),
                ContactsId = new Guid(),
            }

        };
    }

    public UserProfile? GetById(Guid Id)
    {
        return new UserProfile()
        {
            Name = "Andrey",
            Id = new Guid(),
            WorkSpaceId = new Guid(),
            ContactsId = new Guid(),
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
                Id = new Guid(),
                Contacts = new Contacts
                {
                    Email = "samokat.tech@samokat.tech",
                    Id = new Guid(),
                    MobilePhoneNumber = "8-800-555-35-35",
                    RocketChatLogin = "Login",
                    WorkPhoneNumber = "6823-331-112"
                },
                ContactsId = new Guid(),
                Schedule = new Schedule
                    {
                        Id = new Guid(),
                        Schedules = new List<WorkDay>()
                        {
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Tuesday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Wednesday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Thursday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Friday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             }
                        }
                    },
                ScheduleId = new Guid(),
                WorkSpaceId= new Guid(),
                WorkSpace=new WorkSpace
                {
                    Id = new Guid(),
                    WorkAddress = new Address
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
                        LeaderId = new Guid(),
                        Leader = new UserProfile()
                        {
                            Name = "Andrey",
                            Id = new Guid(),
                            WorkSpaceId = new Guid(),
                            ContactsId = new Guid(),
                        },
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
                        SubdivisionId = new Guid(),
                        Name = "TeamName",
                    },
                    Role = RoleInProject.BackendDeveloper,
                    ProjectId= new Guid(),
                    Project = new Project()
                    {
                        Id = new Guid(),
                        Name = "FunneyCode",
                        Description = "Description"
                    }
                },

            },

            new UserProfile()
            {
                Name = "Mike",
                BirthDate = new DateOnly(),
                Id = new Guid(),
                Contacts = new Contacts
                {
                    Email = "samokat.tech@samokat.tech",
                    Id = new Guid(),
                    MobilePhoneNumber = "8-800-555-35-35",
                    RocketChatLogin = "Login",
                    WorkPhoneNumber = "6823-331-112"
                },
                ContactsId = new Guid(),
                Schedule = new Schedule
                    {
                        Id = new Guid(),
                        Schedules = new List<WorkDay>()
                        {
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             }
                        }
                    },
                ScheduleId = new Guid(),
                WorkSpaceId= new Guid(),
                WorkSpace=new WorkSpace
                {
                    Id = new Guid(),
                    WorkAddress = new Address
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
                        LeaderId = new Guid(),
                        Leader = new UserProfile()
                        {
                            Name = "Andrey",
                            Id = new Guid(),
                            WorkSpaceId = new Guid(),
                            ContactsId = new Guid(),
                        },
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
                        SubdivisionId = new Guid(),
                        Name = "TeamName",
                    },
                    Role = RoleInProject.BackendDeveloper,
                    ProjectId= new Guid(),
                    Project = new Project()
                    {
                        Id = new Guid(),
                        Name = "For-A-Donation",
                        Description = "Description"
                    }
                },

            },

            new UserProfile()
            {
                Name = "George",
                BirthDate = new DateOnly(),
                Id = new Guid(),
                Contacts = new Contacts
                {
                    Email = "samokat.tech@samokat.tech",
                    Id = new Guid(),
                    MobilePhoneNumber = "8-800-555-35-35",
                    RocketChatLogin = "Login",
                    WorkPhoneNumber = "6823-331-112"
                },
                ContactsId = new Guid(),
                Schedule = new Schedule
                    {
                        Id = new Guid(),
                        Schedules = new List<WorkDay>()
                        {
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             },
                             new WorkDay()
                             {
                                 Id = new Guid(),
                                 Date = new DateOnly(),
                                 DayOfWeek = DayOfWeek.Monday,
                                 StartTime = new TimeOnly(),
                                 EndTime = new TimeOnly(),
                             }
                        }
                    },
                ScheduleId = new Guid(),
                WorkSpaceId= new Guid(),
                WorkSpace=new WorkSpace
                {
                    Id = new Guid(),
                    WorkAddress = new Address
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
                        LeaderId = new Guid(),
                        Leader = new UserProfile()
                        {
                            Name = "Andrey",
                            Id = new Guid(),
                            WorkSpaceId = new Guid(),
                            ContactsId = new Guid(),
                        },
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
                        SubdivisionId = new Guid(),
                        Name = "TeamName",
                    },
                    Role = RoleInProject.BackendDeveloper,
                    ProjectId= new Guid(),
                    Project = new Project()
                    {
                        Id = new Guid(),
                        Name = "E-commerce system",
                        Description = "Description"
                    }
                },

            },
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
