namespace Application.Contract.Models.TodoLists;

public record GetTodoListByIdResponse
{
    public int Id { get; init; }
    public string Title { get; init; }
}
