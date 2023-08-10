using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patterson.Agency.Dashboard.Persistence.Models;

public class Question
{
    [Key]
    public Guid Id { get; set; }
    public string Description { get; set; }
    [ForeignKey("Form")]
    public Guid FormId { get; set; }
    public virtual Form Form { get; set; }
    public bool HasOptions { get; set; }
}