namespace Patterson.Agency.Dashboard.Application.Form.Commands.SaveFormQuestions;

public record AddFormQuestionsDto(Guid FormId,IEnumerable<AnswerDto> Answers);

public record AnswerDto(Guid Id, string Value, Guid SelectedOptionId);