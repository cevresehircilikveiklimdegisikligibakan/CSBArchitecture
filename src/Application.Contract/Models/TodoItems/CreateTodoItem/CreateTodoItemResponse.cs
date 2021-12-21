namespace Application.Contract.Models.TodoItems;

public record CreateTodoItemResponse
{
    public int Id { get; init; }

    private CreateTodoItemResponse() { }

    public static CreateTodoItemResponse Create(int id)
    {
        return new CreateTodoItemResponse { Id = id };
    }
}
