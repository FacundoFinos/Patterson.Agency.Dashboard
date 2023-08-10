using Patterson.Agency.Dashboard.Domain.Shared.Enums;

namespace Patterson.Agency.Dashboard.Domain.Answer.Entities;

public class Answer
{
    public Guid Id { get; }
    public Guid QuestionId { get; }
    public SatisfactionLevel? SatisfactionLevel { get; }
    public string Text { get; }

    public Answer(Guid questionId, string text, SatisfactionLevel? satisfactionLevel)
    {
        Id = Guid.NewGuid();
        QuestionId = questionId;
        Text = text;
        SatisfactionLevel = satisfactionLevel;
    }

    public Answer(Guid id, Guid questionId, string text, SatisfactionLevel? satisfactionLevel)
    {
        Id = id;
        QuestionId = questionId;
        Text = text;
        SatisfactionLevel = satisfactionLevel;
    }
}