using Application.Infrastructure.Persistence;
using CSB.Core.Infrastructure.Persistence;
using Domain.Entities;
using Infrastructure.Persistence.ModelBuilders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence;

internal class ApplicationDbContext : EFPgsqlDbContext, IApplicationDbContext
{
    private const string CONNECTION_STRING_NAME = "PostgreSQLConnectionString";
    public ApplicationDbContext(IConfiguration configuration, IServiceProvider provider) : base(CONNECTION_STRING_NAME, configuration,provider) { }

    public DbSet<TodoList> TodoList { get; set; }
    public DbSet<TodoItem> TodoItem { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        PostgreSqlModelBuilder.Build(ref modelBuilder);
    }
}
