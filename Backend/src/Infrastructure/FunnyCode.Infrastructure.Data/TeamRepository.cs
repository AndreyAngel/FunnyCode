using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class TeamRepository : ITeamRepository
{
    private bool disposedValue;

    public List<Team> GetAll()
    {

        return new List<Team>()
        {
            new Team() 
            {
                Id = new Guid(),
                Name = "TeamName",
                SubdivisionId = new Guid(),
                               
            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                SubdivisionId = new Guid(),

            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                SubdivisionId = new Guid(),

            },
        };
        
    }
    public Team? GetById(Guid Id)
    {
        return new Team()
        {
            
            Id = new Guid(),
            Name = "TeamName",
            SubdivisionId = new Guid(),
            Leader = new UserProfile 
            {
                Id=new Guid(),
                Name = "LeaderName",
                WorkSpaceId = new Guid(),
                ContactsId = new Guid(),
                
            },
            Projects = new List<Project>
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
                }

        };
    }

    public List<Team> Include(params Expression<Func<Team, object>>[] includeProperties)
    {
        return new List<Team>()
        {
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                SubdivisionId = new Guid(),
                Leader = new UserProfile
                {
                    Id = new Guid(),
                    Name = "LeaderName",
                    ContactsId= new Guid(),
                    ScheduleId = new Guid(),
                    WorkSpaceId= new Guid(),
              
                },
                Projects = new List<Project>
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
                }


            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                SubdivisionId = new Guid(),
                Leader = new UserProfile
                {
                    Id = new Guid(),
                    Name = "LeaderName",
                    ContactsId= new Guid(),
                    ScheduleId = new Guid(),
                    WorkSpaceId= new Guid(),

                },
                Projects = new List<Project>
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
                }


            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                SubdivisionId = new Guid(),
                Leader = new UserProfile
                {
                    Id = new Guid(),
                    Name = "LeaderName",
                    ContactsId= new Guid(),
                    ScheduleId = new Guid(),
                    WorkSpaceId= new Guid(),

                },
                Projects = new List<Project>
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
                }


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
    // ~TeamRepository()
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
