using Patterson.Agency.Dashboard.Domain.Answer.Entities;

namespace Patterson.Agency.Dashboard.Domain.Answer.Interfaces;

public interface IFormQuestionsService
{
    public Task Save(FormAnswer formAnswers);
}