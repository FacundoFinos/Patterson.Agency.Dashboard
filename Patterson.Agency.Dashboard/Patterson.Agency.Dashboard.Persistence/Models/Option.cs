using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patterson.Agency.Dashboard.Persistence.Models;

public class Option
{
    [Key]
    public Guid Id { get; set; }
    [ForeignKey("Question")]
    public Guid QuestionId { get; set; }
    public Question Question { get; set; }
    public string Text { get; set; }
}