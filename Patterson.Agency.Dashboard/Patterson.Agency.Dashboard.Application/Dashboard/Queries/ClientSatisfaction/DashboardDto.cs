using Patterson.Agency.Dashboard.Domain.Answer.Entities;
using Patterson.Agency.Dashboard.Domain.Shared.Enums;

namespace Patterson.Agency.Dashboard.Application.Dashboard.Queries.ClientSatisfaction;
public record DashboardDto(int TotalAnswers, IDictionary<Guid, int> TableTotalQuestions, 
        IDictionary<SatisfactionLevel, List<Answer>> TableClientSatisfaction, IEnumerable<Answer> Answers);