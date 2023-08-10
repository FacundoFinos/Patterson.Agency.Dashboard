using MediatR;
using Microsoft.AspNetCore.Mvc;
using Patterson.Agency.Dashboard.Application.Form.Commands.SaveFormQuestions;
using Patterson.Agency.Dashboard.Application.Form.Queries.GetForm;

namespace Patterson.Agency.Dashboard.Api.Controllers;

[ApiController]
[Route("/api/Form")]
public class FormController : ControllerBase
{
    private readonly IMediator _mediator;

    public FormController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] Guid id, [FromQuery] Guid? userId = null)
    {
        return userId.HasValue 
            ?  Ok(await _mediator.Send(new GetFormUserQuery(id, userId.Value)))
            : Ok(await _mediator.Send(new GetFormQuery(id)));
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AddFormQuestionsDto formDto)
    {
        return Ok(_mediator.Send(new SaveFormQuestionsCommand(formDto)));
    }
}