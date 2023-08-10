using MediatR;
using Patterson.Agency.Dashboard.Domain.Dashboard.Interfaces;

namespace Patterson.Agency.Dashboard.Application.Dashboard.Queries.ClientSatisfaction;

public class GetClientSatisfactionHandler : IRequestHandler<GetClientSatisfactionQuery, DashboardDto>
{
    private readonly IClientSatisfactionRepository _clientSatisfactionRepository;

    public GetClientSatisfactionHandler(IClientSatisfactionRepository clientSatisfactionRepository)
    {
        _clientSatisfactionRepository = clientSatisfactionRepository;
    }

    public async Task<DashboardDto> Handle(GetClientSatisfactionQuery request, CancellationToken cancellationToken)
    {
       var dashboard = request.FilterDto.PersonalizedDashboardRequired
            ? GetPersonalizedDashboard(request)
            : GetGenericDashboard(request);

       if (request.FilterDto.QuestionId.HasValue)
       {
           dashboard.Filter(request.FilterDto.QuestionId.Value);
       }
       
       var tableClientSatisfaction = dashboard.GetTableBySatisfactionLevel();
       var tableTotalQuestions  = dashboard.GetTableTotalQuestions();
       var totalAnswers = dashboard.TotalAnswers;

       return new DashboardDto(totalAnswers, tableTotalQuestions, tableClientSatisfaction, dashboard.Answers);
    }

    private Domain.Dashboard.Entities.Dashboard GetGenericDashboard(GetClientSatisfactionQuery request)
    {
        return _clientSatisfactionRepository.GetDashboard();
    }

    private Domain.Dashboard.Entities.Dashboard GetPersonalizedDashboard(GetClientSatisfactionQuery request)
    {
        return _clientSatisfactionRepository.GetPersonalizedDashboard(request.FilterDto.UserId.Value);
    }
}