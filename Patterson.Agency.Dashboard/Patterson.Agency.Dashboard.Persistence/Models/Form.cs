using System.ComponentModel.DataAnnotations;

namespace Patterson.Agency.Dashboard.Persistence.Models;

public class Form
{
    [Key]
    public Guid Id { get; set; }
    public string Description { get; set; } 
    
}