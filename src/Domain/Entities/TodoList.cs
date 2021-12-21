using CSB.Core.Domain.Common;
using CSB.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class TodoList : AuditableEntity, IEntity<int>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }
    public int UserId { get; set; }

    public IList<TodoItem> TodoItems { get; set; }
}
