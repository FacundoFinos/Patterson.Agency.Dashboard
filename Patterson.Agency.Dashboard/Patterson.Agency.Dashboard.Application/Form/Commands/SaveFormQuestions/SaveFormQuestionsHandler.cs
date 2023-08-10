using AutoMapper;
using MediatR;
using Patterson.Agency.Dashboard.Domain.Answer.Entities;
using Patterson.Agency.Dashboard.Domain.Answer.Interfaces;

namespace Patterson.Agency.Dashboard.Application.Form.Commands.SaveFormQuestions;

public class SaveFormQuestionsHandler : IRequestHandler<SaveFormQuestionsCommand>
{
    private readonly IFormQuestionsService _formQuestionsService;
    private readonly IMapper _mapper;

    public SaveFormQuestionsHandler(IFormQuestionsService formQuestionsService, IMapper mapper)
    {
        _formQuestionsService = formQuestionsService;
        _mapper = mapper;
    }

    public async Task Handle(SaveFormQuestionsCommand request, CancellationToken cancellationToken)
    {
        await ValidateFormId(request.FormQuestionsDto.FormId);
        var formAnswers = new FormAnswer(request.FormQuestionsDto.FormId, 
            _mapper.Map<IEnumerable<Answer>>(request.FormQuestionsDto.Answers));
        await _formQuestionsService.Save(formAnswers);
    }

    private async Task ValidateFormId(Guid formId)
    {
        //TODO: implement validation logic
    }
}