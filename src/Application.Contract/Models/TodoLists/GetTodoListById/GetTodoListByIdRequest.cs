namespace Application.Contract.Models.TodoLists;

public record GetTodoListByIdRequest : IRequest<ServiceResponse<GetTodoListByIdResponse>>
{
    public int Id { get; set; }

    public static GetTodoListByIdRequest Create(int id)
    {
        return new GetTodoListByIdRequest
        {
            Id = id
        };
    }
}
