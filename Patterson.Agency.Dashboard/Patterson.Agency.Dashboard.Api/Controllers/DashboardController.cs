using MediatR;
using Microsoft.AspNetCore.Mvc;
using Patterson.Agency.Dashboard.Application.Dashboard.Queries.ClientSatisfaction;

namespace Patterson.Agency.Dashboard.Api.Controllers;

[ApiController]
[Route("/api/Dashboard")]
public class DashboardController : ControllerBase
{
    private readonly IMediator _mediator;

    public DashboardController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("/clientSatisfaction")]
    public async Task<IActionResult> Post([FromBody] FilterDto filters)
    {
        return Ok(_mediator.Send(new GetClientSatisfactionQuery(filters)));
    }
}