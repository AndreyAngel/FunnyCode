using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

public class TeamRepository : ITeamRepository
{
    private bool disposedValue;

    public System.Threading.Tasks.Task AddAsync(Team entity)
    {
        throw new NotImplementedException();
    }

    public List<Team> GetAll()
    {

        return new List<Team>()
        {
            new Team() 
            {
                Id = new Guid(),
                Name = "TeamName",
                ProjectId = new Guid(),
                SubdivisionId = new Guid(),
                               
            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                ProjectId = new Guid(),
                SubdivisionId = new Guid(),

            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                ProjectId = new Guid(),
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
            ProjectId = new Guid(),
            SubdivisionId = new Guid(),
            Leader = new UserProfile 
            {
                Id=new Guid(),
                Name = "LeaderName",
                WorkSpaceId = new Guid(),
                ContactsId = new Guid(),
                
            },
            Project = new Project()
            {
                Id = new Guid(),
                Name = "ProjectName",
                Description = "ProjectDescription",
     
            },
           
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
                ProjectId = new Guid(),
                SubdivisionId = new Guid(),
                Leader = new UserProfile
                {
                    Id = new Guid(),
                    Name = "LeaderName",
                    ContactsId= new Guid(),
                    ScheduleId = new Guid(),
                    WorkSpaceId= new Guid(),
              
                },
                Project = new Project()
                {
                    Id = new Guid(),
                    Name = "ProjectName",
                    Description = "ProjectDescription",

                },
                

            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                ProjectId = new Guid(),
                SubdivisionId = new Guid(),
                Leader = new UserProfile
                {
                    Id = new Guid(),
                    Name = "LeaderName",
                    ContactsId= new Guid(),
                    ScheduleId = new Guid(),
                    WorkSpaceId= new Guid(),

                },
                Project = new Project()
                {
                    Id = new Guid(),
                    Name = "ProjectName",
                    Description = "ProjectDescription",

                },


            },
            new Team()
            {
                Id = new Guid(),
                Name = "TeamName",
                ProjectId = new Guid(),
                SubdivisionId = new Guid(),
                Leader = new UserProfile
                {
                    Id = new Guid(),
                    Name = "LeaderName",
                    ContactsId= new Guid(),
                    ScheduleId = new Guid(),
                    WorkSpaceId= new Guid(),

                },
                Project = new Project()
                {
                    Id = new Guid(),
                    Name = "ProjectName",
                    Description = "ProjectDescription",

                },


            },
        };
    }

    public System.Threading.Tasks.Task RemoveAsync(Team entity)
    {
        throw new NotImplementedException();
    }

    public System.Threading.Tasks.Task UpdateAsync(Team entity)
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
