namespace Application.Contract.Models.TodoLists;

public record DeleteTodoListResponse
{
    private DeleteTodoListResponse() { }

    public static DeleteTodoListResponse Create()
    {
        return new DeleteTodoListResponse();
    }
}
