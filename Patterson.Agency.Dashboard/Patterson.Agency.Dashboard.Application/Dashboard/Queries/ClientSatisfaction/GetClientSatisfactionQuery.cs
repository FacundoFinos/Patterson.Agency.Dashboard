using MediatR;

namespace Patterson.Agency.Dashboard.Application.Dashboard.Queries.ClientSatisfaction;

public record GetClientSatisfactionQuery(FilterDto FilterDto) : IRequest<DashboardDto>;