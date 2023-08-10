namespace Patterson.Agency.Dashboard.Domain.Form.Entities;

public class Form
{
    public Guid Id { get; }
    public string Description { get; }
    public IEnumerable<Question.Entities.Question> Questions { get; }

    public Form(Guid id, string description, IEnumerable<Question.Entities.Question> questions)
    {
        Id = id;
        Description = description;
        Questions = questions;
    }
}