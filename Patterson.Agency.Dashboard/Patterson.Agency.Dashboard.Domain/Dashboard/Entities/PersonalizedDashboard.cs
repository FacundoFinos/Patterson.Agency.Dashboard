using Patterson.Agency.Dashboard.Domain.Answer.Entities;

namespace Patterson.Agency.Dashboard.Domain.Dashboard.Entities;

public class PersonalizedDashboard : Dashboard
{
    private new IEnumerable<ClientAnswer> FilteredAnswers { get; set; }
    public new IEnumerable<Answer.Entities.Answer> Answers => FilteredAnswers.ToList();

    public PersonalizedDashboard(IEnumerable<ClientAnswer> answers) : base(answers)
    {
        FilteredAnswers = answers;
    }
    
    public void UserAnswers(Guid userId)
        => FilteredAnswers = FilteredAnswers.Where(x => x.UserId == userId);
}