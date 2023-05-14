using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System.Linq.Expressions;

namespace FunnyCode.Infrastructure.Data;

public class DivisionRepository : IDivisionRepository
{
    private bool disposedValue;

    public List<Division> GetAll()
    {
        return new List<Division>()
        {
            new Division()
            {
                Id = new Guid(),
                Name = "develop department"
            },

            new Division()
            {
                Id = new Guid(),
                Name = "develop department"
            },

            new Division()
            {
                Id = new Guid(),
                Name = "develop department"
            },

        };
    }

    public Division? GetById(Guid Id)
    {
        return new Division()
        {
            Id = new Guid(),
            Name = "develop department",
            Leader = new UserProfile()
            {
                Name = "John",
                ContactsId = new Guid(),
                WorkSpaceId = new Guid(),
                Id = new Guid(),
                ScheduleId = new Guid()
            },
            Description = "DivisionDescription",
            LeaderId = new Guid(),
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

    public List<Division> Include(params Expression<Func<Division, object>>[] includeProperties)
    {
        return new List<Division>()
        {
            new Division()
            {
                Id = new Guid(),
                Name = "develop department",
                Leader = new UserProfile()
                {
                    Name = "John",
                    ContactsId = new Guid(),
                    WorkSpaceId = new Guid(),
                    Id = new Guid(),
                    ScheduleId = new Guid()
                },
                Description = "DivisionDescription",
                LeaderId = new Guid(),
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

            new Division()
            {
                Id = new Guid(),
                Name = "develop department",
                Leader = new UserProfile()
                {
                    Name = "John",
                    ContactsId = new Guid(),
                    WorkSpaceId = new Guid(),
                    Id = new Guid(),
                    ScheduleId = new Guid()
                },
                Description = "DivisionDescription",
                LeaderId = new Guid(),
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

            new Division()
            {
                Id = new Guid(),
                Name = "develop department",
                Leader = new UserProfile()
                {
                    Name = "John",
                    ContactsId = new Guid(),
                    WorkSpaceId = new Guid(),
                    Id = new Guid(),
                    ScheduleId = new Guid()
                },
                Description = "DivisionDescription",
                LeaderId = new Guid(),
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
