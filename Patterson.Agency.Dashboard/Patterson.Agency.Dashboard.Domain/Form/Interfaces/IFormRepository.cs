namespace Patterson.Agency.Dashboard.Domain.Form.Interfaces;

public interface IFormRepository
{
    public Task<Entities.Form> Find(Guid formId);
    Task<Entities.Form> Find(Guid formId, Guid userId);
}