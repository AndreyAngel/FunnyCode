using FunnyCode.Domain.Core.Entities;

namespace FunnyCode.Services.Interfaces;

public interface ICompanyStructureService
{
    List<Division> GetDivisions();

    Division GetDivisionById(Guid id);

    Division GetDivisionByName(string name);

    List<Subdivision> GetSubdivisions(Guid divisionsId);

    Subdivision GetSubdivisionById(Guid id);

    Subdivision GetSubdivisionByName(string name);

    List<Team> GetTeams(Guid subdivisionsId);

    Team GetTeamById (Guid teamId);

    Team GetByName(string name);
}
