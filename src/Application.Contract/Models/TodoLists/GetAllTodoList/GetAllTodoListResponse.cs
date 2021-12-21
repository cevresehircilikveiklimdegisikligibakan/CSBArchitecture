using System.Collections.ObjectModel;

namespace Application.Contract.Models.TodoLists;

public record GetAllTodoListResponse
{
    public IReadOnlyCollection<GetAllTodoListDto> TodoLists { get; init; }

    private GetAllTodoListResponse() { }

    public static GetAllTodoListResponse Create(IList<GetAllTodoListDto> todoLists)
    {
        return new GetAllTodoListResponse
        {
            TodoLists = new ReadOnlyCollection<GetAllTodoListDto>(todoLists)
        };
    }
}
