using CSB.Core.Application.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Infrastructure.Persistence;

public interface IApplicationDbContext : IDataContext
{
    DbSet<TodoList> TodoList { get; set; }
    DbSet<TodoItem> TodoItem { get; set; }
}

