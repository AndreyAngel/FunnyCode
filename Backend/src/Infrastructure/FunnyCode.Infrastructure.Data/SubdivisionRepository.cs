using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class SubdivisionRepository: ISubdivisionRepository
{
    private bool disposedValue;

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

    public List<Subdivision> Include(params Expression<Func<Subdivision, object>>[] includeProperties)
    {
      
            return new List<Subdivision>()
            {
                new Subdivision()
                {
                    Id = new Guid(),
                    Name = "SubdivisionName",
                    Description = "Description",
                    DivisionId = new Guid(),
                    LeaderId = new Guid(),
                    Leader = new UserProfile
                    {
                        Name = "Name",
                        Id = new Guid(),
                        ContactsId = new Guid(),
                        ScheduleId = new Guid(),
                        WorkSpaceId = new Guid(),
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
                new Subdivision()
                {
                    Id = new Guid(),
                    Name = "SubdivisionName",
                    Description = "Description",
                    DivisionId = new Guid(),
                    LeaderId = new Guid(),
                    Leader = new UserProfile
                    {
                        Name = "Name",
                        Id = new Guid(),
                        ContactsId = new Guid(),
                        ScheduleId = new Guid(),
                        WorkSpaceId = new Guid(),
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
                new Subdivision()
                {
                    Id = new Guid(),
                    Name = "SubdivisionName",
                    Description = "Description",
                    DivisionId = new Guid(),
                    LeaderId = new Guid(),
                    Leader = new UserProfile
                    {
                        Name = "Name",
                        Id = new Guid(),
                        ContactsId = new Guid(),
                        ScheduleId = new Guid(),
                        WorkSpaceId = new Guid(),
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
