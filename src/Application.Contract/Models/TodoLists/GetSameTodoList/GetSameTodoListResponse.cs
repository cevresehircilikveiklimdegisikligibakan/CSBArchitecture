namespace Application.Contract.Models.TodoLists;

public record GetSameTodoListResponse
{
    public int Id { get; init; }
    public string Title { get; init; }
}
