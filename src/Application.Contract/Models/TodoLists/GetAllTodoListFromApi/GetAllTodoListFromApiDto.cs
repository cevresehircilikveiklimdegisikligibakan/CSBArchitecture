namespace Application.Contract.Models.TodoLists;

public record GetAllTodoListFromApiDto
{
    public int Id { get; init; }
    public string Title { get; init; }
}
