using CSB.Core.Application.Specifications;
using System.Linq.Expressions;

namespace Application.Specifications.TodoLists;

internal sealed class GetTodoListByTitleSpecification : Specification<TodoList>
{
    private readonly string _title;
    private GetTodoListByTitleSpecification(string title)
    {
        _title = title;
    }

    public static GetTodoListByTitleSpecification Create(string title)
    {
        return new GetTodoListByTitleSpecification(title);
    }

    public override Expression<Func<TodoList, bool>> ToExpression()
    {
        return x => x.Title == _title;
    }
}
