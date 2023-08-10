namespace Patterson.Agency.Dashboard.Application.Dashboard.Queries.ClientSatisfaction;

public record FilterDto(bool PersonalizedDashboardRequired, Guid? UserId, Guid? QuestionId);