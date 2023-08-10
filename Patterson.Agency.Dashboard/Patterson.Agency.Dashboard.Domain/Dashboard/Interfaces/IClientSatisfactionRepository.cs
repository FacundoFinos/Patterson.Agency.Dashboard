using Patterson.Agency.Dashboard.Domain.Dashboard.Entities;

namespace Patterson.Agency.Dashboard.Domain.Dashboard.Interfaces;

public interface IClientSatisfactionRepository
{
    PersonalizedDashboard GetPersonalizedDashboard(Guid userId);
    Entities.Dashboard GetDashboard();
}