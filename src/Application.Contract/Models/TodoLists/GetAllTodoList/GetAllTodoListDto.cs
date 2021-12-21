namespace Application.Contract.Models.TodoLists;

public record GetAllTodoListDto
{
    public int Id { get; init; }
    public string Title { get; init; }
}
