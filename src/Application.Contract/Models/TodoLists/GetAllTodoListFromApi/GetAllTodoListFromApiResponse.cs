using System.Collections.ObjectModel;

namespace Application.Contract.Models.TodoLists;

public record GetAllTodoListFromApiResponse
{
    public IReadOnlyCollection<GetAllTodoListFromApiDto> TodoLists { get; init; }

    private GetAllTodoListFromApiResponse() { }

    public static GetAllTodoListFromApiResponse Create(IList<GetAllTodoListFromApiDto> todoLists)
    {
        return new GetAllTodoListFromApiResponse
        {
            TodoLists = new ReadOnlyCollection<GetAllTodoListFromApiDto>(todoLists)
        };
    }
}
