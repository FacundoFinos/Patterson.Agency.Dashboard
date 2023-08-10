using Patterson.Agency.Dashboard.Domain.Shared.Enums;

namespace Patterson.Agency.Dashboard.Domain.Answer.Entities;

public class ClientAnswer : Answer
{
    public Guid UserId { get; }

    public ClientAnswer(Guid questionId, string text, SatisfactionLevel? satisfactionLevel, Guid userId) 
        : base(questionId, text,satisfactionLevel)
    {
        UserId = userId;
    }

    public ClientAnswer(Guid id, Guid questionId, string text, SatisfactionLevel? satisfactionLevel, Guid userId) 
        : base(id, questionId, text, satisfactionLevel)
    {
        UserId = userId;
    }
}