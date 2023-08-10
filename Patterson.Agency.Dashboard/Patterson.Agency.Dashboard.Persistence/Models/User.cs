using System.ComponentModel.DataAnnotations;

namespace Patterson.Agency.Dashboard.Persistence.Models;

public class User
{
    [Key]
    public Guid Id { get; set; }
    public string Email { get; set; }
}