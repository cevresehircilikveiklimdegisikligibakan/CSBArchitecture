using CSB.Core.Domain.Common;
using CSB.Core.Entities;
using Domain.Enums;

namespace Domain.Entities;

public class TodoItem : AuditableEntity, IEntity<int>
{
    public int Id { get; set; }
    public int TodoListId { get; set; }
    public string Title { get; set; }
    public string Note { get; set; }
    public bool Done { get; set; }
    public PriorityLevel PriorityLevel { get; set; }
    public int UserId { get; set; }

    public TodoList TodoList { get; set; }
}
