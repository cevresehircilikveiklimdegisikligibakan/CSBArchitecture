namespace Application.Contract.Models.TodoLists;

public record DeleteTodoListRequest : IRequest<ServiceResponse<DeleteTodoListResponse>>
{
    public int Id { get; set; }

    public static DeleteTodoListRequest Create(int id)
    {
        return new DeleteTodoListRequest
        {
            Id = id
        };
    }
}
