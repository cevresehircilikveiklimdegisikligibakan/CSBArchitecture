using CSB.Core.Application.Specifications;
using System.Linq.Expressions;

namespace Application.Specifications.TodoLists;

internal sealed class GetTodoListSameSpecification : Specification<TodoList>
{
    private readonly int _id;
    private readonly string _title;

    private GetTodoListSameSpecification(int id, string title)
    {
        _id = id;
        _title = title;
    }

    public static GetTodoListSameSpecification Create(int id, string title)
    {
        return new GetTodoListSameSpecification(id, title);
    }

    public override Expression<Func<TodoList, bool>> ToExpression()
    {
        return x => x.Id != _id && x.Title == _title;
    }
}
