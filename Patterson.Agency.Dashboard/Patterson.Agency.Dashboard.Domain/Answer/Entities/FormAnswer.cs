namespace Patterson.Agency.Dashboard.Domain.Answer.Entities;

public class FormAnswer
{
    public Guid FormId { get; }
    public IEnumerable<Answer> Answers { get; }

    public FormAnswer(Guid formId, IEnumerable<Answer> answers)
    {
        FormId = formId;
        Answers = answers;
    }
}