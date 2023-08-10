using MediatR;

namespace Patterson.Agency.Dashboard.Application.Form.Commands.SaveFormQuestions;

public record SaveFormQuestionsCommand(AddFormQuestionsDto FormQuestionsDto) : IRequest;
