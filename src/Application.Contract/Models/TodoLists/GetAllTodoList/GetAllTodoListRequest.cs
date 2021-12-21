namespace Application.Contract.Models.TodoLists;

public record GetAllTodoListRequest : IRequest<ServiceResponse<GetAllTodoListResponse>>
{
    public static GetAllTodoListRequest Create()
    {
        return new GetAllTodoListRequest();
    }
}
