using Patterson.Agency.Dashboard.Domain.Question.ValueObject;

namespace Patterson.Agency.Dashboard.Domain.Question.Entities;

public class Question
{
    public Guid Id { get; }
    public string Description { get; }
    public bool HasOptions { get; }
    public IEnumerable<Option> Options { get; }

    public Question(Guid id, string description, bool hasOptions, IEnumerable<Option> options)
    {
        Id = id;
        Description = description;
        HasOptions = hasOptions;
        Options = options;
    }
}