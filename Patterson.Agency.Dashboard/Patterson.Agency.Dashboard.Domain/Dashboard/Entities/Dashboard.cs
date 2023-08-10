using Patterson.Agency.Dashboard.Domain.Shared.Enums;

namespace Patterson.Agency.Dashboard.Domain.Dashboard.Entities;

public class Dashboard
{
    private IEnumerable<Answer.Entities.Answer> FilteredAnswers { get; set; }
    public IEnumerable<Answer.Entities.Answer> Answers => FilteredAnswers.ToList();
    public int TotalAnswers => FilteredAnswers.Count();
    public Dashboard(IEnumerable<Answer.Entities.Answer> answers)
    {
        FilteredAnswers = answers.ToList();
    }
    
    public void Filter(Guid questionId)
        => FilteredAnswers = FilteredAnswers.Where(x => x.QuestionId == questionId);
    
    public IDictionary<SatisfactionLevel,List<Answer.Entities.Answer>> GetTableBySatisfactionLevel()
        => FilteredAnswers.Where(x=> x.SatisfactionLevel.HasValue)
            .GroupBy(x => x.SatisfactionLevel)
            .ToDictionary(x => x.Key.Value, x => x.ToList());
    
    public IDictionary<Guid, int> GetTableTotalQuestions()
        => FilteredAnswers.GroupBy(x => x.QuestionId)
            .ToDictionary(x => x.Key, x => x.Count());
}