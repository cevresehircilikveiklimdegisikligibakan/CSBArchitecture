namespace Application.Contract.Models.TodoLists;

public record GetTodoListByIdFromCacheResponse
{
    public int Id { get; init; }
    public string Title { get; init; }
}
