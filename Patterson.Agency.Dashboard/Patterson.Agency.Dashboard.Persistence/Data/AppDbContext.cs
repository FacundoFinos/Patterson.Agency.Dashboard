using Microsoft.EntityFrameworkCore;
using Patterson.Agency.Dashboard.Persistence.Models;

namespace Patterson.Agency.Dashboard.Persistence.Data;

public class AppDbContext: DbContext
{
    public DbSet<Form> Forms { get; init; } 
    public DbSet<Question> Questions { get; init; }
    public DbSet<Answer> Answers { get; init; } 
    public DbSet<User> Users { get; init; }
    public DbSet<Option> Options { get; init; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}