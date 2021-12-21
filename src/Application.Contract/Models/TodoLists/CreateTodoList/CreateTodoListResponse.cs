namespace Application.Contract.Models.TodoLists;

public record CreateTodoListResponse
{
    public int Id { get; init; }

    private CreateTodoListResponse() { }

    public static CreateTodoListResponse Create(int id)
    {
        return new CreateTodoListResponse { Id = id };
    }
}
