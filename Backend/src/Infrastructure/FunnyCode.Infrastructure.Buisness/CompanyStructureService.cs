using FunnyCode.Domain.Core.Entities;
using FunnyCode.Domain.Interfaces;
using FunnyCode.Services.Interfaces;
using FunnyCode.Services.Interfaces.Exceptions;

namespace FunnyCode.Infrastructure.Buisness;

public class CompanyStructureService : ICompanyStructureService
{
    private readonly IUnitOfWork _unitOfWork;

    public CompanyStructureService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Division GetDivisionById(Guid id)
    {
        var devision = _unitOfWork.Divisions.Include(x => x.Leader)
                                            .SingleOrDefault(x => x.Id == id);

        if (devision == null)
        {
            throw new NotFoundException();
        }

        return devision;
    }

    public Division GetDivisionByName(string name)
    {
        var division = _unitOfWork.Divisions.Include(x => x.Leader)
                                            .SingleOrDefault(x => x.Name == name);

        if (division == null)
        {
            throw new NotFoundException();
        }

        return division;
    }

    public List<Division> GetDivisions()
    {
        return _unitOfWork.Divisions.GetAll();
    }

    public Subdivision GetSubdivisionById(Guid id)
    {
        var subdivision = _unitOfWork.Subdivisions.Include(x => x.Leader)
                                            .SingleOrDefault(x => x.Id == id);

        if (subdivision == null)
        {
            throw new NotFoundException();
        }

        return subdivision;
    }

    public Subdivision GetSubdivisionByName(string name)
    {
        var subdivision = _unitOfWork.Subdivisions.Include(x => x.Leader)
                                            .SingleOrDefault(x => x.Name == name);

        if (subdivision == null)
        {
            throw new NotFoundException();
        }

        return subdivision;
    }

    public List<Subdivision> GetSubdivisions(Guid divisionsId)
    {
        var subdivisions = _unitOfWork.Subdivisions.GetAll()
                           .Where(x => x.DivisionId == divisionsId).ToList();

        if (subdivisions.Count == 0)
        {
            throw new NotFoundException();
        }

        return subdivisions;
    }

    public Team GetTeamById(Guid teamId)
    {
        var team = _unitOfWork.Teams.Include(x => x.Leader)
                                            .SingleOrDefault(x => x.Id == teamId);

        if (team == null)
        {
            throw new NotFoundException();
        }

        return team;
    }

    public Team GetTeamByName(string name)
    {
        var team = _unitOfWork.Teams.Include(x => x.Leader)
                                            .SingleOrDefault(x => x.Name == name);

        if (team == null)
        {
            throw new NotFoundException();
        }

        return team;
    }

    public List<Team> GetTeams(Guid subdivisionsId)
    {
        var teams = _unitOfWork.Teams.GetAll()
                           .Where(x => x.SubdivisionId == subdivisionsId).ToList();

        if (teams.Count == 0)
        {
            throw new NotFoundException();
        }

        return teams;
    }
}
