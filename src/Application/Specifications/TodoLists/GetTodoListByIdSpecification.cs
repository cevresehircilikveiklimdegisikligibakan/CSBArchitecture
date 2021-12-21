using CSB.Core.Application.Specifications;

namespace Application.Specifications.TodoLists;

internal sealed class GetTodoListByIdSpecification : ByIdSpecification<TodoList>
{
    private GetTodoListByIdSpecification() : base() { }
}
