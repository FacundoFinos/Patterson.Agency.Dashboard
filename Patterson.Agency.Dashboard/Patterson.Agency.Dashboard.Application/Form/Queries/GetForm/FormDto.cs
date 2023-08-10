namespace Patterson.Agency.Dashboard.Application.Form.Queries.GetForm;

public record FormDto(Guid Id, string Description, IEnumerable<QuestionDto> Questions);

public record QuestionDto(Guid Id, string Description, bool HasOptions, IEnumerable<OptionDto> Options);

public record OptionDto(Guid Id, string Text);