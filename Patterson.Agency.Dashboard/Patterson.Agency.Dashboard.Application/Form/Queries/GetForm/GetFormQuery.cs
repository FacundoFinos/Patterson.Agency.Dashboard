using MediatR;

namespace Patterson.Agency.Dashboard.Application.Form.Queries.GetForm;

public record GetFormQuery(Guid FormId) : IRequest<FormDto>;

public record GetFormUserQuery(Guid FormId, Guid UserId) : IRequest<FormDto>;